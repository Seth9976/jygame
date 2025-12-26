using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Class to build avatars from user scripts.</para>
	/// </summary>
	// Token: 0x02000190 RID: 400
	public sealed class AvatarBuilder
	{
		/// <summary>
		///   <para>Create a humanoid avatar.</para>
		/// </summary>
		/// <param name="go">Root object of your transform hierachy.</param>
		/// <param name="monoHumanDescription">Description of the avatar.</param>
		// Token: 0x06001750 RID: 5968 RVA: 0x0000870E File Offset: 0x0000690E
		public static Avatar BuildHumanAvatar(GameObject go, HumanDescription monoHumanDescription)
		{
			if (go == null)
			{
				throw new NullReferenceException();
			}
			return AvatarBuilder.BuildHumanAvatarMono(go, monoHumanDescription);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00008729 File Offset: 0x00006929
		private static Avatar BuildHumanAvatarMono(GameObject go, HumanDescription monoHumanDescription)
		{
			return AvatarBuilder.INTERNAL_CALL_BuildHumanAvatarMono(go, ref monoHumanDescription);
		}

		// Token: 0x06001752 RID: 5970
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Avatar INTERNAL_CALL_BuildHumanAvatarMono(GameObject go, ref HumanDescription monoHumanDescription);

		/// <summary>
		///   <para>Create a new generic avatar.</para>
		/// </summary>
		/// <param name="go">Root object of your transform hierarchy.</param>
		/// <param name="rootMotionTransformName">Transform name of the root motion transform. If empty no root motion is defined and you must take care of avatar movement yourself.</param>
		// Token: 0x06001753 RID: 5971
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Avatar BuildGenericAvatar(GameObject go, string rootMotionTransformName);
	}
}
