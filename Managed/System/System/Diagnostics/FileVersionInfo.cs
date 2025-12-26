using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Permissions;
using System.Text;

namespace System.Diagnostics
{
	/// <summary>Provides version information for a physical file on disk.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000232 RID: 562
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public sealed class FileVersionInfo
	{
		// Token: 0x0600131C RID: 4892 RVA: 0x0003EFC0 File Offset: 0x0003D1C0
		private FileVersionInfo()
		{
			this.comments = null;
			this.companyname = null;
			this.filedescription = null;
			this.filename = null;
			this.fileversion = null;
			this.internalname = null;
			this.language = null;
			this.legalcopyright = null;
			this.legaltrademarks = null;
			this.originalfilename = null;
			this.privatebuild = null;
			this.productname = null;
			this.productversion = null;
			this.specialbuild = null;
			this.isdebug = false;
			this.ispatched = false;
			this.isprerelease = false;
			this.isprivatebuild = false;
			this.isspecialbuild = false;
			this.filemajorpart = 0;
			this.fileminorpart = 0;
			this.filebuildpart = 0;
			this.fileprivatepart = 0;
			this.productmajorpart = 0;
			this.productminorpart = 0;
			this.productbuildpart = 0;
			this.productprivatepart = 0;
		}

		/// <summary>Gets the comments associated with the file.</summary>
		/// <returns>The comments associated with the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600131D RID: 4893 RVA: 0x0000F366 File Offset: 0x0000D566
		public string Comments
		{
			get
			{
				return this.comments;
			}
		}

		/// <summary>Gets the name of the company that produced the file.</summary>
		/// <returns>The name of the company that produced the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0000F36E File Offset: 0x0000D56E
		public string CompanyName
		{
			get
			{
				return this.companyname;
			}
		}

		/// <summary>Gets the build number of the file.</summary>
		/// <returns>A value representing the build number of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600131F RID: 4895 RVA: 0x0000F376 File Offset: 0x0000D576
		public int FileBuildPart
		{
			get
			{
				return this.filebuildpart;
			}
		}

		/// <summary>Gets the description of the file.</summary>
		/// <returns>The description of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x0000F37E File Offset: 0x0000D57E
		public string FileDescription
		{
			get
			{
				return this.filedescription;
			}
		}

		/// <summary>Gets the major part of the version number.</summary>
		/// <returns>A value representing the major part of the version number or 0 (zero) if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x0000F386 File Offset: 0x0000D586
		public int FileMajorPart
		{
			get
			{
				return this.filemajorpart;
			}
		}

		/// <summary>Gets the minor part of the version number of the file.</summary>
		/// <returns>A value representing the minor part of the version number of the file or 0 (zero) if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x0000F38E File Offset: 0x0000D58E
		public int FileMinorPart
		{
			get
			{
				return this.fileminorpart;
			}
		}

		/// <summary>Gets the name of the file that this instance of <see cref="T:System.Diagnostics.FileVersionInfo" /> describes.</summary>
		/// <returns>The name of the file described by this instance of <see cref="T:System.Diagnostics.FileVersionInfo" />.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001323 RID: 4899 RVA: 0x0000F396 File Offset: 0x0000D596
		public string FileName
		{
			get
			{
				if (SecurityManager.SecurityEnabled)
				{
					new FileIOPermission(FileIOPermissionAccess.PathDiscovery, this.filename).Demand();
				}
				return this.filename;
			}
		}

		/// <summary>Gets the file private part number.</summary>
		/// <returns>A value representing the file private part number or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
		public int FilePrivatePart
		{
			get
			{
				return this.fileprivatepart;
			}
		}

		/// <summary>Gets the file version number.</summary>
		/// <returns>The version number of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001325 RID: 4901 RVA: 0x0000F3C1 File Offset: 0x0000D5C1
		public string FileVersion
		{
			get
			{
				return this.fileversion;
			}
		}

		/// <summary>Gets the internal name of the file, if one exists.</summary>
		/// <returns>The internal name of the file. If none exists, this property will contain the original name of the file without the extension.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x0000F3C9 File Offset: 0x0000D5C9
		public string InternalName
		{
			get
			{
				return this.internalname;
			}
		}

		/// <summary>Gets a value that specifies whether the file contains debugging information or is compiled with debugging features enabled.</summary>
		/// <returns>true if the file contains debugging information or is compiled with debugging features enabled; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x0000F3D1 File Offset: 0x0000D5D1
		public bool IsDebug
		{
			get
			{
				return this.isdebug;
			}
		}

		/// <summary>Gets a value that specifies whether the file has been modified and is not identical to the original shipping file of the same version number.</summary>
		/// <returns>true if the file is patched; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x0000F3D9 File Offset: 0x0000D5D9
		public bool IsPatched
		{
			get
			{
				return this.ispatched;
			}
		}

		/// <summary>Gets a value that specifies whether the file is a development version, rather than a commercially released product.</summary>
		/// <returns>true if the file is prerelease; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x0000F3E1 File Offset: 0x0000D5E1
		public bool IsPreRelease
		{
			get
			{
				return this.isprerelease;
			}
		}

		/// <summary>Gets a value that specifies whether the file was built using standard release procedures.</summary>
		/// <returns>true if the file is a private build; false if the file was built using standard release procedures or if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x0000F3E9 File Offset: 0x0000D5E9
		public bool IsPrivateBuild
		{
			get
			{
				return this.isprivatebuild;
			}
		}

		/// <summary>Gets a value that specifies whether the file is a special build.</summary>
		/// <returns>true if the file is a special build; otherwise, false.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x0000F3F1 File Offset: 0x0000D5F1
		public bool IsSpecialBuild
		{
			get
			{
				return this.isspecialbuild;
			}
		}

		/// <summary>Gets the default language string for the version info block.</summary>
		/// <returns>The description string for the Microsoft Language Identifier in the version resource or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x0000F3F9 File Offset: 0x0000D5F9
		public string Language
		{
			get
			{
				return this.language;
			}
		}

		/// <summary>Gets all copyright notices that apply to the specified file.</summary>
		/// <returns>The copyright notices that apply to the specified file.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x0000F401 File Offset: 0x0000D601
		public string LegalCopyright
		{
			get
			{
				return this.legalcopyright;
			}
		}

		/// <summary>Gets the trademarks and registered trademarks that apply to the file.</summary>
		/// <returns>The trademarks and registered trademarks that apply to the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x0000F409 File Offset: 0x0000D609
		public string LegalTrademarks
		{
			get
			{
				return this.legaltrademarks;
			}
		}

		/// <summary>Gets the name the file was created with.</summary>
		/// <returns>The name the file was created with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x0000F411 File Offset: 0x0000D611
		public string OriginalFilename
		{
			get
			{
				return this.originalfilename;
			}
		}

		/// <summary>Gets information about a private version of the file.</summary>
		/// <returns>Information about a private version of the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x0000F419 File Offset: 0x0000D619
		public string PrivateBuild
		{
			get
			{
				return this.privatebuild;
			}
		}

		/// <summary>Gets the build number of the product this file is associated with.</summary>
		/// <returns>A value representing the build number of the product this file is associated with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x0000F421 File Offset: 0x0000D621
		public int ProductBuildPart
		{
			get
			{
				return this.productbuildpart;
			}
		}

		/// <summary>Gets the major part of the version number for the product this file is associated with.</summary>
		/// <returns>A value representing the major part of the product version number or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x0000F429 File Offset: 0x0000D629
		public int ProductMajorPart
		{
			get
			{
				return this.productmajorpart;
			}
		}

		/// <summary>Gets the minor part of the version number for the product the file is associated with.</summary>
		/// <returns>A value representing the minor part of the product version number or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x0000F431 File Offset: 0x0000D631
		public int ProductMinorPart
		{
			get
			{
				return this.productminorpart;
			}
		}

		/// <summary>Gets the name of the product this file is distributed with.</summary>
		/// <returns>The name of the product this file is distributed with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06001334 RID: 4916 RVA: 0x0000F439 File Offset: 0x0000D639
		public string ProductName
		{
			get
			{
				return this.productname;
			}
		}

		/// <summary>Gets the private part number of the product this file is associated with.</summary>
		/// <returns>A value representing the private part number of the product this file is associated with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001335 RID: 4917 RVA: 0x0000F441 File Offset: 0x0000D641
		public int ProductPrivatePart
		{
			get
			{
				return this.productprivatepart;
			}
		}

		/// <summary>Gets the version of the product this file is distributed with.</summary>
		/// <returns>The version of the product this file is distributed with or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001336 RID: 4918 RVA: 0x0000F449 File Offset: 0x0000D649
		public string ProductVersion
		{
			get
			{
				return this.productversion;
			}
		}

		/// <summary>Gets the special build information for the file.</summary>
		/// <returns>The special build information for the file or null if the file did not contain version information.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06001337 RID: 4919 RVA: 0x0000F451 File Offset: 0x0000D651
		public string SpecialBuild
		{
			get
			{
				return this.specialbuild;
			}
		}

		// Token: 0x06001338 RID: 4920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetVersionInfo_internal(string fileName);

		/// <summary>Returns a <see cref="T:System.Diagnostics.FileVersionInfo" /> representing the version information associated with the specified file.</summary>
		/// <returns>A <see cref="T:System.Diagnostics.FileVersionInfo" /> containing information about the file. If the file did not contain version information, the <see cref="T:System.Diagnostics.FileVersionInfo" /> contains only the name of the file requested.</returns>
		/// <param name="fileName">The fully qualified path and name of the file to retrieve the version information for. </param>
		/// <exception cref="T:System.IO.FileNotFoundException">The file specified cannot be found. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x06001339 RID: 4921 RVA: 0x0003F090 File Offset: 0x0003D290
		public static FileVersionInfo GetVersionInfo(string fileName)
		{
			if (SecurityManager.SecurityEnabled)
			{
				new FileIOPermission(FileIOPermissionAccess.Read, fileName).Demand();
			}
			string fullPath = Path.GetFullPath(fileName);
			if (!File.Exists(fullPath))
			{
				throw new FileNotFoundException(fileName);
			}
			FileVersionInfo fileVersionInfo = new FileVersionInfo();
			fileVersionInfo.GetVersionInfo_internal(fileName);
			return fileVersionInfo;
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x0000F459 File Offset: 0x0000D659
		private static void AppendFormat(StringBuilder sb, string format, params object[] args)
		{
			sb.AppendFormat(format, args);
		}

		/// <summary>Returns a partial list of properties in the <see cref="T:System.Diagnostics.FileVersionInfo" /> and their values.</summary>
		/// <returns>A list of the following properties in this class and their values: <see cref="P:System.Diagnostics.FileVersionInfo.FileName" />, <see cref="P:System.Diagnostics.FileVersionInfo.InternalName" />, <see cref="P:System.Diagnostics.FileVersionInfo.OriginalFilename" />, <see cref="P:System.Diagnostics.FileVersionInfo.FileVersion" />, <see cref="P:System.Diagnostics.FileVersionInfo.FileDescription" />, <see cref="P:System.Diagnostics.FileVersionInfo.ProductName" />, <see cref="P:System.Diagnostics.FileVersionInfo.ProductVersion" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsDebug" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPatched" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPreRelease" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsPrivateBuild" />, <see cref="P:System.Diagnostics.FileVersionInfo.IsSpecialBuild" />,<see cref="P:System.Diagnostics.FileVersionInfo.Language" />.If the file did not contain version information, this list will contain only the name of the requested file. Boolean values will be false, and all other entries will be null.</returns>
		/// <filterpriority>2</filterpriority>
		// Token: 0x0600133B RID: 4923 RVA: 0x0003F0DC File Offset: 0x0003D2DC
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			FileVersionInfo.AppendFormat(stringBuilder, "File:             {0}{1}", new object[]
			{
				this.FileName,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "InternalName:     {0}{1}", new object[]
			{
				this.internalname,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "OriginalFilename: {0}{1}", new object[]
			{
				this.originalfilename,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "FileVersion:      {0}{1}", new object[]
			{
				this.fileversion,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "FileDescription:  {0}{1}", new object[]
			{
				this.filedescription,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Product:          {0}{1}", new object[]
			{
				this.productname,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "ProductVersion:   {0}{1}", new object[]
			{
				this.productversion,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Debug:            {0}{1}", new object[]
			{
				this.isdebug,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Patched:          {0}{1}", new object[]
			{
				this.ispatched,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "PreRelease:       {0}{1}", new object[]
			{
				this.isprerelease,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "PrivateBuild:     {0}{1}", new object[]
			{
				this.isprivatebuild,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "SpecialBuild:     {0}{1}", new object[]
			{
				this.isspecialbuild,
				Environment.NewLine
			});
			FileVersionInfo.AppendFormat(stringBuilder, "Language          {0}{1}", new object[]
			{
				this.language,
				Environment.NewLine
			});
			return stringBuilder.ToString();
		}

		// Token: 0x04000580 RID: 1408
		private string comments;

		// Token: 0x04000581 RID: 1409
		private string companyname;

		// Token: 0x04000582 RID: 1410
		private string filedescription;

		// Token: 0x04000583 RID: 1411
		private string filename;

		// Token: 0x04000584 RID: 1412
		private string fileversion;

		// Token: 0x04000585 RID: 1413
		private string internalname;

		// Token: 0x04000586 RID: 1414
		private string language;

		// Token: 0x04000587 RID: 1415
		private string legalcopyright;

		// Token: 0x04000588 RID: 1416
		private string legaltrademarks;

		// Token: 0x04000589 RID: 1417
		private string originalfilename;

		// Token: 0x0400058A RID: 1418
		private string privatebuild;

		// Token: 0x0400058B RID: 1419
		private string productname;

		// Token: 0x0400058C RID: 1420
		private string productversion;

		// Token: 0x0400058D RID: 1421
		private string specialbuild;

		// Token: 0x0400058E RID: 1422
		private bool isdebug;

		// Token: 0x0400058F RID: 1423
		private bool ispatched;

		// Token: 0x04000590 RID: 1424
		private bool isprerelease;

		// Token: 0x04000591 RID: 1425
		private bool isprivatebuild;

		// Token: 0x04000592 RID: 1426
		private bool isspecialbuild;

		// Token: 0x04000593 RID: 1427
		private int filemajorpart;

		// Token: 0x04000594 RID: 1428
		private int fileminorpart;

		// Token: 0x04000595 RID: 1429
		private int filebuildpart;

		// Token: 0x04000596 RID: 1430
		private int fileprivatepart;

		// Token: 0x04000597 RID: 1431
		private int productmajorpart;

		// Token: 0x04000598 RID: 1432
		private int productminorpart;

		// Token: 0x04000599 RID: 1433
		private int productbuildpart;

		// Token: 0x0400059A RID: 1434
		private int productprivatepart;
	}
}
