using System;
using System.Diagnostics;
using System.Reflection;
using System.Security;
using System.Text;

namespace UnityEngine
{
	// Token: 0x020002D3 RID: 723
	public class StackTraceUtility
	{
		// Token: 0x060021E3 RID: 8675 RVA: 0x0000DA19 File Offset: 0x0000BC19
		internal static void SetProjectFolder(string folder)
		{
			StackTraceUtility.projectFolder = folder;
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x0002A228 File Offset: 0x00028428
		[SecuritySafeCritical]
		public static string ExtractStackTrace()
		{
			StackTrace stackTrace = new StackTrace(1, true);
			return StackTraceUtility.ExtractFormattedStackTrace(stackTrace).ToString();
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x0002A24C File Offset: 0x0002844C
		private static bool IsSystemStacktraceType(object name)
		{
			string text = (string)name;
			return text.StartsWith("UnityEditor.") || text.StartsWith("UnityEngine.") || text.StartsWith("System.") || text.StartsWith("UnityScript.Lang.") || text.StartsWith("Boo.Lang.") || text.StartsWith("UnityEngine.SetupCoroutine");
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x0002A2C0 File Offset: 0x000284C0
		public static string ExtractStringFromException(object exception)
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			StackTraceUtility.ExtractStringFromExceptionInternal(exception, out empty, out empty2);
			return empty + "\n" + empty2;
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x0002A2F0 File Offset: 0x000284F0
		[SecuritySafeCritical]
		internal static void ExtractStringFromExceptionInternal(object exceptiono, out string message, out string stackTrace)
		{
			if (exceptiono == null)
			{
				throw new ArgumentException("ExtractStringFromExceptionInternal called with null exception");
			}
			Exception ex = exceptiono as Exception;
			if (ex == null)
			{
				throw new ArgumentException("ExtractStringFromExceptionInternal called with an exceptoin that was not of type System.Exception");
			}
			StringBuilder stringBuilder = new StringBuilder((ex.StackTrace != null) ? (ex.StackTrace.Length * 2) : 512);
			message = string.Empty;
			string text = string.Empty;
			while (ex != null)
			{
				if (text.Length == 0)
				{
					text = ex.StackTrace;
				}
				else
				{
					text = ex.StackTrace + "\n" + text;
				}
				string text2 = ex.GetType().Name;
				string text3 = string.Empty;
				if (ex.Message != null)
				{
					text3 = ex.Message;
				}
				if (text3.Trim().Length != 0)
				{
					text2 += ": ";
					text2 += text3;
				}
				message = text2;
				if (ex.InnerException != null)
				{
					text = "Rethrow as " + text2 + "\n" + text;
				}
				ex = ex.InnerException;
			}
			stringBuilder.Append(text + "\n");
			StackTrace stackTrace2 = new StackTrace(1, true);
			stringBuilder.Append(StackTraceUtility.ExtractFormattedStackTrace(stackTrace2));
			stackTrace = stringBuilder.ToString();
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x0002A434 File Offset: 0x00028634
		internal static string PostprocessStacktrace(string oldString, bool stripEngineInternalInformation)
		{
			if (oldString == null)
			{
				return string.Empty;
			}
			string[] array = oldString.Split(new char[] { '\n' });
			StringBuilder stringBuilder = new StringBuilder(oldString.Length);
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = array[i].Trim();
			}
			for (int j = 0; j < array.Length; j++)
			{
				string text = array[j];
				if (text.Length != 0 && text[0] != '\n')
				{
					if (!text.StartsWith("in (unmanaged)"))
					{
						if (stripEngineInternalInformation && text.StartsWith("UnityEditor.EditorGUIUtility:RenderGameViewCameras"))
						{
							break;
						}
						if (stripEngineInternalInformation && j < array.Length - 1 && StackTraceUtility.IsSystemStacktraceType(text))
						{
							if (StackTraceUtility.IsSystemStacktraceType(array[j + 1]))
							{
								goto IL_0261;
							}
							int num = text.IndexOf(" (at");
							if (num != -1)
							{
								text = text.Substring(0, num);
							}
						}
						if (text.IndexOf("(wrapper managed-to-native)") == -1)
						{
							if (text.IndexOf("(wrapper delegate-invoke)") == -1)
							{
								if (text.IndexOf("at <0x00000> <unknown method>") == -1)
								{
									if (!stripEngineInternalInformation || !text.StartsWith("[") || !text.EndsWith("]"))
									{
										if (text.StartsWith("at "))
										{
											text = text.Remove(0, 3);
										}
										int num2 = text.IndexOf("[0x");
										int num3 = -1;
										if (num2 != -1)
										{
											num3 = text.IndexOf("]", num2);
										}
										if (num2 != -1 && num3 > num2)
										{
											text = text.Remove(num2, num3 - num2 + 1);
										}
										text = text.Replace("  in <filename unknown>:0", string.Empty);
										text = text.Replace(StackTraceUtility.projectFolder, string.Empty);
										text = text.Replace('\\', '/');
										int num4 = text.LastIndexOf("  in ");
										if (num4 != -1)
										{
											text = text.Remove(num4, 5);
											text = text.Insert(num4, " (at ");
											text = text.Insert(text.Length, ")");
										}
										stringBuilder.Append(text + "\n");
									}
								}
							}
						}
					}
				}
				IL_0261:;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0002A6B8 File Offset: 0x000288B8
		[SecuritySafeCritical]
		internal static string ExtractFormattedStackTrace(StackTrace stackTrace)
		{
			StringBuilder stringBuilder = new StringBuilder(255);
			for (int i = 0; i < stackTrace.FrameCount; i++)
			{
				StackFrame frame = stackTrace.GetFrame(i);
				MethodBase method = frame.GetMethod();
				if (method != null)
				{
					Type declaringType = method.DeclaringType;
					if (declaringType != null)
					{
						string @namespace = declaringType.Namespace;
						if (@namespace != null && @namespace.Length != 0)
						{
							stringBuilder.Append(@namespace);
							stringBuilder.Append(".");
						}
						stringBuilder.Append(declaringType.Name);
						stringBuilder.Append(":");
						stringBuilder.Append(method.Name);
						stringBuilder.Append("(");
						int j = 0;
						ParameterInfo[] parameters = method.GetParameters();
						bool flag = true;
						while (j < parameters.Length)
						{
							if (!flag)
							{
								stringBuilder.Append(", ");
							}
							else
							{
								flag = false;
							}
							stringBuilder.Append(parameters[j].ParameterType.Name);
							j++;
						}
						stringBuilder.Append(")");
						string text = frame.GetFileName();
						if (text != null && (!(declaringType.Name == "Debug") || !(declaringType.Namespace == "UnityEngine")))
						{
							stringBuilder.Append(" (at ");
							if (text.StartsWith(StackTraceUtility.projectFolder))
							{
								text = text.Substring(StackTraceUtility.projectFolder.Length, text.Length - StackTraceUtility.projectFolder.Length);
							}
							stringBuilder.Append(text);
							stringBuilder.Append(":");
							stringBuilder.Append(frame.GetFileLineNumber().ToString());
							stringBuilder.Append(")");
						}
						stringBuilder.Append("\n");
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x04000AFD RID: 2813
		private static string projectFolder = string.Empty;
	}
}
