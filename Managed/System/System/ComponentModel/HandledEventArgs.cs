using System;

namespace System.ComponentModel
{
	/// <summary>Provides data for events that can be handled completely in an event handler. </summary>
	// Token: 0x02000153 RID: 339
	public class HandledEventArgs : EventArgs
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.HandledEventArgs" /> class with a default <see cref="P:System.ComponentModel.HandledEventArgs.Handled" /> property value of false.</summary>
		// Token: 0x06000C64 RID: 3172 RVA: 0x0000AA4F File Offset: 0x00008C4F
		public HandledEventArgs()
		{
			this.handled = false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.HandledEventArgs" /> class with the specified default value for the <see cref="P:System.ComponentModel.HandledEventArgs.Handled" /> property.</summary>
		/// <param name="defaultHandledValue">The default value for the <see cref="P:System.ComponentModel.HandledEventArgs.Handled" /> property.</param>
		// Token: 0x06000C65 RID: 3173 RVA: 0x0000AA5E File Offset: 0x00008C5E
		public HandledEventArgs(bool defaultHandledValue)
		{
			this.handled = defaultHandledValue;
		}

		/// <summary>Gets or sets a value that indicates whether the event handler has completely handled the event or whether the system should continue its own processing.</summary>
		/// <returns>true if the event has been completely handled; otherwise, false.</returns>
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x0000AA6D File Offset: 0x00008C6D
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x0000AA75 File Offset: 0x00008C75
		public bool Handled
		{
			get
			{
				return this.handled;
			}
			set
			{
				this.handled = value;
			}
		}

		// Token: 0x04000384 RID: 900
		private bool handled;
	}
}
