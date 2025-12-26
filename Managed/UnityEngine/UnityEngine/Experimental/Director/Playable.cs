using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnityEngine.Experimental.Director
{
	/// <summary>
	///   <para>Playables are customizable runtime objects that can be connected together in a tree to create complex behaviours.</para>
	/// </summary>
	// Token: 0x020000D7 RID: 215
	public class Playable : IDisposable
	{
		// Token: 0x06000CDF RID: 3295 RVA: 0x00006689 File Offset: 0x00004889
		public Playable()
		{
			this.m_Ptr = IntPtr.Zero;
			this.m_UniqueId = this.GenerateUniqueId();
			this.InstantiateEnginePlayable();
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x000066AE File Offset: 0x000048AE
		internal Playable(bool callCPPConstructor)
		{
			this.m_Ptr = IntPtr.Zero;
			this.m_UniqueId = this.GenerateUniqueId();
			if (callCPPConstructor)
			{
				this.InstantiateEnginePlayable();
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x000066D9 File Offset: 0x000048D9
		private void Dispose(bool disposing)
		{
			this.ReleaseEnginePlayable();
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x06000CE2 RID: 3298
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern int GetUniqueIDInternal();

		// Token: 0x06000CE3 RID: 3299 RVA: 0x000066EC File Offset: 0x000048EC
		public static bool Connect(Playable source, Playable target)
		{
			return Playable.Connect(source, target, -1, -1);
		}

		/// <summary>
		///   <para>Connects two Playables together.</para>
		/// </summary>
		/// <param name="source">Playable to be used as input.</param>
		/// <param name="target">Playable on which the input will be connected.</param>
		/// <param name="sourceOutputPort">Optional index of the output on the source Playable.</param>
		/// <param name="targetInputPort">Optional index of the input on the target Playable.</param>
		/// <returns>
		///   <para>Returns false if the operation could not be completed.</para>
		/// </returns>
		// Token: 0x06000CE4 RID: 3300 RVA: 0x00017840 File Offset: 0x00015A40
		public static bool Connect(Playable source, Playable target, int sourceOutputPort, int targetInputPort)
		{
			return (Playable.CheckPlayableValidity(source, "source") || Playable.CheckPlayableValidity(target, "target")) && (!(source != null) || source.CheckInputBounds(sourceOutputPort, true)) && target.CheckInputBounds(targetInputPort, true) && Playable.ConnectInternal(source, target, sourceOutputPort, targetInputPort);
		}

		/// <summary>
		///   <para>Disconnects an input from a Playable.</para>
		/// </summary>
		/// <param name="right">Playable from which the input will be disconnected.</param>
		/// <param name="inputPort">Index of the input to disconnect.</param>
		/// <param name="target"></param>
		// Token: 0x06000CE5 RID: 3301 RVA: 0x000066F7 File Offset: 0x000048F7
		public static void Disconnect(Playable target, int inputPort)
		{
			if (!Playable.CheckPlayableValidity(target, "target"))
			{
				return;
			}
			if (!target.CheckInputBounds(inputPort))
			{
				return;
			}
			Playable.DisconnectInternal(target, inputPort);
		}

		// Token: 0x06000CE6 RID: 3302
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void ReleaseEnginePlayable();

		// Token: 0x06000CE7 RID: 3303
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void InstantiateEnginePlayable();

		// Token: 0x06000CE8 RID: 3304
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern int GenerateUniqueId();

		// Token: 0x06000CE9 RID: 3305
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern bool SetInputWeightInternal(int inputIndex, float weight);

		// Token: 0x06000CEA RID: 3306
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern float GetInputWeightInternal(int inputIndex);

		/// <summary>
		///   <para>Current local time for this Playable.</para>
		/// </summary>
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000CEB RID: 3307
		// (set) Token: 0x06000CEC RID: 3308
		public extern double time
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Current Experimental.Director.PlayState of this playable. This indicates whether the Playable is currently playing or paused.</para>
		/// </summary>
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000CED RID: 3309
		// (set) Token: 0x06000CEE RID: 3310
		public extern PlayState state
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000CEF RID: 3311
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool ConnectInternal(Playable source, Playable target, int sourceOutputPort, int targetInputPort);

		// Token: 0x06000CF0 RID: 3312
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void DisconnectInternal(Playable target, int inputPort);

		/// <summary>
		///   <para>Returns the Playable connected at the specified index.</para>
		/// </summary>
		/// <param name="inputPort">Index of the input.</param>
		/// <returns>
		///   <para>Playable connected at the index specified, or null if the index is valid but is not connected to anything. This happens if there was once a Playable connected at the index, but was disconnected via Playable::Disconnect.</para>
		/// </returns>
		// Token: 0x06000CF1 RID: 3313
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Playable GetInput(int inputPort);

		// Token: 0x06000CF2 RID: 3314
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Playable[] GetInputs();

		/// <summary>
		///   <para>The count of inputs on the Playable. This count includes slots that aren't connected to anything. This is equivalent to, but much faster than calling GetInputs().Length.</para>
		/// </summary>
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000CF3 RID: 3315
		public extern int inputCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The count of inputs on the Playable. This count includes slots that aren't connected to anything. This is equivalent to, but much faster than calling GetOutputs().Length.</para>
		/// </summary>
		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000CF4 RID: 3316
		public extern int outputCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Safely disconnects all connected inputs and resizes the input array to 0.</para>
		/// </summary>
		// Token: 0x06000CF5 RID: 3317
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ClearInputs();

		/// <summary>
		///   <para>Returns the Playable connected at the specified output index.</para>
		/// </summary>
		/// <param name="outputPort">Index of the output.</param>
		/// <returns>
		///   <para>Playable connected at the output index specified, or null if the index is valid but is not connected to anything. This happens if there was once a Playable connected at the index, but was disconnected via Playable::Disconnect.</para>
		/// </returns>
		// Token: 0x06000CF6 RID: 3318
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Playable GetOutput(int outputPort);

		// Token: 0x06000CF7 RID: 3319
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Playable[] GetOutputs();

		// Token: 0x06000CF8 RID: 3320
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetInputsInternal(object list);

		// Token: 0x06000CF9 RID: 3321
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void GetOutputsInternal(object list);

		// Token: 0x06000CFA RID: 3322 RVA: 0x000178A4 File Offset: 0x00015AA4
		~Playable()
		{
			this.Dispose(false);
		}

		/// <summary>
		///   <para>Implements IDisposable. Call this method to release the resources allocated by the Playable.</para>
		/// </summary>
		// Token: 0x06000CFB RID: 3323 RVA: 0x0000671E File Offset: 0x0000491E
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x0000672D File Offset: 0x0000492D
		public override bool Equals(object p)
		{
			return Playable.CompareIntPtr(this, p as Playable);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0000673B File Offset: 0x0000493B
		public override int GetHashCode()
		{
			return this.m_UniqueId;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000178D4 File Offset: 0x00015AD4
		internal static bool CompareIntPtr(Playable lhs, Playable rhs)
		{
			bool flag = lhs == null || !Playable.IsNativePlayableAlive(lhs);
			bool flag2 = rhs == null || !Playable.IsNativePlayableAlive(rhs);
			if (flag2 && flag)
			{
				return true;
			}
			if (flag2)
			{
				return !Playable.IsNativePlayableAlive(lhs);
			}
			if (flag)
			{
				return !Playable.IsNativePlayableAlive(rhs);
			}
			return lhs.GetUniqueIDInternal() == rhs.GetUniqueIDInternal();
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00006743 File Offset: 0x00004943
		internal static bool IsNativePlayableAlive(Playable p)
		{
			return p.m_Ptr != IntPtr.Zero;
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00006755 File Offset: 0x00004955
		internal static bool CheckPlayableValidity(Playable playable, string name)
		{
			if (playable == null)
			{
				throw new NullReferenceException("Playable " + name + "is null");
			}
			return true;
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x0000677A File Offset: 0x0000497A
		internal bool CheckInputBounds(int inputIndex)
		{
			return this.CheckInputBounds(inputIndex, false);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00017944 File Offset: 0x00015B44
		internal bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			if (inputIndex == -1 && acceptAny)
			{
				return true;
			}
			if (inputIndex < 0)
			{
				throw new IndexOutOfRangeException("Index must be greater than 0");
			}
			Playable[] inputs = this.GetInputs();
			if (inputs.Length <= inputIndex)
			{
				throw new IndexOutOfRangeException(string.Concat(new object[] { "inputIndex ", inputIndex, " is greater than the number of available inputs (", inputs.Length, ")." }));
			}
			return true;
		}

		/// <summary>
		///   <para>Get the weight of the Playable at a specified index.</para>
		/// </summary>
		/// <param name="inputIndex">Index of the Playable.</param>
		/// <returns>
		///   <para>Weight of the input Playable. Returns -1 if there is no input connected at this input index.</para>
		/// </returns>
		// Token: 0x06000D03 RID: 3331 RVA: 0x00006784 File Offset: 0x00004984
		public float GetInputWeight(int inputIndex)
		{
			if (this.CheckInputBounds(inputIndex))
			{
				return this.GetInputWeightInternal(inputIndex);
			}
			return -1f;
		}

		/// <summary>
		///   <para>Set the weight of an input.</para>
		/// </summary>
		/// <param name="inputIndex">Index of the input.</param>
		/// <param name="weight">Weight of the input.</param>
		/// <returns>
		///   <para>Returns false if there is no input Playable connected at that index.</para>
		/// </returns>
		// Token: 0x06000D04 RID: 3332 RVA: 0x0000679F File Offset: 0x0000499F
		public bool SetInputWeight(int inputIndex, float weight)
		{
			return this.CheckInputBounds(inputIndex) && this.SetInputWeightInternal(inputIndex, weight);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x000067B7 File Offset: 0x000049B7
		public void GetInputs(List<Playable> inputList)
		{
			inputList.Clear();
			this.GetInputsInternal(inputList);
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000067C6 File Offset: 0x000049C6
		public void GetOutputs(List<Playable> outputList)
		{
			outputList.Clear();
			this.GetOutputsInternal(outputList);
		}

		/// <summary>
		///   <para>Prepares the Experimental.Director.Playable tree for the next frame. PrepareFrame is called before the tree is evaluated.</para>
		/// </summary>
		/// <param name="info">Data for the current frame.</param>
		// Token: 0x06000D07 RID: 3335 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void PrepareFrame(FrameData info)
		{
		}

		/// <summary>
		///   <para>Evaluates the Playable with a delta time.</para>
		/// </summary>
		/// <param name="info">The Experimental.Director.FrameData for the current frame.</param>
		/// <param name="playerData">Custom data passed down the tree, specified in DirectorPlayer.Play.</param>
		// Token: 0x06000D08 RID: 3336 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void ProcessFrame(FrameData info, object playerData)
		{
		}

		/// <summary>
		///   <para>Callback called when the current time has changed</para>
		/// </summary>
		/// <param name="localTime">New local time</param>
		// Token: 0x06000D09 RID: 3337 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnSetTime(float localTime)
		{
		}

		/// <summary>
		///   <para>Callback called when the PlayState has changed</para>
		/// </summary>
		/// <param name="newState">New PlayState</param>
		// Token: 0x06000D0A RID: 3338 RVA: 0x00002753 File Offset: 0x00000953
		public virtual void OnSetPlayState(PlayState newState)
		{
		}

		// Token: 0x06000D0B RID: 3339 RVA: 0x000067D5 File Offset: 0x000049D5
		public static bool operator ==(Playable x, Playable y)
		{
			return Playable.CompareIntPtr(x, y);
		}

		// Token: 0x06000D0C RID: 3340 RVA: 0x000067DE File Offset: 0x000049DE
		public static bool operator !=(Playable x, Playable y)
		{
			return !Playable.CompareIntPtr(x, y);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x000067EA File Offset: 0x000049EA
		public static implicit operator bool(Playable exists)
		{
			return !Playable.CompareIntPtr(exists, null);
		}

		// Token: 0x04000266 RID: 614
		internal IntPtr m_Ptr;

		// Token: 0x04000267 RID: 615
		internal int m_UniqueId;
	}
}
