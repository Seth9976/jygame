using System;
using System.IO;

namespace System.ComponentModel
{
	/// <summary>Provides methods to verify the machine name and path conform to a specific syntax. This class cannot be inherited.</summary>
	// Token: 0x020001AE RID: 430
	public static class SyntaxCheck
	{
		/// <summary>Checks the syntax of the machine name to confirm that it does not contain "\".</summary>
		/// <returns>true if <paramref name="value" /> matches the proper machine name format; otherwise, false.</returns>
		/// <param name="value">A string containing the machine name to check. </param>
		// Token: 0x06000EF4 RID: 3828 RVA: 0x0000C5F9 File Offset: 0x0000A7F9
		public static bool CheckMachineName(string value)
		{
			return value != null && value.Trim().Length != 0 && value.IndexOf('\\') == -1;
		}

		/// <summary>Checks the syntax of the path to see whether it starts with "\\".</summary>
		/// <returns>true if <paramref name="value" /> matches the proper path format; otherwise, false.</returns>
		/// <param name="value">A string containing the path to check. </param>
		// Token: 0x06000EF5 RID: 3829 RVA: 0x0000C61E File Offset: 0x0000A81E
		public static bool CheckPath(string value)
		{
			return value != null && value.Trim().Length != 0 && value.StartsWith("\\\\");
		}

		/// <summary>Checks the syntax of the path to see if it starts with "\" or drive letter "C:".</summary>
		/// <returns>true if <paramref name="value" /> matches the proper path format; otherwise, false.</returns>
		/// <param name="value">A string containing the path to check. </param>
		// Token: 0x06000EF6 RID: 3830 RVA: 0x0000C643 File Offset: 0x0000A843
		public static bool CheckRootedPath(string value)
		{
			return value != null && value.Trim().Length != 0 && Path.IsPathRooted(value);
		}
	}
}
