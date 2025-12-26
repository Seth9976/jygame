using System;
using System.Reflection;
using System.Security;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Webplayer security related class.</para>
	/// </summary>
	// Token: 0x02000084 RID: 132
	public sealed class Security
	{
		/// <summary>
		///   <para>Prefetch the webplayer socket security policy from a non-default port number.</para>
		/// </summary>
		/// <param name="ip">IP address of server.</param>
		/// <param name="atPort">Port from where socket policy is read.</param>
		/// <param name="timeout">Time to wait for response.</param>
		// Token: 0x060007CA RID: 1994 RVA: 0x00014654 File Offset: 0x00012854
		[ExcludeFromDocs]
		public static bool PrefetchSocketPolicy(string ip, int atPort)
		{
			int num = 3000;
			return Security.PrefetchSocketPolicy(ip, atPort, num);
		}

		/// <summary>
		///   <para>Prefetch the webplayer socket security policy from a non-default port number.</para>
		/// </summary>
		/// <param name="ip">IP address of server.</param>
		/// <param name="atPort">Port from where socket policy is read.</param>
		/// <param name="timeout">Time to wait for response.</param>
		// Token: 0x060007CB RID: 1995 RVA: 0x000021E1 File Offset: 0x000003E1
		public static bool PrefetchSocketPolicy(string ip, int atPort, [DefaultValue("3000")] int timeout)
		{
			return true;
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x00014670 File Offset: 0x00012870
		private static MethodInfo GetUnityCrossDomainHelperMethod(string methodname)
		{
			Type type = Types.GetType("UnityEngine.UnityCrossDomainHelper", "CrossDomainPolicyParser, Version=1.0.0.0, Culture=neutral");
			if (type == null)
			{
				throw new SecurityException("Cant find type UnityCrossDomainHelper");
			}
			MethodInfo method = type.GetMethod(methodname);
			if (method == null)
			{
				throw new SecurityException("Cant find " + methodname);
			}
			return method;
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x000146C0 File Offset: 0x000128C0
		internal static string TokenToHex(byte[] token)
		{
			if (token == null || 8 > token.Length)
			{
				return string.Empty;
			}
			return string.Format("{0:x2}{1:x2}{2:x2}{3:x2}{4:x2}{5:x2}{6:x2}{7:x2}", new object[]
			{
				token[0],
				token[1],
				token[2],
				token[3],
				token[4],
				token[5],
				token[6],
				token[7]
			});
		}

		/// <summary>
		///   <para>Loads an assembly and checks that it is allowed to be used in the webplayer.
		/// Note: The single argument version of this API will always issue an error message.  An authorisation key is always needed.</para>
		/// </summary>
		/// <param name="assemblyData">Assembly to verify.</param>
		/// <param name="authorizationKey">Public key used to verify assembly.</param>
		/// <returns>
		///   <para>Loaded, verified, assembly, or null if the assembly cannot be verfied.</para>
		/// </returns>
		// Token: 0x060007CE RID: 1998 RVA: 0x00002096 File Offset: 0x00000296
		[SecuritySafeCritical]
		public static Assembly LoadAndVerifyAssembly(byte[] assemblyData, string authorizationKey)
		{
			return null;
		}

		/// <summary>
		///   <para>Loads an assembly and checks that it is allowed to be used in the webplayer.
		/// Note: The single argument version of this API will always issue an error message.  An authorisation key is always needed.</para>
		/// </summary>
		/// <param name="assemblyData">Assembly to verify.</param>
		/// <param name="authorizationKey">Public key used to verify assembly.</param>
		/// <returns>
		///   <para>Loaded, verified, assembly, or null if the assembly cannot be verfied.</para>
		/// </returns>
		// Token: 0x060007CF RID: 1999 RVA: 0x00002096 File Offset: 0x00000296
		[SecuritySafeCritical]
		public static Assembly LoadAndVerifyAssembly(byte[] assemblyData)
		{
			return null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002096 File Offset: 0x00000296
		[SecuritySafeCritical]
		private static Assembly LoadAndVerifyAssemblyInternal(byte[] assemblyData)
		{
			return null;
		}
	}
}
