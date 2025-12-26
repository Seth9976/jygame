using System;
using System.Runtime.InteropServices;

namespace System.ComponentModel.Design
{
	/// <summary>Represents a verb that can be invoked from a designer.</summary>
	// Token: 0x02000107 RID: 263
	[ComVisible(true)]
	public class DesignerVerb : MenuCommand
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerVerb" /> class.</summary>
		/// <param name="text">The text of the menu command that is shown to the user. </param>
		/// <param name="handler">The event handler that performs the actions of the verb. </param>
		// Token: 0x06000A93 RID: 2707 RVA: 0x00009B6A File Offset: 0x00007D6A
		public DesignerVerb(string text, EventHandler handler)
			: this(text, handler, StandardCommands.VerbFirst)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.Design.DesignerVerb" /> class.</summary>
		/// <param name="text">The text of the menu command that is shown to the user. </param>
		/// <param name="handler">The event handler that performs the actions of the verb. </param>
		/// <param name="startCommandID">The starting command ID for this verb. By default, the designer architecture sets aside a range of command IDs for verbs. You can override this by providing a custom command ID. </param>
		// Token: 0x06000A94 RID: 2708 RVA: 0x00009B79 File Offset: 0x00007D79
		public DesignerVerb(string text, EventHandler handler, CommandID startCommandID)
			: base(handler, startCommandID)
		{
			this.text = text;
		}

		/// <summary>Gets the text description for the verb command on the menu.</summary>
		/// <returns>A description for the verb command.</returns>
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A95 RID: 2709 RVA: 0x00009B8A File Offset: 0x00007D8A
		public string Text
		{
			get
			{
				return this.text;
			}
		}

		/// <summary>Gets or sets the description of the menu item for the verb.</summary>
		/// <returns>A string describing the menu item. </returns>
		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x00009B92 File Offset: 0x00007D92
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x00009B9A File Offset: 0x00007D9A
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		/// <summary>Overrides <see cref="M:System.Object.ToString" />.</summary>
		/// <returns>The verb's text, or an empty string ("") if the text field is empty.</returns>
		// Token: 0x06000A98 RID: 2712 RVA: 0x00009BA3 File Offset: 0x00007DA3
		public override string ToString()
		{
			return this.text + " : " + base.ToString();
		}

		// Token: 0x040002D8 RID: 728
		private string text;

		// Token: 0x040002D9 RID: 729
		private string description;
	}
}
