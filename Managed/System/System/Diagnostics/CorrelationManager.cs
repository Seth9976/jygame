using System;
using System.Collections;

namespace System.Diagnostics
{
	/// <summary>Correlates traces that are part of a logical transaction.</summary>
	/// <filterpriority>2</filterpriority>
	// Token: 0x02000214 RID: 532
	public class CorrelationManager
	{
		// Token: 0x060011B3 RID: 4531 RVA: 0x0000E480 File Offset: 0x0000C680
		internal CorrelationManager()
		{
		}

		/// <summary>Gets or sets the identity for a global activity.</summary>
		/// <returns>A <see cref="T:System.Guid" /> structure that identifies the global activity.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0000E493 File Offset: 0x0000C693
		// (set) Token: 0x060011B5 RID: 4533 RVA: 0x0000E49B File Offset: 0x0000C69B
		public Guid ActivityId
		{
			get
			{
				return this.activity;
			}
			set
			{
				this.activity = value;
			}
		}

		/// <summary>Gets the logical operation stack from the call context.</summary>
		/// <returns>A <see cref="T:System.Collections.Stack" /> object that represents the logical operation stack for the call context.</returns>
		/// <filterpriority>1</filterpriority>
		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
		public Stack LogicalOperationStack
		{
			get
			{
				return this.op_stack;
			}
		}

		/// <summary>Starts a logical operation on a thread.</summary>
		/// <filterpriority>1</filterpriority>
		// Token: 0x060011B7 RID: 4535 RVA: 0x0000E4AC File Offset: 0x0000C6AC
		public void StartLogicalOperation()
		{
			this.StartLogicalOperation(Guid.NewGuid());
		}

		/// <summary>Starts a logical operation with the specified identity on a thread.</summary>
		/// <param name="operationId">An object identifying the operation.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="operationId" /> parameter is null. </exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x060011B8 RID: 4536 RVA: 0x0000E4BE File Offset: 0x0000C6BE
		public void StartLogicalOperation(object operationId)
		{
			this.op_stack.Push(operationId);
		}

		/// <summary>Stops the current logical operation.</summary>
		/// <exception cref="T:System.InvalidOperationException">The <see cref="P:System.Diagnostics.CorrelationManager.LogicalOperationStack" /> property is an empty stack.</exception>
		/// <filterpriority>1</filterpriority>
		// Token: 0x060011B9 RID: 4537 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		public void StopLogicalOperation()
		{
			this.op_stack.Pop();
		}

		// Token: 0x0400051B RID: 1307
		private Guid activity;

		// Token: 0x0400051C RID: 1308
		private Stack op_stack = new Stack();
	}
}
