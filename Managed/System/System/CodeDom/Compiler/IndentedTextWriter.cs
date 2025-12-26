using System;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace System.CodeDom.Compiler
{
	/// <summary>Provides a text writer that can indent new lines by a tab string token.</summary>
	// Token: 0x0200008D RID: 141
	[PermissionSet((SecurityAction)14, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	[PermissionSet((SecurityAction)15, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\nversion=\"1\"\nUnrestricted=\"true\"/>\n")]
	public class IndentedTextWriter : TextWriter
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.Compiler.IndentedTextWriter" /> class using the specified text writer and default tab string.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to use for output. </param>
		// Token: 0x060005B4 RID: 1460 RVA: 0x00005E0F File Offset: 0x0000400F
		public IndentedTextWriter(TextWriter writer)
		{
			this.writer = writer;
			this.tabString = "    ";
			this.newline = true;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.CodeDom.Compiler.IndentedTextWriter" /> class using the specified text writer and tab string.</summary>
		/// <param name="writer">The <see cref="T:System.IO.TextWriter" /> to use for output. </param>
		/// <param name="tabString">The tab string to use for indentation. </param>
		// Token: 0x060005B5 RID: 1461 RVA: 0x00005E30 File Offset: 0x00004030
		public IndentedTextWriter(TextWriter writer, string tabString)
		{
			this.writer = writer;
			this.tabString = tabString;
			this.newline = true;
		}

		/// <summary>Gets the encoding for the text writer to use.</summary>
		/// <returns>An <see cref="T:System.Text.Encoding" /> that indicates the encoding for the text writer to use.</returns>
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00005E4D File Offset: 0x0000404D
		public override Encoding Encoding
		{
			get
			{
				return this.writer.Encoding;
			}
		}

		/// <summary>Gets or sets the number of spaces to indent.</summary>
		/// <returns>The number of spaces to indent.</returns>
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x00005E5A File Offset: 0x0000405A
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00005E62 File Offset: 0x00004062
		public int Indent
		{
			get
			{
				return this.indent;
			}
			set
			{
				if (value < 0)
				{
					value = 0;
				}
				this.indent = value;
			}
		}

		/// <summary>Gets the <see cref="T:System.IO.TextWriter" /> to use.</summary>
		/// <returns>The <see cref="T:System.IO.TextWriter" /> to use.</returns>
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00005E75 File Offset: 0x00004075
		public TextWriter InnerWriter
		{
			get
			{
				return this.writer;
			}
		}

		/// <summary>Gets or sets the new line character to use.</summary>
		/// <returns>The new line character to use.</returns>
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060005BA RID: 1466 RVA: 0x00005E7D File Offset: 0x0000407D
		// (set) Token: 0x060005BB RID: 1467 RVA: 0x00005E8A File Offset: 0x0000408A
		public override string NewLine
		{
			get
			{
				return this.writer.NewLine;
			}
			set
			{
				this.writer.NewLine = value;
			}
		}

		/// <summary>Closes the document being written to.</summary>
		// Token: 0x060005BC RID: 1468 RVA: 0x00005E98 File Offset: 0x00004098
		public override void Close()
		{
			this.writer.Close();
		}

		/// <summary>Flushes the stream.</summary>
		// Token: 0x060005BD RID: 1469 RVA: 0x00005EA5 File Offset: 0x000040A5
		public override void Flush()
		{
			this.writer.Flush();
		}

		/// <summary>Writes the text representation of a Boolean value to the text stream.</summary>
		/// <param name="value">The Boolean value to write. </param>
		// Token: 0x060005BE RID: 1470 RVA: 0x00005EB2 File Offset: 0x000040B2
		public override void Write(bool value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes a character to the text stream.</summary>
		/// <param name="value">The character to write. </param>
		// Token: 0x060005BF RID: 1471 RVA: 0x00005EC6 File Offset: 0x000040C6
		public override void Write(char value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes a character array to the text stream.</summary>
		/// <param name="buffer">The character array to write. </param>
		// Token: 0x060005C0 RID: 1472 RVA: 0x00005EDA File Offset: 0x000040DA
		public override void Write(char[] value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes the text representation of a Double to the text stream.</summary>
		/// <param name="value">The double to write. </param>
		// Token: 0x060005C1 RID: 1473 RVA: 0x00005EEE File Offset: 0x000040EE
		public override void Write(double value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes the text representation of an integer to the text stream.</summary>
		/// <param name="value">The integer to write. </param>
		// Token: 0x060005C2 RID: 1474 RVA: 0x00005F02 File Offset: 0x00004102
		public override void Write(int value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes the text representation of an 8-byte integer to the text stream.</summary>
		/// <param name="value">The 8-byte integer to write. </param>
		// Token: 0x060005C3 RID: 1475 RVA: 0x00005F16 File Offset: 0x00004116
		public override void Write(long value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes the text representation of an object to the text stream.</summary>
		/// <param name="value">The object to write. </param>
		// Token: 0x060005C4 RID: 1476 RVA: 0x00005F2A File Offset: 0x0000412A
		public override void Write(object value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes the text representation of a Single to the text stream.</summary>
		/// <param name="value">The single to write. </param>
		// Token: 0x060005C5 RID: 1477 RVA: 0x00005F3E File Offset: 0x0000413E
		public override void Write(float value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes the specified string to the text stream.</summary>
		/// <param name="s">The string to write. </param>
		// Token: 0x060005C6 RID: 1478 RVA: 0x00005F52 File Offset: 0x00004152
		public override void Write(string value)
		{
			this.OutputTabs();
			this.writer.Write(value);
		}

		/// <summary>Writes out a formatted string, using the same semantics as specified.</summary>
		/// <param name="format">The formatting string. </param>
		/// <param name="arg0">The object to write into the formatted string. </param>
		// Token: 0x060005C7 RID: 1479 RVA: 0x00005F66 File Offset: 0x00004166
		public override void Write(string format, object arg)
		{
			this.OutputTabs();
			this.writer.Write(format, arg);
		}

		/// <summary>Writes out a formatted string, using the same semantics as specified.</summary>
		/// <param name="format">The formatting string to use. </param>
		/// <param name="arg">The argument array to output. </param>
		// Token: 0x060005C8 RID: 1480 RVA: 0x00005F7B File Offset: 0x0000417B
		public override void Write(string format, params object[] args)
		{
			this.OutputTabs();
			this.writer.Write(format, args);
		}

		/// <summary>Writes a subarray of characters to the text stream.</summary>
		/// <param name="buffer">The character array to write data from. </param>
		/// <param name="index">Starting index in the buffer. </param>
		/// <param name="count">The number of characters to write. </param>
		// Token: 0x060005C9 RID: 1481 RVA: 0x00005F90 File Offset: 0x00004190
		public override void Write(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this.writer.Write(buffer, index, count);
		}

		/// <summary>Writes out a formatted string, using the same semantics as specified.</summary>
		/// <param name="format">The formatting string to use. </param>
		/// <param name="arg0">The first object to write into the formatted string. </param>
		/// <param name="arg1">The second object to write into the formatted string. </param>
		// Token: 0x060005CA RID: 1482 RVA: 0x00005FA6 File Offset: 0x000041A6
		public override void Write(string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this.writer.Write(format, arg0, arg1);
		}

		/// <summary>Writes a line terminator.</summary>
		// Token: 0x060005CB RID: 1483 RVA: 0x00005FBC File Offset: 0x000041BC
		public override void WriteLine()
		{
			this.OutputTabs();
			this.writer.WriteLine();
			this.newline = true;
		}

		/// <summary>Writes the text representation of a Boolean, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">The Boolean to write. </param>
		// Token: 0x060005CC RID: 1484 RVA: 0x00005FD6 File Offset: 0x000041D6
		public override void WriteLine(bool value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes a character, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">The character to write. </param>
		// Token: 0x060005CD RID: 1485 RVA: 0x00005FF1 File Offset: 0x000041F1
		public override void WriteLine(char value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes a character array, followed by a line terminator, to the text stream.</summary>
		/// <param name="buffer">The character array to write. </param>
		// Token: 0x060005CE RID: 1486 RVA: 0x0000600C File Offset: 0x0000420C
		public override void WriteLine(char[] value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes the text representation of a Double, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">The double to write. </param>
		// Token: 0x060005CF RID: 1487 RVA: 0x00006027 File Offset: 0x00004227
		public override void WriteLine(double value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes the text representation of an integer, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">The integer to write. </param>
		// Token: 0x060005D0 RID: 1488 RVA: 0x00006042 File Offset: 0x00004242
		public override void WriteLine(int value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes the text representation of an 8-byte integer, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">The 8-byte integer to write. </param>
		// Token: 0x060005D1 RID: 1489 RVA: 0x0000605D File Offset: 0x0000425D
		public override void WriteLine(long value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes the text representation of an object, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">The object to write. </param>
		// Token: 0x060005D2 RID: 1490 RVA: 0x00006078 File Offset: 0x00004278
		public override void WriteLine(object value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes the text representation of a Single, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">The single to write. </param>
		// Token: 0x060005D3 RID: 1491 RVA: 0x00006093 File Offset: 0x00004293
		public override void WriteLine(float value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes the specified string, followed by a line terminator, to the text stream.</summary>
		/// <param name="s">The string to write. </param>
		// Token: 0x060005D4 RID: 1492 RVA: 0x000060AE File Offset: 0x000042AE
		public override void WriteLine(string value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes the text representation of a UInt32, followed by a line terminator, to the text stream.</summary>
		/// <param name="value">A UInt32 to output. </param>
		// Token: 0x060005D5 RID: 1493 RVA: 0x000060C9 File Offset: 0x000042C9
		[CLSCompliant(false)]
		public override void WriteLine(uint value)
		{
			this.OutputTabs();
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Writes out a formatted string, followed by a line terminator, using the same semantics as specified.</summary>
		/// <param name="format">The formatting string. </param>
		/// <param name="arg0">The object to write into the formatted string. </param>
		// Token: 0x060005D6 RID: 1494 RVA: 0x000060E4 File Offset: 0x000042E4
		public override void WriteLine(string format, object arg)
		{
			this.OutputTabs();
			this.writer.WriteLine(format, arg);
			this.newline = true;
		}

		/// <summary>Writes out a formatted string, followed by a line terminator, using the same semantics as specified.</summary>
		/// <param name="format">The formatting string to use. </param>
		/// <param name="arg">The argument array to output. </param>
		// Token: 0x060005D7 RID: 1495 RVA: 0x00006100 File Offset: 0x00004300
		public override void WriteLine(string format, params object[] args)
		{
			this.OutputTabs();
			this.writer.WriteLine(format, args);
			this.newline = true;
		}

		/// <summary>Writes a subarray of characters, followed by a line terminator, to the text stream.</summary>
		/// <param name="buffer">The character array to write data from. </param>
		/// <param name="index">Starting index in the buffer. </param>
		/// <param name="count">The number of characters to write. </param>
		// Token: 0x060005D8 RID: 1496 RVA: 0x0000611C File Offset: 0x0000431C
		public override void WriteLine(char[] buffer, int index, int count)
		{
			this.OutputTabs();
			this.writer.WriteLine(buffer, index, count);
			this.newline = true;
		}

		/// <summary>Writes out a formatted string, followed by a line terminator, using the same semantics as specified.</summary>
		/// <param name="format">The formatting string to use. </param>
		/// <param name="arg0">The first object to write into the formatted string. </param>
		/// <param name="arg1">The second object to write into the formatted string. </param>
		// Token: 0x060005D9 RID: 1497 RVA: 0x00006139 File Offset: 0x00004339
		public override void WriteLine(string format, object arg0, object arg1)
		{
			this.OutputTabs();
			this.writer.WriteLine(format, arg0, arg1);
			this.newline = true;
		}

		/// <summary>Writes the specified string to a line without tabs.</summary>
		/// <param name="s">The string to write. </param>
		// Token: 0x060005DA RID: 1498 RVA: 0x00006156 File Offset: 0x00004356
		public void WriteLineNoTabs(string value)
		{
			this.writer.WriteLine(value);
			this.newline = true;
		}

		/// <summary>Outputs the tab string once for each level of indentation according to the <see cref="P:System.CodeDom.Compiler.IndentedTextWriter.Indent" /> property.</summary>
		// Token: 0x060005DB RID: 1499 RVA: 0x00029674 File Offset: 0x00027874
		protected virtual void OutputTabs()
		{
			if (this.newline)
			{
				for (int i = 0; i < this.indent; i++)
				{
					this.writer.Write(this.tabString);
				}
				this.newline = false;
			}
		}

		/// <summary>Specifies the default tab string. This field is constant. </summary>
		// Token: 0x0400017E RID: 382
		public const string DefaultTabString = "    ";

		// Token: 0x0400017F RID: 383
		private TextWriter writer;

		// Token: 0x04000180 RID: 384
		private string tabString;

		// Token: 0x04000181 RID: 385
		private int indent;

		// Token: 0x04000182 RID: 386
		private bool newline;
	}
}
