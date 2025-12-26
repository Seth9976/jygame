using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Position, rotation and scale of an object.</para>
	/// </summary>
	// Token: 0x020000CA RID: 202
	public class Transform : Component, IEnumerable
	{
		// Token: 0x06000C16 RID: 3094 RVA: 0x00002279 File Offset: 0x00000479
		protected Transform()
		{
		}

		/// <summary>
		///   <para>The position of the transform in world space.</para>
		/// </summary>
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000174C0 File Offset: 0x000156C0
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x0000631D File Offset: 0x0000451D
		public Vector3 position
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_position(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_position(ref value);
			}
		}

		// Token: 0x06000C19 RID: 3097
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_position(out Vector3 value);

		// Token: 0x06000C1A RID: 3098
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_position(ref Vector3 value);

		/// <summary>
		///   <para>Position of the transform relative to the parent transform.</para>
		/// </summary>
		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x000174D8 File Offset: 0x000156D8
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x00006327 File Offset: 0x00004527
		public Vector3 localPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_localPosition(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_localPosition(ref value);
			}
		}

		// Token: 0x06000C1D RID: 3101
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localPosition(out Vector3 value);

		// Token: 0x06000C1E RID: 3102
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localPosition(ref Vector3 value);

		/// <summary>
		///   <para>The rotation as Euler angles in degrees.</para>
		/// </summary>
		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x000174F0 File Offset: 0x000156F0
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x00006331 File Offset: 0x00004531
		public Vector3 eulerAngles
		{
			get
			{
				return this.rotation.eulerAngles;
			}
			set
			{
				this.rotation = Quaternion.Euler(value);
			}
		}

		/// <summary>
		///   <para>The rotation as Euler angles in degrees relative to the parent transform's rotation.</para>
		/// </summary>
		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0001750C File Offset: 0x0001570C
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x0000633F File Offset: 0x0000453F
		public Vector3 localEulerAngles
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_localEulerAngles(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_localEulerAngles(ref value);
			}
		}

		// Token: 0x06000C23 RID: 3107
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localEulerAngles(out Vector3 value);

		// Token: 0x06000C24 RID: 3108
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localEulerAngles(ref Vector3 value);

		/// <summary>
		///   <para>The red axis of the transform in world space.</para>
		/// </summary>
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x00006349 File Offset: 0x00004549
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x0000635B File Offset: 0x0000455B
		public Vector3 right
		{
			get
			{
				return this.rotation * Vector3.right;
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.right, value);
			}
		}

		/// <summary>
		///   <para>The green axis of the transform in world space.</para>
		/// </summary>
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x0000636E File Offset: 0x0000456E
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x00006380 File Offset: 0x00004580
		public Vector3 up
		{
			get
			{
				return this.rotation * Vector3.up;
			}
			set
			{
				this.rotation = Quaternion.FromToRotation(Vector3.up, value);
			}
		}

		/// <summary>
		///   <para>The blue axis of the transform in world space.</para>
		/// </summary>
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00006393 File Offset: 0x00004593
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x000063A5 File Offset: 0x000045A5
		public Vector3 forward
		{
			get
			{
				return this.rotation * Vector3.forward;
			}
			set
			{
				this.rotation = Quaternion.LookRotation(value);
			}
		}

		/// <summary>
		///   <para>The rotation of the transform in world space stored as a Quaternion.</para>
		/// </summary>
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00017524 File Offset: 0x00015724
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x000063B3 File Offset: 0x000045B3
		public Quaternion rotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_rotation(out quaternion);
				return quaternion;
			}
			set
			{
				this.INTERNAL_set_rotation(ref value);
			}
		}

		// Token: 0x06000C2D RID: 3117
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_rotation(out Quaternion value);

		// Token: 0x06000C2E RID: 3118
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_rotation(ref Quaternion value);

		/// <summary>
		///   <para>The rotation of the transform relative to the parent transform's rotation.</para>
		/// </summary>
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0001753C File Offset: 0x0001573C
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x000063BD File Offset: 0x000045BD
		public Quaternion localRotation
		{
			get
			{
				Quaternion quaternion;
				this.INTERNAL_get_localRotation(out quaternion);
				return quaternion;
			}
			set
			{
				this.INTERNAL_set_localRotation(ref value);
			}
		}

		// Token: 0x06000C31 RID: 3121
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localRotation(out Quaternion value);

		// Token: 0x06000C32 RID: 3122
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localRotation(ref Quaternion value);

		/// <summary>
		///   <para>The scale of the transform relative to the parent.</para>
		/// </summary>
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x00017554 File Offset: 0x00015754
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x000063C7 File Offset: 0x000045C7
		public Vector3 localScale
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_localScale(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_localScale(ref value);
			}
		}

		// Token: 0x06000C35 RID: 3125
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localScale(out Vector3 value);

		// Token: 0x06000C36 RID: 3126
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_localScale(ref Vector3 value);

		/// <summary>
		///   <para>The parent of the transform.</para>
		/// </summary>
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x000063D1 File Offset: 0x000045D1
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x000063D9 File Offset: 0x000045D9
		public Transform parent
		{
			get
			{
				return this.parentInternal;
			}
			set
			{
				if (this is RectTransform)
				{
					Debug.LogWarning("Parent of RectTransform is being set with parent property. Consider using the SetParent method instead, with the worldPositionStays argument set to false. This will retain local orientation and scale rather than world orientation and scale, which can prevent common UI scaling issues.", this);
				}
				this.parentInternal = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000C39 RID: 3129
		// (set) Token: 0x06000C3A RID: 3130
		internal extern Transform parentInternal
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x000063F8 File Offset: 0x000045F8
		public void SetParent(Transform parent)
		{
			this.SetParent(parent, true);
		}

		/// <summary>
		///   <para>Set the parent of the transform.</para>
		/// </summary>
		/// <param name="parent">The parent Transform to use.</param>
		/// <param name="worldPositionStays">If true, the parent-relative position, scale and rotation is modified such that the object keeps the same world space position, rotation and scale as before.</param>
		// Token: 0x06000C3C RID: 3132
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetParent(Transform parent, bool worldPositionStays);

		/// <summary>
		///   <para>Matrix that transforms a point from world space into local space (Read Only).</para>
		/// </summary>
		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x0001756C File Offset: 0x0001576C
		public Matrix4x4 worldToLocalMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.INTERNAL_get_worldToLocalMatrix(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x06000C3E RID: 3134
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_worldToLocalMatrix(out Matrix4x4 value);

		/// <summary>
		///   <para>Matrix that transforms a point from local space into world space (Read Only).</para>
		/// </summary>
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00017584 File Offset: 0x00015784
		public Matrix4x4 localToWorldMatrix
		{
			get
			{
				Matrix4x4 matrix4x;
				this.INTERNAL_get_localToWorldMatrix(out matrix4x);
				return matrix4x;
			}
		}

		// Token: 0x06000C40 RID: 3136
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_localToWorldMatrix(out Matrix4x4 value);

		/// <summary>
		///   <para>Moves the transform in the direction and distance of translation.</para>
		/// </summary>
		/// <param name="translation"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C41 RID: 3137 RVA: 0x0001759C File Offset: 0x0001579C
		[ExcludeFromDocs]
		public void Translate(Vector3 translation)
		{
			Space space = Space.Self;
			this.Translate(translation, space);
		}

		/// <summary>
		///   <para>Moves the transform in the direction and distance of translation.</para>
		/// </summary>
		/// <param name="translation"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C42 RID: 3138 RVA: 0x00006402 File Offset: 0x00004602
		public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo)
		{
			if (relativeTo == Space.World)
			{
				this.position += translation;
			}
			else
			{
				this.position += this.TransformDirection(translation);
			}
		}

		/// <summary>
		///   <para>Moves the transform by x along the x axis, y along the y axis, and z along the z axis.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C43 RID: 3139 RVA: 0x000175B4 File Offset: 0x000157B4
		[ExcludeFromDocs]
		public void Translate(float x, float y, float z)
		{
			Space space = Space.Self;
			this.Translate(x, y, z, space);
		}

		/// <summary>
		///   <para>Moves the transform by x along the x axis, y along the y axis, and z along the z axis.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C44 RID: 3140 RVA: 0x00006439 File Offset: 0x00004639
		public void Translate(float x, float y, float z, [DefaultValue("Space.Self")] Space relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		/// <summary>
		///   <para>Moves the transform in the direction and distance of translation.</para>
		/// </summary>
		/// <param name="translation"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C45 RID: 3141 RVA: 0x0000644B File Offset: 0x0000464B
		public void Translate(Vector3 translation, Transform relativeTo)
		{
			if (relativeTo)
			{
				this.position += relativeTo.TransformDirection(translation);
			}
			else
			{
				this.position += translation;
			}
		}

		/// <summary>
		///   <para>Moves the transform by x along the x axis, y along the y axis, and z along the z axis.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C46 RID: 3142 RVA: 0x00006487 File Offset: 0x00004687
		public void Translate(float x, float y, float z, Transform relativeTo)
		{
			this.Translate(new Vector3(x, y, z), relativeTo);
		}

		/// <summary>
		///   <para>Applies a rotation of eulerAngles.z degrees around the z axis, eulerAngles.x degrees around the x axis, and eulerAngles.y degrees around the y axis (in that order).</para>
		/// </summary>
		/// <param name="eulerAngles"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C47 RID: 3143 RVA: 0x000175D0 File Offset: 0x000157D0
		[ExcludeFromDocs]
		public void Rotate(Vector3 eulerAngles)
		{
			Space space = Space.Self;
			this.Rotate(eulerAngles, space);
		}

		/// <summary>
		///   <para>Applies a rotation of eulerAngles.z degrees around the z axis, eulerAngles.x degrees around the x axis, and eulerAngles.y degrees around the y axis (in that order).</para>
		/// </summary>
		/// <param name="eulerAngles"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C48 RID: 3144 RVA: 0x000175E8 File Offset: 0x000157E8
		public void Rotate(Vector3 eulerAngles, [DefaultValue("Space.Self")] Space relativeTo)
		{
			Quaternion quaternion = Quaternion.Euler(eulerAngles.x, eulerAngles.y, eulerAngles.z);
			if (relativeTo == Space.Self)
			{
				this.localRotation *= quaternion;
			}
			else
			{
				this.rotation *= Quaternion.Inverse(this.rotation) * quaternion * this.rotation;
			}
		}

		/// <summary>
		///   <para>Applies a rotation of zAngle degrees around the z axis, xAngle degrees around the x axis, and yAngle degrees around the y axis (in that order).</para>
		/// </summary>
		/// <param name="xAngle"></param>
		/// <param name="yAngle"></param>
		/// <param name="zAngle"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C49 RID: 3145 RVA: 0x0001765C File Offset: 0x0001585C
		[ExcludeFromDocs]
		public void Rotate(float xAngle, float yAngle, float zAngle)
		{
			Space space = Space.Self;
			this.Rotate(xAngle, yAngle, zAngle, space);
		}

		/// <summary>
		///   <para>Applies a rotation of zAngle degrees around the z axis, xAngle degrees around the x axis, and yAngle degrees around the y axis (in that order).</para>
		/// </summary>
		/// <param name="xAngle"></param>
		/// <param name="yAngle"></param>
		/// <param name="zAngle"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C4A RID: 3146 RVA: 0x00006499 File Offset: 0x00004699
		public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo)
		{
			this.Rotate(new Vector3(xAngle, yAngle, zAngle), relativeTo);
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000064AB File Offset: 0x000046AB
		internal void RotateAroundInternal(Vector3 axis, float angle)
		{
			Transform.INTERNAL_CALL_RotateAroundInternal(this, ref axis, angle);
		}

		// Token: 0x06000C4C RID: 3148
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RotateAroundInternal(Transform self, ref Vector3 axis, float angle);

		/// <summary>
		///   <para>Rotates the transform around axis by angle degrees.</para>
		/// </summary>
		/// <param name="axis"></param>
		/// <param name="angle"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C4D RID: 3149 RVA: 0x00017678 File Offset: 0x00015878
		[ExcludeFromDocs]
		public void Rotate(Vector3 axis, float angle)
		{
			Space space = Space.Self;
			this.Rotate(axis, angle, space);
		}

		/// <summary>
		///   <para>Rotates the transform around axis by angle degrees.</para>
		/// </summary>
		/// <param name="axis"></param>
		/// <param name="angle"></param>
		/// <param name="relativeTo"></param>
		// Token: 0x06000C4E RID: 3150 RVA: 0x000064B6 File Offset: 0x000046B6
		public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
		{
			if (relativeTo == Space.Self)
			{
				this.RotateAroundInternal(base.transform.TransformDirection(axis), angle * 0.017453292f);
			}
			else
			{
				this.RotateAroundInternal(axis, angle * 0.017453292f);
			}
		}

		/// <summary>
		///   <para>Rotates the transform about axis passing through point in world coordinates by angle degrees.</para>
		/// </summary>
		/// <param name="point"></param>
		/// <param name="axis"></param>
		/// <param name="angle"></param>
		// Token: 0x06000C4F RID: 3151 RVA: 0x00017690 File Offset: 0x00015890
		public void RotateAround(Vector3 point, Vector3 axis, float angle)
		{
			Vector3 vector = this.position;
			Quaternion quaternion = Quaternion.AngleAxis(angle, axis);
			Vector3 vector2 = vector - point;
			vector2 = quaternion * vector2;
			vector = point + vector2;
			this.position = vector;
			this.RotateAroundInternal(axis, angle * 0.017453292f);
		}

		/// <summary>
		///   <para>Rotates the transform so the forward vector points at target's current position.</para>
		/// </summary>
		/// <param name="target">Object to point towards.</param>
		/// <param name="worldUp">Vector specifying the upward direction.</param>
		// Token: 0x06000C50 RID: 3152 RVA: 0x000176DC File Offset: 0x000158DC
		[ExcludeFromDocs]
		public void LookAt(Transform target)
		{
			Vector3 up = Vector3.up;
			this.LookAt(target, up);
		}

		/// <summary>
		///   <para>Rotates the transform so the forward vector points at target's current position.</para>
		/// </summary>
		/// <param name="target">Object to point towards.</param>
		/// <param name="worldUp">Vector specifying the upward direction.</param>
		// Token: 0x06000C51 RID: 3153 RVA: 0x000064EB File Offset: 0x000046EB
		public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
			if (target)
			{
				this.LookAt(target.position, worldUp);
			}
		}

		/// <summary>
		///   <para>Rotates the transform so the forward vector points at worldPosition.</para>
		/// </summary>
		/// <param name="worldPosition">Point to look at.</param>
		/// <param name="worldUp">Vector specifying the upward direction.</param>
		// Token: 0x06000C52 RID: 3154 RVA: 0x00006505 File Offset: 0x00004705
		public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
			Transform.INTERNAL_CALL_LookAt(this, ref worldPosition, ref worldUp);
		}

		/// <summary>
		///   <para>Rotates the transform so the forward vector points at worldPosition.</para>
		/// </summary>
		/// <param name="worldPosition">Point to look at.</param>
		/// <param name="worldUp">Vector specifying the upward direction.</param>
		// Token: 0x06000C53 RID: 3155 RVA: 0x000176F8 File Offset: 0x000158F8
		[ExcludeFromDocs]
		public void LookAt(Vector3 worldPosition)
		{
			Vector3 up = Vector3.up;
			Transform.INTERNAL_CALL_LookAt(this, ref worldPosition, ref up);
		}

		// Token: 0x06000C54 RID: 3156
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_LookAt(Transform self, ref Vector3 worldPosition, ref Vector3 worldUp);

		/// <summary>
		///   <para>Transforms direction from local space to world space.</para>
		/// </summary>
		/// <param name="direction"></param>
		// Token: 0x06000C55 RID: 3157 RVA: 0x00006511 File Offset: 0x00004711
		public Vector3 TransformDirection(Vector3 direction)
		{
			return Transform.INTERNAL_CALL_TransformDirection(this, ref direction);
		}

		// Token: 0x06000C56 RID: 3158
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_TransformDirection(Transform self, ref Vector3 direction);

		/// <summary>
		///   <para>Transforms direction x, y, z from local space to world space.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x06000C57 RID: 3159 RVA: 0x0000651B File Offset: 0x0000471B
		public Vector3 TransformDirection(float x, float y, float z)
		{
			return this.TransformDirection(new Vector3(x, y, z));
		}

		/// <summary>
		///   <para>Transforms a direction from world space to local space. The opposite of Transform.TransformDirection.</para>
		/// </summary>
		/// <param name="direction"></param>
		// Token: 0x06000C58 RID: 3160 RVA: 0x0000652B File Offset: 0x0000472B
		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return Transform.INTERNAL_CALL_InverseTransformDirection(this, ref direction);
		}

		// Token: 0x06000C59 RID: 3161
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_InverseTransformDirection(Transform self, ref Vector3 direction);

		/// <summary>
		///   <para>Transforms the direction x, y, z from world space to local space. The opposite of Transform.TransformDirection.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x06000C5A RID: 3162 RVA: 0x00006535 File Offset: 0x00004735
		public Vector3 InverseTransformDirection(float x, float y, float z)
		{
			return this.InverseTransformDirection(new Vector3(x, y, z));
		}

		/// <summary>
		///   <para>Transforms vector from local space to world space.</para>
		/// </summary>
		/// <param name="vector"></param>
		// Token: 0x06000C5B RID: 3163 RVA: 0x00006545 File Offset: 0x00004745
		public Vector3 TransformVector(Vector3 vector)
		{
			return Transform.INTERNAL_CALL_TransformVector(this, ref vector);
		}

		// Token: 0x06000C5C RID: 3164
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_TransformVector(Transform self, ref Vector3 vector);

		/// <summary>
		///   <para>Transforms vector x, y, z from local space to world space.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x06000C5D RID: 3165 RVA: 0x0000654F File Offset: 0x0000474F
		public Vector3 TransformVector(float x, float y, float z)
		{
			return this.TransformVector(new Vector3(x, y, z));
		}

		/// <summary>
		///   <para>Transforms a vector from world space to local space. The opposite of Transform.TransformVector.</para>
		/// </summary>
		/// <param name="vector"></param>
		// Token: 0x06000C5E RID: 3166 RVA: 0x0000655F File Offset: 0x0000475F
		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return Transform.INTERNAL_CALL_InverseTransformVector(this, ref vector);
		}

		// Token: 0x06000C5F RID: 3167
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_InverseTransformVector(Transform self, ref Vector3 vector);

		/// <summary>
		///   <para>Transforms the vector x, y, z from world space to local space. The opposite of Transform.TransformVector.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x06000C60 RID: 3168 RVA: 0x00006569 File Offset: 0x00004769
		public Vector3 InverseTransformVector(float x, float y, float z)
		{
			return this.InverseTransformVector(new Vector3(x, y, z));
		}

		/// <summary>
		///   <para>Transforms position from local space to world space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000C61 RID: 3169 RVA: 0x00006579 File Offset: 0x00004779
		public Vector3 TransformPoint(Vector3 position)
		{
			return Transform.INTERNAL_CALL_TransformPoint(this, ref position);
		}

		// Token: 0x06000C62 RID: 3170
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_TransformPoint(Transform self, ref Vector3 position);

		/// <summary>
		///   <para>Transforms the position x, y, z from local space to world space.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x06000C63 RID: 3171 RVA: 0x00006583 File Offset: 0x00004783
		public Vector3 TransformPoint(float x, float y, float z)
		{
			return this.TransformPoint(new Vector3(x, y, z));
		}

		/// <summary>
		///   <para>Transforms position from world space to local space.</para>
		/// </summary>
		/// <param name="position"></param>
		// Token: 0x06000C64 RID: 3172 RVA: 0x00006593 File Offset: 0x00004793
		public Vector3 InverseTransformPoint(Vector3 position)
		{
			return Transform.INTERNAL_CALL_InverseTransformPoint(this, ref position);
		}

		// Token: 0x06000C65 RID: 3173
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Vector3 INTERNAL_CALL_InverseTransformPoint(Transform self, ref Vector3 position);

		/// <summary>
		///   <para>Transforms the position x, y, z from world space to local space. The opposite of Transform.TransformPoint.</para>
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		// Token: 0x06000C66 RID: 3174 RVA: 0x0000659D File Offset: 0x0000479D
		public Vector3 InverseTransformPoint(float x, float y, float z)
		{
			return this.InverseTransformPoint(new Vector3(x, y, z));
		}

		/// <summary>
		///   <para>Returns the topmost transform in the hierarchy.</para>
		/// </summary>
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000C67 RID: 3175
		public extern Transform root
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The number of children the Transform has.</para>
		/// </summary>
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000C68 RID: 3176
		public extern int childCount
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Unparents all children.</para>
		/// </summary>
		// Token: 0x06000C69 RID: 3177
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void DetachChildren();

		/// <summary>
		///   <para>Move the transform to the start of the local transform list.</para>
		/// </summary>
		// Token: 0x06000C6A RID: 3178
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAsFirstSibling();

		/// <summary>
		///   <para>Move the transform to the end of the local transform list.</para>
		/// </summary>
		// Token: 0x06000C6B RID: 3179
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAsLastSibling();

		/// <summary>
		///   <para>Sets the sibling index.</para>
		/// </summary>
		/// <param name="index">Index to set.</param>
		// Token: 0x06000C6C RID: 3180
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetSiblingIndex(int index);

		/// <summary>
		///   <para>Gets the sibling index.</para>
		/// </summary>
		// Token: 0x06000C6D RID: 3181
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetSiblingIndex();

		/// <summary>
		///   <para>Finds a child by name and returns it.</para>
		/// </summary>
		/// <param name="name">Name of child to be found.</param>
		// Token: 0x06000C6E RID: 3182
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Transform Find(string name);

		/// <summary>
		///   <para>The global scale of the object (Read Only).</para>
		/// </summary>
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000C6F RID: 3183 RVA: 0x00017718 File Offset: 0x00015918
		public Vector3 lossyScale
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_lossyScale(out vector);
				return vector;
			}
		}

		// Token: 0x06000C70 RID: 3184
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_lossyScale(out Vector3 value);

		/// <summary>
		///   <para>Is this transform a child of parent?</para>
		/// </summary>
		/// <param name="parent"></param>
		// Token: 0x06000C71 RID: 3185
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool IsChildOf(Transform parent);

		/// <summary>
		///   <para>Has the transform changed since the last time the flag was set to 'false'?</para>
		/// </summary>
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000C72 RID: 3186
		// (set) Token: 0x06000C73 RID: 3187
		public extern bool hasChanged
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x000065AD File Offset: 0x000047AD
		public Transform FindChild(string name)
		{
			return this.Find(name);
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x000065B6 File Offset: 0x000047B6
		public IEnumerator GetEnumerator()
		{
			return new Transform.Enumerator(this);
		}

		/// <summary>
		///   <para></para>
		/// </summary>
		/// <param name="axis"></param>
		/// <param name="angle"></param>
		// Token: 0x06000C76 RID: 3190 RVA: 0x000065BE File Offset: 0x000047BE
		[Obsolete("use Transform.Rotate instead.")]
		public void RotateAround(Vector3 axis, float angle)
		{
			Transform.INTERNAL_CALL_RotateAround(this, ref axis, angle);
		}

		// Token: 0x06000C77 RID: 3191
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RotateAround(Transform self, ref Vector3 axis, float angle);

		// Token: 0x06000C78 RID: 3192 RVA: 0x000065C9 File Offset: 0x000047C9
		[Obsolete("use Transform.Rotate instead.")]
		public void RotateAroundLocal(Vector3 axis, float angle)
		{
			Transform.INTERNAL_CALL_RotateAroundLocal(this, ref axis, angle);
		}

		// Token: 0x06000C79 RID: 3193
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_RotateAroundLocal(Transform self, ref Vector3 axis, float angle);

		/// <summary>
		///   <para>Returns a transform child by index.</para>
		/// </summary>
		/// <param name="index">Index of the child transform to return. Must be smaller than Transform.childCount.</param>
		/// <returns>
		///   <para>Transform child by index.</para>
		/// </returns>
		// Token: 0x06000C7A RID: 3194
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Transform GetChild(int index);

		// Token: 0x06000C7B RID: 3195
		[WrapperlessIcall]
		[Obsolete("use Transform.childCount instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int GetChildCount();

		// Token: 0x020000CB RID: 203
		private sealed class Enumerator : IEnumerator
		{
			// Token: 0x06000C7C RID: 3196 RVA: 0x000065D4 File Offset: 0x000047D4
			internal Enumerator(Transform outer)
			{
				this.outer = outer;
			}

			// Token: 0x17000302 RID: 770
			// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000065EA File Offset: 0x000047EA
			public object Current
			{
				get
				{
					return this.outer.GetChild(this.currentIndex);
				}
			}

			// Token: 0x06000C7E RID: 3198 RVA: 0x00017730 File Offset: 0x00015930
			public bool MoveNext()
			{
				int childCount = this.outer.childCount;
				return ++this.currentIndex < childCount;
			}

			// Token: 0x06000C7F RID: 3199 RVA: 0x000065FD File Offset: 0x000047FD
			public void Reset()
			{
				this.currentIndex = -1;
			}

			// Token: 0x0400025C RID: 604
			private Transform outer;

			// Token: 0x0400025D RID: 605
			private int currentIndex = -1;
		}
	}
}
