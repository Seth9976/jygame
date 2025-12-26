using System;
using System.Collections;

namespace System.Diagnostics
{
	// Token: 0x02000264 RID: 612
	internal class TraceImpl
	{
		// Token: 0x06001558 RID: 5464 RVA: 0x000021C3 File Offset: 0x000003C3
		private TraceImpl()
		{
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x00010706 File Offset: 0x0000E906
		// (set) Token: 0x0600155B RID: 5467 RVA: 0x00010712 File Offset: 0x0000E912
		public static bool AutoFlush
		{
			get
			{
				TraceImpl.InitOnce();
				return TraceImpl.autoFlush;
			}
			set
			{
				TraceImpl.InitOnce();
				TraceImpl.autoFlush = value;
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0001071F File Offset: 0x0000E91F
		// (set) Token: 0x0600155D RID: 5469 RVA: 0x000422C8 File Offset: 0x000404C8
		public static int IndentLevel
		{
			get
			{
				TraceImpl.InitOnce();
				return TraceImpl.indentLevel;
			}
			set
			{
				object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
				lock (listenersSyncRoot)
				{
					TraceImpl.indentLevel = value;
					foreach (object obj in TraceImpl.Listeners)
					{
						TraceListener traceListener = (TraceListener)obj;
						traceListener.IndentLevel = TraceImpl.indentLevel;
					}
				}
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0001072B File Offset: 0x0000E92B
		// (set) Token: 0x0600155F RID: 5471 RVA: 0x00042358 File Offset: 0x00040558
		public static int IndentSize
		{
			get
			{
				TraceImpl.InitOnce();
				return TraceImpl.indentSize;
			}
			set
			{
				object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
				lock (listenersSyncRoot)
				{
					TraceImpl.indentSize = value;
					foreach (object obj in TraceImpl.Listeners)
					{
						TraceListener traceListener = (TraceListener)obj;
						traceListener.IndentSize = TraceImpl.indentSize;
					}
				}
			}
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001560 RID: 5472 RVA: 0x00010737 File Offset: 0x0000E937
		public static TraceListenerCollection Listeners
		{
			get
			{
				TraceImpl.InitOnce();
				return TraceImpl.listeners;
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00010743 File Offset: 0x0000E943
		private static object ListenersSyncRoot
		{
			get
			{
				return ((ICollection)TraceImpl.Listeners).SyncRoot;
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0001074F File Offset: 0x0000E94F
		public static CorrelationManager CorrelationManager
		{
			get
			{
				TraceImpl.InitOnce();
				return TraceImpl.correlation_manager;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x0001075B File Offset: 0x0000E95B
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x00010767 File Offset: 0x0000E967
		[global::System.MonoLimitation("the property exists but it does nothing.")]
		public static bool UseGlobalLock
		{
			get
			{
				TraceImpl.InitOnce();
				return TraceImpl.use_global_lock;
			}
			set
			{
				TraceImpl.InitOnce();
				TraceImpl.use_global_lock = value;
			}
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x000423E8 File Offset: 0x000405E8
		private static void InitOnce()
		{
			if (TraceImpl.initLock != null)
			{
				object obj = TraceImpl.initLock;
				lock (obj)
				{
					if (TraceImpl.listeners == null)
					{
						IDictionary settings = DiagnosticsConfiguration.Settings;
						TraceImplSettings traceImplSettings = (TraceImplSettings)settings[".__TraceInfoSettingsKey__."];
						settings.Remove(".__TraceInfoSettingsKey__.");
						TraceImpl.autoFlush = traceImplSettings.AutoFlush;
						TraceImpl.indentLevel = traceImplSettings.IndentLevel;
						TraceImpl.indentSize = traceImplSettings.IndentSize;
						TraceImpl.listeners = traceImplSettings.Listeners;
					}
				}
				TraceImpl.initLock = null;
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x00010774 File Offset: 0x0000E974
		[global::System.MonoTODO]
		public static void Assert(bool condition)
		{
			if (!condition)
			{
				TraceImpl.Fail(new StackTrace(true).ToString());
			}
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x0001078C File Offset: 0x0000E98C
		[global::System.MonoTODO]
		public static void Assert(bool condition, string message)
		{
			if (!condition)
			{
				TraceImpl.Fail(message);
			}
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x0001079A File Offset: 0x0000E99A
		[global::System.MonoTODO]
		public static void Assert(bool condition, string message, string detailMessage)
		{
			if (!condition)
			{
				TraceImpl.Fail(message, detailMessage);
			}
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00042488 File Offset: 0x00040688
		public static void Close()
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Close();
				}
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00042510 File Offset: 0x00040710
		[global::System.MonoTODO]
		public static void Fail(string message)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Fail(message);
				}
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x00042598 File Offset: 0x00040798
		[global::System.MonoTODO]
		public static void Fail(string message, string detailMessage)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Fail(message, detailMessage);
				}
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00042620 File Offset: 0x00040820
		public static void Flush()
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Flush();
				}
			}
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x000107A9 File Offset: 0x0000E9A9
		public static void Indent()
		{
			TraceImpl.IndentLevel++;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000107B7 File Offset: 0x0000E9B7
		public static void Unindent()
		{
			TraceImpl.IndentLevel--;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000426A8 File Offset: 0x000408A8
		public static void Write(object value)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Write(value);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00042740 File Offset: 0x00040940
		public static void Write(string message)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Write(message);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000427D8 File Offset: 0x000409D8
		public static void Write(object value, string category)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Write(value, category);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00042870 File Offset: 0x00040A70
		public static void Write(string message, string category)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.Write(message, category);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x000107C5 File Offset: 0x0000E9C5
		public static void WriteIf(bool condition, object value)
		{
			if (condition)
			{
				TraceImpl.Write(value);
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x000107D3 File Offset: 0x0000E9D3
		public static void WriteIf(bool condition, string message)
		{
			if (condition)
			{
				TraceImpl.Write(message);
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x000107E1 File Offset: 0x0000E9E1
		public static void WriteIf(bool condition, object value, string category)
		{
			if (condition)
			{
				TraceImpl.Write(value, category);
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x000107F0 File Offset: 0x0000E9F0
		public static void WriteIf(bool condition, string message, string category)
		{
			if (condition)
			{
				TraceImpl.Write(message, category);
			}
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00042908 File Offset: 0x00040B08
		public static void WriteLine(object value)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.WriteLine(value);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000429A0 File Offset: 0x00040BA0
		public static void WriteLine(string message)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.WriteLine(message);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00042A38 File Offset: 0x00040C38
		public static void WriteLine(object value, string category)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.WriteLine(value, category);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00042AD0 File Offset: 0x00040CD0
		public static void WriteLine(string message, string category)
		{
			object listenersSyncRoot = TraceImpl.ListenersSyncRoot;
			lock (listenersSyncRoot)
			{
				foreach (object obj in TraceImpl.Listeners)
				{
					TraceListener traceListener = (TraceListener)obj;
					traceListener.WriteLine(message, category);
					if (TraceImpl.AutoFlush)
					{
						traceListener.Flush();
					}
				}
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x000107FF File Offset: 0x0000E9FF
		public static void WriteLineIf(bool condition, object value)
		{
			if (condition)
			{
				TraceImpl.WriteLine(value);
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x0001080D File Offset: 0x0000EA0D
		public static void WriteLineIf(bool condition, string message)
		{
			if (condition)
			{
				TraceImpl.WriteLine(message);
			}
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x0001081B File Offset: 0x0000EA1B
		public static void WriteLineIf(bool condition, object value, string category)
		{
			if (condition)
			{
				TraceImpl.WriteLine(value, category);
			}
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0001082A File Offset: 0x0000EA2A
		public static void WriteLineIf(bool condition, string message, string category)
		{
			if (condition)
			{
				TraceImpl.WriteLine(message, category);
			}
		}

		// Token: 0x040006A6 RID: 1702
		private static object initLock = new object();

		// Token: 0x040006A7 RID: 1703
		private static bool autoFlush;

		// Token: 0x040006A8 RID: 1704
		[ThreadStatic]
		private static int indentLevel = 0;

		// Token: 0x040006A9 RID: 1705
		[ThreadStatic]
		private static int indentSize;

		// Token: 0x040006AA RID: 1706
		private static TraceListenerCollection listeners;

		// Token: 0x040006AB RID: 1707
		private static bool use_global_lock;

		// Token: 0x040006AC RID: 1708
		private static CorrelationManager correlation_manager = new CorrelationManager();
	}
}
