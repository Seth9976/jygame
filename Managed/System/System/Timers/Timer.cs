using System;
using System.ComponentModel;
using System.Threading;

namespace System.Timers
{
	/// <summary>Generates recurring events in an application.</summary>
	// Token: 0x020004CC RID: 1228
	[global::System.ComponentModel.DefaultEvent("Elapsed")]
	[global::System.ComponentModel.DefaultProperty("Interval")]
	public class Timer : global::System.ComponentModel.Component, global::System.ComponentModel.ISupportInitialize
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.Timers.Timer" /> class, and sets all the properties to their initial values.</summary>
		// Token: 0x06002B79 RID: 11129 RVA: 0x0001E390 File Offset: 0x0001C590
		public Timer()
			: this(100.0)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Timers.Timer" /> class, and sets the <see cref="P:System.Timers.Timer.Interval" /> property to the specified number of milliseconds.</summary>
		/// <param name="interval">The time, in milliseconds, between events. The value must be greater than zero and less than or equal to <see cref="F:System.Int32.MaxValue" />.</param>
		/// <exception cref="T:System.ArgumentException">The value of the <paramref name="interval" /> parameter is less than or equal to zero, or greater than <see cref="F:System.Int32.MaxValue" />. </exception>
		// Token: 0x06002B7A RID: 11130 RVA: 0x0008BE78 File Offset: 0x0008A078
		public Timer(double interval)
		{
			if (interval > 2147483647.0)
			{
				throw new ArgumentException("Invalid value: " + interval, "interval");
			}
			this.autoReset = true;
			this.Interval = interval;
		}

		/// <summary>Occurs when the interval elapses.</summary>
		// Token: 0x1400005E RID: 94
		// (add) Token: 0x06002B7B RID: 11131 RVA: 0x0001E3A1 File Offset: 0x0001C5A1
		// (remove) Token: 0x06002B7C RID: 11132 RVA: 0x0001E3BA File Offset: 0x0001C5BA
		[global::System.ComponentModel.Category("Behavior")]
		[TimersDescription("Occurs when the Interval has elapsed.")]
		public event ElapsedEventHandler Elapsed;

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Timers.Timer" /> should raise the <see cref="E:System.Timers.Timer.Elapsed" /> event each time the specified interval elapses or only after the first time it elapses.</summary>
		/// <returns>true if the <see cref="T:System.Timers.Timer" /> should raise the <see cref="E:System.Timers.Timer.Elapsed" /> event each time the interval elapses; false if it should raise the <see cref="E:System.Timers.Timer.Elapsed" /> event only once, after the first time the interval elapses. The default is true.</returns>
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06002B7D RID: 11133 RVA: 0x0001E3D3 File Offset: 0x0001C5D3
		// (set) Token: 0x06002B7E RID: 11134 RVA: 0x0001E3DB File Offset: 0x0001C5DB
		[TimersDescription("Indicates whether the timer will be restarted when it is enabled.")]
		[global::System.ComponentModel.DefaultValue(true)]
		[global::System.ComponentModel.Category("Behavior")]
		public bool AutoReset
		{
			get
			{
				return this.autoReset;
			}
			set
			{
				this.autoReset = value;
			}
		}

		/// <summary>Gets or sets a value indicating whether the <see cref="T:System.Timers.Timer" /> should raise the <see cref="E:System.Timers.Timer.Elapsed" /> event.</summary>
		/// <returns>true if the <see cref="T:System.Timers.Timer" /> should raise the <see cref="E:System.Timers.Timer.Elapsed" /> event; otherwise, false. The default is false.</returns>
		/// <exception cref="T:System.ObjectDisposedException">This property cannot be set because the timer has been disposed.</exception>
		/// <exception cref="T:System.ArgumentException">The <see cref="P:System.Timers.Timer.Interval" /> property was set to a value greater than <see cref="F:System.Int32.MaxValue" /> before the timer was enabled.  </exception>
		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06002B7F RID: 11135 RVA: 0x0008BED0 File Offset: 0x0008A0D0
		// (set) Token: 0x06002B80 RID: 11136 RVA: 0x0008BF1C File Offset: 0x0008A11C
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Behavior")]
		[TimersDescription("Indicates whether the timer is enabled to fire events at a defined interval.")]
		public bool Enabled
		{
			get
			{
				object @lock = this._lock;
				bool flag;
				lock (@lock)
				{
					flag = this.timer != null;
				}
				return flag;
			}
			set
			{
				object @lock = this._lock;
				lock (@lock)
				{
					bool flag = this.timer != null;
					if (flag != value)
					{
						if (value)
						{
							this.timer = new Timer(new TimerCallback(Timer.Callback), this, (int)this.interval, (!this.autoReset) ? 0 : ((int)this.interval));
						}
						else
						{
							this.timer.Dispose();
							this.timer = null;
						}
					}
				}
			}
		}

