using System;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;

namespace DG.Tweening.Core
{
	// Token: 0x02000027 RID: 39
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener where TPlugOptions : struct
	{
		// Token: 0x06000149 RID: 329 RVA: 0x000090E0 File Offset: 0x000072E0
		internal TweenerCore()
		{
			this.typeofT1 = typeof(T1);
			this.typeofT2 = typeof(T2);
			this.typeofTPlugOptions = typeof(TPlugOptions);
			this.tweenType = TweenType.Tweener;
			this.Reset();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00009130 File Offset: 0x00007330
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f)
		{
			if (this.isSequenced)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning("You cannot change the values of a tween contained inside a Sequence");
				}
				return this;
			}
			Type type = newStartValue.GetType();
			if (type != this.typeofT2)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning(string.Concat(new object[] { "ChangeStartValue: incorrect newStartValue type (is ", type, ", should be ", this.typeofT2, ")" }));
				}
				return this;
			}
			return Tweener.DoChangeStartValue<T1, T2, TPlugOptions>(this, (T2)((object)newStartValue), newDuration);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000091B7 File Offset: 0x000073B7
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue)
		{
			return this.ChangeEndValue(newEndValue, -1f, snapStartValue);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000091C8 File Offset: 0x000073C8
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false)
		{
			if (this.isSequenced)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning("You cannot change the values of a tween contained inside a Sequence");
				}
				return this;
			}
			Type type = newEndValue.GetType();
			if (type != this.typeofT2)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning(string.Concat(new object[] { "ChangeEndValue: incorrect newEndValue type (is ", type, ", should be ", this.typeofT2, ")" }));
				}
				return this;
			}
			return Tweener.DoChangeEndValue<T1, T2, TPlugOptions>(this, (T2)((object)newEndValue), newDuration, snapStartValue);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00009250 File Offset: 0x00007450
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f)
		{
			if (this.isSequenced)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning("You cannot change the values of a tween contained inside a Sequence");
				}
				return this;
			}
			Type type = newStartValue.GetType();
			Type type2 = newEndValue.GetType();
			if (type != this.typeofT2)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning(string.Concat(new object[] { "ChangeValues: incorrect value type (is ", type, ", should be ", this.typeofT2, ")" }));
				}
				return this;
			}
			if (type2 != this.typeofT2)
			{
				if (Debugger.logPriority >= 1)
				{
					Debugger.LogWarning(string.Concat(new object[] { "ChangeValues: incorrect value type (is ", type2, ", should be ", this.typeofT2, ")" }));
				}
				return this;
			}
			return Tweener.DoChangeValues<T1, T2, TPlugOptions>(this, (T2)((object)newStartValue), (T2)((object)newEndValue), newDuration);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000932E File Offset: 0x0000752E
		internal override Tweener SetFrom(bool relative)
		{
			this.tweenPlugin.SetFrom(this, relative);
			this.hasManuallySetStartValue = true;
			return this;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009348 File Offset: 0x00007548
		internal sealed override void Reset()
		{
			base.Reset();
			if (this.tweenPlugin != null)
			{
				this.tweenPlugin.Reset(this);
			}
			this.plugOptions = default(TPlugOptions);
			this.getter = null;
			this.setter = null;
			this.hasManuallySetStartValue = false;
			this.isFromAllowed = true;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00009398 File Offset: 0x00007598
		internal override bool Validate()
		{
			try
			{
				this.getter();
			}
			catch
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000093CC File Offset: 0x000075CC
		internal override float UpdateDelay(float elapsed)
		{
			return Tweener.DoUpdateDelay<T1, T2, TPlugOptions>(this, elapsed);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000093D5 File Offset: 0x000075D5
		internal override bool Startup()
		{
			return Tweener.DoStartup<T1, T2, TPlugOptions>(this);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000093E0 File Offset: 0x000075E0
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode)
		{
			float num = (useInversePosition ? (this.duration - this.position) : this.position);
			if (DOTween.useSafeMode)
			{
				try
				{
					this.tweenPlugin.EvaluateAndApply(this.plugOptions, this, this.isRelative, this.getter, this.setter, num, this.startValue, this.changeValue, this.duration);
					return false;
				}
				catch
				{
					return true;
				}
			}
			this.tweenPlugin.EvaluateAndApply(this.plugOptions, this, this.isRelative, this.getter, this.setter, num, this.startValue, this.changeValue, this.duration);
			return false;
		}

		// Token: 0x040000BF RID: 191
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";

		// Token: 0x040000C0 RID: 192
		public T2 startValue;

		// Token: 0x040000C1 RID: 193
		public T2 endValue;

		// Token: 0x040000C2 RID: 194
		public T2 changeValue;

		// Token: 0x040000C3 RID: 195
		public TPlugOptions plugOptions;

		// Token: 0x040000C4 RID: 196
		public DOGetter<T1> getter;

		// Token: 0x040000C5 RID: 197
		public DOSetter<T1> setter;

		// Token: 0x040000C6 RID: 198
		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
	}
}
