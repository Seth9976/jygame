using System;

namespace System.Net
{
	/// <summary>Container class for <see cref="T:System.Net.WebRequestMethods.Ftp" />, <see cref="T:System.Net.WebRequestMethods.File" />, and <see cref="T:System.Net.WebRequestMethods.Http" /> classes. This class cannot be inherited</summary>
	// Token: 0x0200043C RID: 1084
	public static class WebRequestMethods
	{
		/// <summary>Represents the types of file protocol methods that can be used with a FILE request. This class cannot be inherited.</summary>
		// Token: 0x0200043D RID: 1085
		public static class File
		{
			/// <summary>Represents the FILE GET protocol method that is used to retrieve a file from a specified location.</summary>
			// Token: 0x040017A3 RID: 6051
			public const string DownloadFile = "GET";

			/// <summary>Represents the FILE PUT protocol method that is used to copy a file to a specified location.</summary>
			// Token: 0x040017A4 RID: 6052
			public const string UploadFile = "PUT";
		}

		/// <summary>Represents the types of FTP protocol methods that can be used with an FTP request. This class cannot be inherited.</summary>
		// Token: 0x0200043E RID: 1086
		public static class Ftp
		{
			/// <summary>Represents the FTP APPE protocol method that is used to append a file to an existing file on an FTP server.</summary>
			// Token: 0x040017A5 RID: 6053
			public const string AppendFile = "APPE";

			/// <summary>Represents the FTP DELE protocol method that is used to delete a file on an FTP server.</summary>
			// Token: 0x040017A6 RID: 6054
			public const string DeleteFile = "DELE";

			/// <summary>Represents the FTP RETR protocol method that is used to download a file from an FTP server.</summary>
			// Token: 0x040017A7 RID: 6055
			public const string DownloadFile = "RETR";

			/// <summary>Represents the FTP SIZE protocol method that is used to retrieve the size of a file on an FTP server.</summary>
			// Token: 0x040017A8 RID: 6056
			public const string GetFileSize = "SIZE";

			/// <summary>Represents the FTP MDTM protocol method that is used to retrieve the date-time stamp from a file on an FTP server.</summary>
			// Token: 0x040017A9 RID: 6057
			public const string GetDateTimestamp = "MDTM";

			/// <summary>Represents the FTP NLIST protocol method that gets a short listing of the files on an FTP server.</summary>
			// Token: 0x040017AA RID: 6058
			public const string ListDirectory = "NLST";

			/// <summary>Represents the FTP LIST protocol method that gets a detailed listing of the files on an FTP server.</summary>
			// Token: 0x040017AB RID: 6059
			public const string ListDirectoryDetails = "LIST";

			/// <summary>Represents the FTP MKD protocol method creates a directory on an FTP server.</summary>
			// Token: 0x040017AC RID: 6060
			public const string MakeDirectory = "MKD";

			/// <summary>Represents the FTP PWD protocol method that prints the name of the current working directory.</summary>
			// Token: 0x040017AD RID: 6061
			public const string PrintWorkingDirectory = "PWD";

			/// <summary>Represents the FTP RMD protocol method that removes a directory.</summary>
			// Token: 0x040017AE RID: 6062
			public const string RemoveDirectory = "RMD";

			/// <summary>Represents the FTP RENAME protocol method that renames a directory.</summary>
			// Token: 0x040017AF RID: 6063
			public const string Rename = "RENAME";

			/// <summary>Represents the FTP STOR protocol method that uploads a file to an FTP server.</summary>
			// Token: 0x040017B0 RID: 6064
			public const string UploadFile = "STOR";

			/// <summary>Represents the FTP STOU protocol that uploads a file with a unique name to an FTP server.</summary>
			// Token: 0x040017B1 RID: 6065
			public const string UploadFileWithUniqueName = "STOU";
		}

		/// <summary>Represents the types of HTTP protocol methods that can be used with an HTTP request.</summary>
		// Token: 0x0200043F RID: 1087
		public static class Http
		{
			/// <summary>Represents the HTTP CONNECT protocol method that is used with a proxy that can dynamically switch to tunneling, as in the case of SSL tunneling.</summary>
			// Token: 0x040017B2 RID: 6066
			public const string Connect = "CONNECT";

			/// <summary>Represents an HTTP GET protocol method. </summary>
			// Token: 0x040017B3 RID: 6067
			public const string Get = "GET";

			/// <summary>Represents an HTTP HEAD protocol method. The HEAD method is identical to GET except that the server only returns message-headers in the response, without a message-body.</summary>
			// Token: 0x040017B4 RID: 6068
			public const string Head = "HEAD";

			/// <summary>Represents an HTTP MKCOL request that creates a new collection (such as a collection of pages) at the location specified by the request-Uniform Resource Identifier (URI).</summary>
			// Token: 0x040017B5 RID: 6069
			public const string MkCol = "MKCOL";

			/// <summary>Represents an HTTP POST protocol method that is used to post a new entity as an addition to a URI.</summary>
			// Token: 0x040017B6 RID: 6070
			public const string Post = "POST";

			/// <summary>Represents an HTTP PUT protocol method that is used to replace an entity identified by a URI.</summary>
			// Token: 0x040017B7 RID: 6071
			public const string Put = "PUT";
		}
	}
}
