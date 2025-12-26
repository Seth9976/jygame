using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Represents a Windows menu or toolbar command item.</summary>
	// Token: 0x02000129 RID: 297
	[ComVisible(true)]
	public class MenuCommand
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.MenuCommand" /> class.</summary>
		/// <param name="handler">The event to raise when the user selects the menu item or toolbar button. </param>
		/// <param name="command">The unique command ID that links this menu command to the environment's menu. </param>
		// Token: 0x06000B49 RID: 2889 RVA: 0x00009E58 File Offset: 0x00008058
		public MenuCommand(EventHandler handler, CommandID command)
		{
			this.handler = handler;
			this.command = command;
		}

		/// <summary>Occurs when the menu command changes.</summary>
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x06000B4A RID: 2890 RVA: 0x00009E83 File Offset: 0x00008083
		// (remove) Token: 0x06000B4B RID: 2891 RVA: 0x00009E9C File Offset: 0x0000809C
		public event EventHandler CommandChanged;

		/// <summary>Gets or sets a value indicating whether this menu item is checked.</summary>
		/// <returns>true if the item is checked; otherwise, false.</returns>
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x00009EB5 File Offset: 0x000080B5
		// (set) Token: 0x06000B4D RID: 2893 RVA: 0x00009EBD File Offset: 0x000080BD
		public virtual bool Checked
		{
			get
			{
				return this.ischecked;
			}
			set
			{
				if (this.ischecked != value)
				{
					this.ischecked = value;
					this.OnCommandChanged(EventArgs.Empty);
				}
			}
		}

		/// <summary>Gets the <see cref="T:System.ComponentModel.Design.CommandID" /> associated with this menu command.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.CommandID" /> associated with the menu command.</returns>
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00009EDD File Offset: 0x000080DD
		public virtual CommandID CommandID
		{
			get
			{
				return this.command;
			}
		}

		/// <summary>Gets a value indicating whether this menu item is available.</summary>
		/// <returns>true if the item is enabled; otherwise, false.</returns>
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x00009EE5 File Offset: 0x000080E5
		// (set) Token: 0x06000B50 RID: 2896 RVA: 0x00009EED File Offset: 0x000080ED
		public virtual bool Enabled
		{
			get
			{
				return this.enabled;
			}
			set
			{
				if (this.enabled != value)
				{
					this.enabled = value;
					this.OnCommandChanged(EventArgs.Empty);
				}
			}
		}

		/// <summary>Gets the OLE command status code for this menu item.</summary>
		/// <returns>An integer containing a mixture of status flags that reflect the state of this menu item.</returns>
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B51 RID: 2897 RVA: 0x00009F0D File Offset: 0x0000810D
		[global::System.MonoTODO]
		public virtual int OleStatus
		{
			get
			{
				return 3;
			}
		}

		/// <summary>Gets the public properties associated with the <see cref="T:System.ComponentModel.Design.MenuCommand" />.</summary>
		/// <returns>An <see cref="T:System.Collections.IDictionary" /> containing the public properties of the <see cref="T:System.ComponentModel.Design.MenuCommand" />. </returns>
		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00009F10 File Offset: 0x00008110
		public virtual IDictionary Properties
		{
			get
			{
				if (this.properties == null)
				{
					this.properties = new Hashtable();
				}
				return this.properties;
			}
		}

		/// <summary>Gets or sets a value indicating whether this menu item is supported.</summary>
		/// <returns>true if the item is supported, which is the default; otherwise, false.</returns>
		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x00009F2E File Offset: 0x0000812E
		// (set) Token: 0x06000B54 RID: 2900 RVA: 0x00009F36 File Offset: 0x00008136
		public virtual bool Supported
		{
			get
			{
				return this.issupported;
			}
			set
			{
				this.issupported = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether this menu item is visible.</summary>
		/// <returns>true if the item is visible; otherwise, false.</returns>
		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x00009F3F File Offset: 0x0000813F
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x00009F47 File Offset: 0x00008147
		public virtual bool Visible
		{
			get
			{
				return this.visible;
			}
			set
			{
				this.visible = value;
			}
		}

		/// <summary>Invokes the command.</summary>
		// Token: 0x06000B57 RID: 2903 RVA: 0x00009F50 File Offset: 0x00008150
		public virtual void Invoke()
		{
			if (this.handler != null)
			{
				this.handler(this, EventArgs.Empty);
			}
		}

		/// <summary>Invokes the command with the given parameter.</summary>
		/// <param name="arg">An optional argument for use by the command.</param>
		// Token: 0x06000B58 RID: 2904 RVA: 0x00009F6E File Offset: 0x0000816E
		public virtual void Invoke(object arg)
		{
			this.Invoke();
		}

		/// <summary>Raises the <see cref="E:System.ComponentModel.Design.MenuCommand.CommandChanged" /> event.</summary>
		/// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data. </param>
		// Token: 0x06000B59 RID: 2905 RVA: 0x00009F76 File Offset: 0x00008176
		protected virtual void OnCommandChanged(EventArgs e)
		{
			if (this.CommandChanged != null)
			{
				this.CommandChanged(this, e);
			}
		}

		/// <summary>Returns a string representation of this menu command.</summary>
		/// <returns>A string containing the value of the <see cref="P:System.ComponentModel.Design.MenuCommand.CommandID" /> property appended with the names of any flags that are set, separated by pipe bars (|). These flag properties include <see cref="P:System.ComponentModel.Design.MenuCommand.Checked" />, <see cref="P:System.ComponentModel.Design.MenuCommand.Enabled" />, <see cref="P:System.ComponentModel.Design.MenuCommand.Supported" />, and <see cref="P:System.ComponentModel.Design.MenuCommand.Visible" />.</returns>
		// Token: 0x06000B5A RID: 2906 RVA: 0x000307B0 File Offset: 0x0002E9B0
		public override string ToString()
		{
			string text = string.Empty;
			if (this.command != null)
			{
				text = this.command.ToString();
			}
			text += " : ";
			if (this.Supported)
			{
				text += "Supported";
			}
			if (this.Enabled)
			{
				text += "|Enabled";
			}
			if (this.Visible)
			{
				text += "|Visible";
			}
			if (this.Checked)
			{
				text += "|Checked";
			}
			return text;
		}

		// Token: 0x040002F6 RID: 758
		private EventHandler handler;

		// Token: 0x040002F7 RID: 759
		private CommandID command;

		// Token: 0x040002F8 RID: 760
		private bool ischecked;

		// Token: 0x040002F9 RID: 761
		private bool enabled = true;

		// Token: 0x040002FA RID: 762
		private bool issupported = true;

		// Token: 0x040002FB RID: 763
		private bool visible = true;

		// Token: 0x040002FC RID: 764
		private Hashtable properties;
	}
}
