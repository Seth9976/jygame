using System;
using System.Reflection;

namespace System.ComponentModel
{
	// Token: 0x020001A3 RID: 419
	internal class ReflectionEventDescriptor : EventDescriptor
	{
		// Token: 0x06000EB6 RID: 3766 RVA: 0x00035A58 File Offset: 0x00033C58
		public ReflectionEventDescriptor(EventInfo eventInfo)
			: base(eventInfo.Name, (Attribute[])eventInfo.GetCustomAttributes(true))
		{
			this._eventInfo = eventInfo;
			this._componentType = eventInfo.DeclaringType;
			this._eventType = eventInfo.EventHandlerType;
			this.add_method = eventInfo.GetAddMethod();
			this.remove_method = eventInfo.GetRemoveMethod();
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x00035AB4 File Offset: 0x00033CB4
		public ReflectionEventDescriptor(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attrs)
			: base(oldEventDescriptor, attrs)
		{
			this._componentType = componentType;
			this._eventType = oldEventDescriptor.EventType;
			EventInfo @event = componentType.GetEvent(oldEventDescriptor.Name);
			this.add_method = @event.GetAddMethod();
			this.remove_method = @event.GetRemoveMethod();
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00035B04 File Offset: 0x00033D04
		public ReflectionEventDescriptor(Type componentType, string name, Type type, Attribute[] attrs)
			: base(name, attrs)
		{
			this._componentType = componentType;
			this._eventType = type;
			EventInfo @event = componentType.GetEvent(name);
			this.add_method = @event.GetAddMethod();
			this.remove_method = @event.GetRemoveMethod();
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x00035B48 File Offset: 0x00033D48
		private EventInfo GetEventInfo()
		{
			if (this._eventInfo == null)
			{
				this._eventInfo = this._componentType.GetEvent(this.Name);
				if (this._eventInfo == null)
				{
					throw new ArgumentException("Accessor methods for the " + this.Name + " event are missing");
				}
			}
			return this._eventInfo;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0000C2FD File Offset: 0x0000A4FD
		public override void AddEventHandler(object component, Delegate value)
		{
			this.add_method.Invoke(component, new object[] { value });
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x0000C316 File Offset: 0x0000A516
		public override void RemoveEventHandler(object component, Delegate value)
		{
			this.remove_method.Invoke(component, new object[] { value });
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x0000C32F File Offset: 0x0000A52F
		public override Type ComponentType
		{
			get
			{
				return this._componentType;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x0000C337 File Offset: 0x0000A537
		public override Type EventType
		{
			get
			{
				return this._eventType;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x0000C33F File Offset: 0x0000A53F
		public override bool IsMulticast
		{
			get
			{
				return this.GetEventInfo().IsMulticast;
			}
		}

		// Token: 0x0400042B RID: 1067
		private Type _eventType;

		// Token: 0x0400042C RID: 1068
		private Type _componentType;

		// Token: 0x0400042D RID: 1069
		private EventInfo _eventInfo;

		// Token: 0x0400042E RID: 1070
		private MethodInfo add_method;

		// Token: 0x0400042F RID: 1071
		private MethodInfo remove_method;
	}
}
