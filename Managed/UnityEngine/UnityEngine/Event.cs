using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>A UnityGUI event.</para>
	/// </summary>
	// Token: 0x020001C2 RID: 450
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Event
	{
		// Token: 0x060019E1 RID: 6625 RVA: 0x00009190 File Offset: 0x00007390
		public Event()
		{
			this.Init();
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0000919E File Offset: 0x0000739E
		public Event(Event other)
		{
			if (other == null)
			{
				throw new ArgumentException("Event to copy from is null.");
			}
			this.InitCopy(other);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x000091BE File Offset: 0x000073BE
		private Event(IntPtr ptr)
		{
			this.InitPtr(ptr);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0001C358 File Offset: 0x0001A558
		~Event()
		{
			this.Cleanup();
		}

		/// <summary>
		///   <para>The mouse position.</para>
		/// </summary>
		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x0001C388 File Offset: 0x0001A588
		// (set) Token: 0x060019E6 RID: 6630 RVA: 0x000091CD File Offset: 0x000073CD
		public Vector2 mousePosition
		{
			get
			{
				Vector2 vector;
				this.Internal_GetMousePosition(out vector);
				return vector;
			}
			set
			{
				this.Internal_SetMousePosition(value);
			}
		}

		/// <summary>
		///   <para>The relative movement of the mouse compared to last event.</para>
		/// </summary>
		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x0001C3A0 File Offset: 0x0001A5A0
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x000091D6 File Offset: 0x000073D6
		public Vector2 delta
		{
			get
			{
				Vector2 vector;
				this.Internal_GetMouseDelta(out vector);
				return vector;
			}
			set
			{
				this.Internal_SetMouseDelta(value);
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x000091DF File Offset: 0x000073DF
		// (set) Token: 0x060019EA RID: 6634 RVA: 0x00002753 File Offset: 0x00000953
		[Obsolete("Use HandleUtility.GUIPointToWorldRay(Event.current.mousePosition);", true)]
		public Ray mouseRay
		{
			get
			{
				return new Ray(Vector3.up, Vector3.up);
			}
			set
			{
			}
		}

		/// <summary>
		///   <para>Is Shift held down? (Read Only)</para>
		/// </summary>
		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x000091F0 File Offset: 0x000073F0
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x00009200 File Offset: 0x00007400
		public bool shift
		{
			get
			{
				return (this.modifiers & EventModifiers.Shift) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Shift;
				}
				else
				{
					this.modifiers |= EventModifiers.Shift;
				}
			}
		}

		/// <summary>
		///   <para>Is Control key held down? (Read Only)</para>
		/// </summary>
		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x0000922A File Offset: 0x0000742A
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x0000923A File Offset: 0x0000743A
		public bool control
		{
			get
			{
				return (this.modifiers & EventModifiers.Control) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Control;
				}
				else
				{
					this.modifiers |= EventModifiers.Control;
				}
			}
		}

		/// <summary>
		///   <para>Is Alt/Option key held down? (Read Only)</para>
		/// </summary>
		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x00009264 File Offset: 0x00007464
		// (set) Token: 0x060019F0 RID: 6640 RVA: 0x00009274 File Offset: 0x00007474
		public bool alt
		{
			get
			{
				return (this.modifiers & EventModifiers.Alt) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Alt;
				}
				else
				{
					this.modifiers |= EventModifiers.Alt;
				}
			}
		}

		/// <summary>
		///   <para>Is Command/Windows key held down? (Read Only)</para>
		/// </summary>
		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x0000929E File Offset: 0x0000749E
		// (set) Token: 0x060019F2 RID: 6642 RVA: 0x000092AE File Offset: 0x000074AE
		public bool command
		{
			get
			{
				return (this.modifiers & EventModifiers.Command) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Command;
				}
				else
				{
					this.modifiers |= EventModifiers.Command;
				}
			}
		}

		/// <summary>
		///   <para>Is Caps Lock on? (Read Only)</para>
		/// </summary>
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x000092D8 File Offset: 0x000074D8
		// (set) Token: 0x060019F4 RID: 6644 RVA: 0x000092E9 File Offset: 0x000074E9
		public bool capsLock
		{
			get
			{
				return (this.modifiers & EventModifiers.CapsLock) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.CapsLock;
				}
				else
				{
					this.modifiers |= EventModifiers.CapsLock;
				}
			}
		}

		/// <summary>
		///   <para>Is the current keypress on the numeric keyboard? (Read Only)</para>
		/// </summary>
		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00009314 File Offset: 0x00007514
		// (set) Token: 0x060019F6 RID: 6646 RVA: 0x00009200 File Offset: 0x00007400
		public bool numeric
		{
			get
			{
				return (this.modifiers & EventModifiers.Numeric) != EventModifiers.None;
			}
			set
			{
				if (!value)
				{
					this.modifiers &= ~EventModifiers.Shift;
				}
				else
				{
					this.modifiers |= EventModifiers.Shift;
				}
			}
		}

		/// <summary>
		///   <para>Is the current keypress a function key? (Read Only)</para>
		/// </summary>
		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00009325 File Offset: 0x00007525
		public bool functionKey
		{
			get
			{
				return (this.modifiers & EventModifiers.FunctionKey) != EventModifiers.None;
			}
		}

		/// <summary>
		///   <para>The current event that's being processed right now.</para>
		/// </summary>
		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00009336 File Offset: 0x00007536
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0000933D File Offset: 0x0000753D
		public static Event current
		{
			get
			{
				return Event.s_Current;
			}
			set
			{
				if (value != null)
				{
					Event.s_Current = value;
				}
				else
				{
					Event.s_Current = Event.s_MasterEvent;
				}
				Event.Internal_SetNativeEvent(Event.s_Current.m_Ptr);
			}
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x00009369 File Offset: 0x00007569
		private static void Internal_MakeMasterEventCurrent()
		{
			if (Event.s_MasterEvent == null)
			{
				Event.s_MasterEvent = new Event();
			}
			Event.s_Current = Event.s_MasterEvent;
			Event.Internal_SetNativeEvent(Event.s_MasterEvent.m_Ptr);
		}

		/// <summary>
		///   <para>Is this event a keyboard event? (Read Only)</para>
		/// </summary>
		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x0001C3B8 File Offset: 0x0001A5B8
		public bool isKey
		{
			get
			{
				EventType type = this.type;
				return type == EventType.KeyDown || type == EventType.KeyUp;
			}
		}

		/// <summary>
		///   <para>Is this event a mouse event? (Read Only)</para>
		/// </summary>
		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x0001C3DC File Offset: 0x0001A5DC
		public bool isMouse
		{
			get
			{
				EventType type = this.type;
				return type == EventType.MouseMove || type == EventType.MouseDown || type == EventType.MouseUp || type == EventType.MouseDrag;
			}
		}

		/// <summary>
		///   <para>Create a keyboard event.</para>
		/// </summary>
		/// <param name="key"></param>
		// Token: 0x060019FD RID: 6653 RVA: 0x0001C40C File Offset: 0x0001A60C
		public static Event KeyboardEvent(string key)
		{
			Event @event = new Event();
			@event.type = EventType.KeyDown;
			if (string.IsNullOrEmpty(key))
			{
				return @event;
			}
			int num = 0;
			bool flag;
			do
			{
				flag = true;
				if (num >= key.Length)
				{
					break;
				}
				char c = key[num];
				switch (c)
				{
				case '#':
					@event.modifiers |= EventModifiers.Shift;
					num++;
					break;
				default:
					if (c != '^')
					{
						flag = false;
					}
					else
					{
						@event.modifiers |= EventModifiers.Control;
						num++;
					}
					break;
				case '%':
					@event.modifiers |= EventModifiers.Command;
					num++;
					break;
				case '&':
					@event.modifiers |= EventModifiers.Alt;
					num++;
					break;
				}
			}
			while (flag);
			string text = key.Substring(num, key.Length - num).ToLower();
			string text2 = text;
			switch (text2)
			{
			case "[0]":
				@event.character = '0';
				@event.keyCode = KeyCode.Keypad0;
				return @event;
			case "[1]":
				@event.character = '1';
				@event.keyCode = KeyCode.Keypad1;
				return @event;
			case "[2]":
				@event.character = '2';
				@event.keyCode = KeyCode.Keypad2;
				return @event;
			case "[3]":
				@event.character = '3';
				@event.keyCode = KeyCode.Keypad3;
				return @event;
			case "[4]":
				@event.character = '4';
				@event.keyCode = KeyCode.Keypad4;
				return @event;
			case "[5]":
				@event.character = '5';
				@event.keyCode = KeyCode.Keypad5;
				return @event;
			case "[6]":
				@event.character = '6';
				@event.keyCode = KeyCode.Keypad6;
				return @event;
			case "[7]":
				@event.character = '7';
				@event.keyCode = KeyCode.Keypad7;
				return @event;
			case "[8]":
				@event.character = '8';
				@event.keyCode = KeyCode.Keypad8;
				return @event;
			case "[9]":
				@event.character = '9';
				@event.keyCode = KeyCode.Keypad9;
				return @event;
			case "[.]":
				@event.character = '.';
				@event.keyCode = KeyCode.KeypadPeriod;
				return @event;
			case "[/]":
				@event.character = '/';
				@event.keyCode = KeyCode.KeypadDivide;
				return @event;
			case "[-]":
				@event.character = '-';
				@event.keyCode = KeyCode.KeypadMinus;
				return @event;
			case "[+]":
				@event.character = '+';
				@event.keyCode = KeyCode.KeypadPlus;
				return @event;
			case "[=]":
				@event.character = '=';
				@event.keyCode = KeyCode.KeypadEquals;
				return @event;
			case "[equals]":
				@event.character = '=';
				@event.keyCode = KeyCode.KeypadEquals;
				return @event;
			case "[enter]":
				@event.character = '\n';
				@event.keyCode = KeyCode.KeypadEnter;
				return @event;
			case "up":
				@event.keyCode = KeyCode.UpArrow;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "down":
				@event.keyCode = KeyCode.DownArrow;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "left":
				@event.keyCode = KeyCode.LeftArrow;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "right":
				@event.keyCode = KeyCode.RightArrow;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "insert":
				@event.keyCode = KeyCode.Insert;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "home":
				@event.keyCode = KeyCode.Home;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "end":
				@event.keyCode = KeyCode.End;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "pgup":
				@event.keyCode = KeyCode.PageDown;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "page up":
				@event.keyCode = KeyCode.PageUp;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "pgdown":
				@event.keyCode = KeyCode.PageUp;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "page down":
				@event.keyCode = KeyCode.PageDown;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "backspace":
				@event.keyCode = KeyCode.Backspace;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "delete":
				@event.keyCode = KeyCode.Delete;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "tab":
				@event.keyCode = KeyCode.Tab;
				return @event;
			case "f1":
				@event.keyCode = KeyCode.F1;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f2":
				@event.keyCode = KeyCode.F2;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f3":
				@event.keyCode = KeyCode.F3;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f4":
				@event.keyCode = KeyCode.F4;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f5":
				@event.keyCode = KeyCode.F5;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f6":
				@event.keyCode = KeyCode.F6;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f7":
				@event.keyCode = KeyCode.F7;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f8":
				@event.keyCode = KeyCode.F8;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f9":
				@event.keyCode = KeyCode.F9;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f10":
				@event.keyCode = KeyCode.F10;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f11":
				@event.keyCode = KeyCode.F11;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f12":
				@event.keyCode = KeyCode.F12;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f13":
				@event.keyCode = KeyCode.F13;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f14":
				@event.keyCode = KeyCode.F14;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "f15":
				@event.keyCode = KeyCode.F15;
				@event.modifiers |= EventModifiers.FunctionKey;
				return @event;
			case "[esc]":
				@event.keyCode = KeyCode.Escape;
				return @event;
			case "return":
				@event.character = '\n';
				@event.keyCode = KeyCode.Return;
				@event.modifiers &= ~EventModifiers.FunctionKey;
				return @event;
			case "space":
				@event.keyCode = KeyCode.Space;
				@event.character = ' ';
				@event.modifiers &= ~EventModifiers.FunctionKey;
				return @event;
			}
			if (text.Length != 1)
			{
				try
				{
					@event.keyCode = (KeyCode)((int)Enum.Parse(typeof(KeyCode), text, true));
				}
				catch (ArgumentException)
				{
					Debug.LogError(UnityString.Format("Unable to find key name that matches '{0}'", new object[] { text }));
				}
			}
			else
			{
				@event.character = text.ToLower()[0];
				@event.keyCode = (KeyCode)@event.character;
				if (@event.modifiers != EventModifiers.None)
				{
					@event.character = '\0';
				}
			}
			return @event;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0001CE98 File Offset: 0x0001B098
		public override int GetHashCode()
		{
			int num = 1;
			if (this.isKey)
			{
				num = (int)((ushort)this.keyCode);
			}
			if (this.isMouse)
			{
				num = this.mousePosition.GetHashCode();
			}
			return (num * 37) | (int)this.modifiers;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0001CEE4 File Offset: 0x0001B0E4
		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (object.ReferenceEquals(this, obj))
			{
				return true;
			}
			if (obj.GetType() != base.GetType())
			{
				return false;
			}
			Event @event = (Event)obj;
			if (this.type != @event.type || (this.modifiers & ~EventModifiers.CapsLock) != (@event.modifiers & ~EventModifiers.CapsLock))
			{
				return false;
			}
			if (this.isKey)
			{
				return this.keyCode == @event.keyCode;
			}
			return this.isMouse && this.mousePosition == @event.mousePosition;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0001CF84 File Offset: 0x0001B184
		public override string ToString()
		{
			if (this.isKey)
			{
				if (this.character == '\0')
				{
					return UnityString.Format("Event:{0}   Character:\\0   Modifiers:{1}   KeyCode:{2}", new object[] { this.type, this.modifiers, this.keyCode });
				}
				return string.Concat(new object[]
				{
					"Event:",
					this.type,
					"   Character:",
					(int)this.character,
					"   Modifiers:",
					this.modifiers,
					"   KeyCode:",
					this.keyCode
				});
			}
			else
			{
				if (this.isMouse)
				{
					return UnityString.Format("Event: {0}   Position: {1} Modifiers: {2}", new object[] { this.type, this.mousePosition, this.modifiers });
				}
				if (this.type == EventType.ExecuteCommand || this.type == EventType.ValidateCommand)
				{
					return UnityString.Format("Event: {0}  \"{1}\"", new object[] { this.type, this.commandName });
				}
				return string.Empty + this.type;
			}
		}

		// Token: 0x06001A01 RID: 6657
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Init();

		// Token: 0x06001A02 RID: 6658
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Cleanup();

		// Token: 0x06001A03 RID: 6659
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InitCopy(Event other);

		// Token: 0x06001A04 RID: 6660
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InitPtr(IntPtr ptr);

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001A05 RID: 6661
		public extern EventType rawType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The type of event.</para>
		/// </summary>
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001A06 RID: 6662
		// (set) Token: 0x06001A07 RID: 6663
		public extern EventType type
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Get a filtered event type for a given control ID.</para>
		/// </summary>
		/// <param name="controlID">The ID of the control you are querying from.</param>
		// Token: 0x06001A08 RID: 6664
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern EventType GetTypeForControl(int controlID);

		// Token: 0x06001A09 RID: 6665 RVA: 0x00009398 File Offset: 0x00007598
		private void Internal_SetMousePosition(Vector2 value)
		{
			Event.INTERNAL_CALL_Internal_SetMousePosition(this, ref value);
		}

		// Token: 0x06001A0A RID: 6666
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetMousePosition(Event self, ref Vector2 value);

		// Token: 0x06001A0B RID: 6667
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetMousePosition(out Vector2 value);

		// Token: 0x06001A0C RID: 6668 RVA: 0x000093A2 File Offset: 0x000075A2
		private void Internal_SetMouseDelta(Vector2 value)
		{
			Event.INTERNAL_CALL_Internal_SetMouseDelta(this, ref value);
		}

		// Token: 0x06001A0D RID: 6669
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_SetMouseDelta(Event self, ref Vector2 value);

		// Token: 0x06001A0E RID: 6670
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void Internal_GetMouseDelta(out Vector2 value);

		/// <summary>
		///   <para>Which mouse button was pressed.</para>
		/// </summary>
		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001A0F RID: 6671
		// (set) Token: 0x06001A10 RID: 6672
		public extern int button
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Which modifier keys are held down.</para>
		/// </summary>
		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001A11 RID: 6673
		// (set) Token: 0x06001A12 RID: 6674
		public extern EventModifiers modifiers
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001A13 RID: 6675
		// (set) Token: 0x06001A14 RID: 6676
		public extern float pressure
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>How many consecutive mouse clicks have we received.</para>
		/// </summary>
		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001A15 RID: 6677
		// (set) Token: 0x06001A16 RID: 6678
		public extern int clickCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The character typed.</para>
		/// </summary>
		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001A17 RID: 6679
		// (set) Token: 0x06001A18 RID: 6680
		public extern char character
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The name of an ExecuteCommand or ValidateCommand Event.</para>
		/// </summary>
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06001A19 RID: 6681
		// (set) Token: 0x06001A1A RID: 6682
		public extern string commandName
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The raw key code for keyboard events.</para>
		/// </summary>
		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001A1B RID: 6683
		// (set) Token: 0x06001A1C RID: 6684
		public extern KeyCode keyCode
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06001A1D RID: 6685
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetNativeEvent(IntPtr ptr);

		/// <summary>
		///   <para>Use this event.</para>
		/// </summary>
		// Token: 0x06001A1E RID: 6686
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Use();

		/// <summary>
		///   <para>Get the next queued [Event] from the event system.</para>
		/// </summary>
		/// <param name="outEvent">Next Event.</param>
		// Token: 0x06001A1F RID: 6687
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool PopEvent(Event outEvent);

		/// <summary>
		///   <para>Returns the current number of events that are stored in the event queue.</para>
		/// </summary>
		/// <returns>
		///   <para>Current number of events currently in the event queue.</para>
		/// </returns>
		// Token: 0x06001A20 RID: 6688
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetEventCount();

		// Token: 0x04000573 RID: 1395
		[NonSerialized]
		internal IntPtr m_Ptr;

		// Token: 0x04000574 RID: 1396
		private static Event s_Current;

		// Token: 0x04000575 RID: 1397
		private static Event s_MasterEvent;
	}
}
