using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Experimental.Director
{
	/// <summary>
	///   <para>Base class for all animation related Playable classes.</para>
	/// </summary>
	// Token: 0x0200019F RID: 415
	public class AnimationPlayable : Playable
	{
		// Token: 0x0600177F RID: 6015 RVA: 0x000087C7 File Offset: 0x000069C7
		public AnimationPlayable()
			: base(false)
		{
			this.m_Ptr = IntPtr.Zero;
			this.InstantiateEnginePlayable();
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000087E1 File Offset: 0x000069E1
		public AnimationPlayable(bool final)
			: base(false)
		{
			this.m_Ptr = IntPtr.Zero;
			if (final)
			{
				this.InstantiateEnginePlayable();
			}
		}

		// Token: 0x06001781 RID: 6017
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InstantiateEnginePlayable();

		/// <summary>
		///   <para>Adds an AnimationPlayable as an input.</para>
		/// </summary>
		/// <param name="source">A playable to connect.</param>
		/// <returns>
		///   <para>Returns the index of the port the playable was connected to.</para>
		/// </returns>
		// Token: 0x06001782 RID: 6018 RVA: 0x0001AFF4 File Offset: 0x000191F4
		public virtual int AddInput(AnimationPlayable source)
		{
			Playable.Connect(source, this, -1, -1);
			Playable[] inputs = base.GetInputs();
			return inputs.Length - 1;
		}

		/// <summary>
		///   <para>Sets an AnimationPlayable as an input.</para>
		/// </summary>
		/// <param name="source">AnimationPlayable to be used as input.</param>
		/// <param name="index">Index of the input.</param>
		/// <returns>
		///   <para>Returns false if the operation could not be completed.</para>
		/// </returns>
		// Token: 0x06001783 RID: 6019 RVA: 0x0001B018 File Offset: 0x00019218
		public virtual bool SetInput(AnimationPlayable source, int index)
		{
			if (!base.CheckInputBounds(index))
			{
				return false;
			}
			Playable[] inputs = base.GetInputs();
			if (inputs[index] != null)
			{
				Playable.Disconnect(this, index);
			}
			return Playable.Connect(source, this, -1, index);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x0001B058 File Offset: 0x00019258
		public virtual bool SetInputs(IEnumerable<AnimationPlayable> sources)
		{
			Playable[] inputs = base.GetInputs();
			int num = inputs.Length;
			for (int i = 0; i < num; i++)
			{
				Playable.Disconnect(this, i);
			}
			bool flag = false;
			int num2 = 0;
			foreach (AnimationPlayable animationPlayable in sources)
			{
				if (num2 < num)
				{
					flag |= Playable.Connect(animationPlayable, this, -1, num2);
				}
				else
				{
					flag |= Playable.Connect(animationPlayable, this, -1, -1);
				}
				base.SetInputWeight(num2, 1f);
				num2++;
			}
			for (int j = num2; j < num; j++)
			{
				base.SetInputWeight(j, 0f);
			}
			return flag;
		}

		/// <summary>
		///   <para>Removes a playable from the list of inputs.</para>
		/// </summary>
		/// <param name="index">Index of the playable to remove.</param>
		/// <param name="playable">AnimationPlayable to remove.</param>
		/// <returns>
		///   <para>Returns false if the removal could not be removed because it wasn't found.</para>
		/// </returns>
		// Token: 0x06001785 RID: 6021 RVA: 0x00008801 File Offset: 0x00006A01
		public virtual bool RemoveInput(int index)
		{
			if (!base.CheckInputBounds(index))
			{
				return false;
			}
			Playable.Disconnect(this, index);
			return true;
		}

		/// <summary>
		///   <para>Removes a playable from the list of inputs.</para>
		/// </summary>
		/// <param name="index">Index of the playable to remove.</param>
		/// <param name="playable">AnimationPlayable to remove.</param>
		/// <returns>
		///   <para>Returns false if the removal could not be removed because it wasn't found.</para>
		/// </returns>
		// Token: 0x06001786 RID: 6022 RVA: 0x0001B134 File Offset: 0x00019334
		public virtual bool RemoveInput(AnimationPlayable playable)
		{
			if (!Playable.CheckPlayableValidity(playable, "playable"))
			{
				return false;
			}
			Playable[] inputs = base.GetInputs();
			for (int i = 0; i < inputs.Length; i++)
			{
				if (inputs[i] == playable)
				{
					Playable.Disconnect(this, i);
					return true;
				}
			}
			return false;
		}

		/// <summary>
		///   <para>Disconnects all input playables.</para>
		/// </summary>
		/// <returns>
		///   <para>Returns false if the removal fails.</para>
		/// </returns>
		// Token: 0x06001787 RID: 6023 RVA: 0x0001B188 File Offset: 0x00019388
		public virtual bool RemoveAllInputs()
		{
			Playable[] inputs = base.GetInputs();
			for (int i = 0; i < inputs.Length; i++)
			{
				this.RemoveInput(inputs[i] as AnimationPlayable);
			}
			return true;
		}
	}
}