		/// <summary>Gets or sets the interval at which to raise the <see cref="E:System.Timers.Timer.Elapsed" /> event.</summary>
		/// <returns>The time, in milliseconds, between <see cref="E:System.Timers.Timer.Elapsed" /> events. The value must be greater than zero, and less than or equal to <see cref="F:System.Int32.MaxValue" />. The default is 100 milliseconds.</returns>
		/// <exception cref="T:System.ArgumentException">The interval is less than or equal to zero.-or-The interval is greater than <see cref="F:System.Int32.MaxValue" />, and the timer is currently enabled. (If the timer is not currently enabled, no exception is thrown until it becomes enabled.)  </exception>
		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06002B81 RID: 11137 RVA: 0x0001E3E4 File Offset: 0x0001C5E4
		// (set) Token: 0x06002B82 RID: 11138 RVA: 0x0008BFC0 File Offset: 0x0008A1C0
		[global::System.ComponentModel.RecommendedAsConfigurable(true)]
		[global::System.ComponentModel.DefaultValue(100)]
		[TimersDescription("The number of milliseconds between timer events.")]
		[global::System.ComponentModel.Category("Behavior")]
		public double Interval
		{
			get
			{
				return this.interval;
			}
			set
			{
				if (value <= 0.0)
				{
					throw new ArgumentException("Invalid value: " + value);
				}
				object @lock = this._lock;
				lock (@lock)
				{
					this.interval = value;
					if (this.timer != null)
					{
						this.timer.Change((int)this.interval, (!this.autoReset) ? 0 : ((int)this.interval));
					}
				}
			}
		}

		/// <summary>Gets or sets the site that binds the <see cref="T:System.Timers.Timer" /> to its container in design mode.</summary>
		/// <returns>An <see cref="T:System.ComponentModel.ISite" /> interface representing the site that binds the <see cref="T:System.Timers.Timer" /> object to its container.</returns>
		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000113EC File Offset: 0x0000F5EC
		// (set) Token: 0x06002B84 RID: 11140 RVA: 0x000113F4 File Offset: 0x0000F5F4
		public override global::System.ComponentModel.ISite Site
		{
			get
			{
				return base.Site;
			}
			set
			{
				base.Site = value;
			}
		}

		/// <summary>Gets or sets the object used to marshal event-handler calls that are issued when an interval has elapsed.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.ISynchronizeInvoke" /> representing the object used to marshal the event-handler calls that are issued when an interval has elapsed. The default is null.</returns>
		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x0001E3EC File Offset: 0x0001C5EC
		// (set) Token: 0x06002B86 RID: 11142 RVA: 0x0001E3F4 File Offset: 0x0001C5F4
		[TimersDescription("The object used to marshal the event handler calls issued when an interval has elapsed.")]
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.ComponentModel.ISynchronizeInvoke SynchronizingObject
		{
			get
			{
				return this.so;
			}
			set
			{
				this.so = value;
			}
		}

		/// <summary>Begins the run-time initialization of a <see cref="T:System.Timers.Timer" /> that is used on a form or by another component.</summary>
		// Token: 0x06002B87 RID: 11143 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void BeginInit()
		{
		}

		/// <summary>Releases the resources used by the <see cref="T:System.Timers.Timer" />.</summary>
		// Token: 0x06002B88 RID: 11144 RVA: 0x0001E3FD File Offset: 0x0001C5FD
		public void Close()
		{
			this.Enabled = false;
		}

		/// <summary>Ends the run-time initialization of a <see cref="T:System.Timers.Timer" /> that is used on a form or by another component.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x06002B89 RID: 11145 RVA: 0x000029F5 File Offset: 0x00000BF5
		public void EndInit()
		{
		}

		/// <summary>Starts raising the <see cref="E:System.Timers.Timer.Elapsed" /> event by setting <see cref="P:System.Timers.Timer.Enabled" /> to true.</summary>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <see cref="T:System.Timers.Timer" /> is created with an interval equal to or greater than <see cref="F:System.Int32.MaxValue" /> + 1, or set to an interval less than zero.</exception>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x06002B8A RID: 11146 RVA: 0x0001E406 File Offset: 0x0001C606
		public void Start()
		{
			this.Enabled = true;
		}

		/// <summary>Stops raising the <see cref="E:System.Timers.Timer.Elapsed" /> event by setting <see cref="P:System.Timers.Timer.Enabled" /> to false.</summary>
		/// <PermissionSet>
		///   <IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode" />
		/// </PermissionSet>
		// Token: 0x06002B8B RID: 11147 RVA: 0x0001E3FD File Offset: 0x0001C5FD
		public void Stop()
		{
			this.Enabled = false;
		}

		/// <summary>Releases all resources used by the current <see cref="T:System.Timers.Timer" />.</summary>
		/// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources. </param>
		// Token: 0x06002B8C RID: 11148 RVA: 0x0001E40F File Offset: 0x0001C60F
		protected override void Dispose(bool disposing)
		{
			this.Close();
			base.Dispose(disposing);
		}

		// Token: 0x06002B8D RID: 11149 RVA: 0x0008C058 File Offset: 0x0008A258
		private static void Callback(object state)
		{
			Timer timer = (Timer)state;
			if (!timer.Enabled)
			{
				return;
			}
			ElapsedEventHandler elapsed = timer.Elapsed;
			if (!timer.autoReset)
			{
				timer.Enabled = false;
			}
			if (elapsed == null)
			{
				return;
			}
			ElapsedEventArgs elapsedEventArgs = new ElapsedEventArgs(DateTime.Now);
			if (timer.so != null && timer.so.InvokeRequired)
			{
				timer.so.BeginInvoke(elapsed, new object[] { timer, elapsedEventArgs });
			}
			else
			{
				try
				{
					elapsed(timer, elapsedEventArgs);
				}
				catch
				{
				}
			}
		}

		// Token: 0x04001B42 RID: 6978
		private double interval;

		// Token: 0x04001B43 RID: 6979
		private bool autoReset;

		// Token: 0x04001B44 RID: 6980
		private Timer timer;

		// Token: 0x04001B45 RID: 6981
		private object _lock = new object();

		// Token: 0x04001B46 RID: 6982
		private global::System.ComponentModel.ISynchronizeInvoke so;
	}
}
