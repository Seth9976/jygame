using System;
using System.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020002E5 RID: 741
	internal abstract class BaseInvokableCall
	{
		// Token: 0x06002282 RID: 8834 RVA: 0x000021D6 File Offset: 0x000003D6
		protected BaseInvokableCall()
		{
		}

		// Token: 0x06002283 RID: 8835 RVA: 0x0000DE68 File Offset: 0x0000C068
		protected BaseInvokableCall(object target, MethodInfo function)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (function == null)
			{
				throw new ArgumentNullException("function");
			}
		}

		// Token: 0x06002284 RID: 8836
		public abstract void Invoke(object[] args);

		// Token: 0x06002285 RID: 8837 RVA: 0x0000DE92 File Offset: 0x0000C092
		protected static void ThrowOnInvalidArg<T>(object arg)
		{
			if (arg != null && !(arg is T))
			{
				throw new ArgumentException(UnityString.Format("Passed argument 'args[0]' is of the wrong type. Type:{0} Expected:{1}", new object[]
				{
					arg.GetType(),
					typeof(T)
				}));
			}
		}

		// Token: 0x06002286 RID: 8838 RVA: 0x0002D1B0 File Offset: 0x0002B3B0
		protected static bool AllowInvoke(Delegate @delegate)
		{
			object target = @delegate.Target;
			if (target == null)
			{
				return true;
			}
			Object @object = target as Object;
			return object.ReferenceEquals(@object, null) || @object != null;
		}

		// Token: 0x06002287 RID: 8839
		public abstract bool Find(object targetObj, MethodInfo method);
	}
}
