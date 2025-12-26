using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>ControllerColliderHit is used by CharacterController.OnControllerColliderHit to give detailed information about the collision and how to deal with it.</para>
	/// </summary>
	// Token: 0x020000FB RID: 251
	[StructLayout(LayoutKind.Sequential)]
	public class ControllerColliderHit
	{
		/// <summary>
		///   <para>The controller that hit the collider.</para>
		/// </summary>
		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000E71 RID: 3697 RVA: 0x00006D31 File Offset: 0x00004F31
		public CharacterController controller
		{
			get
			{
				return this.m_Controller;
			}
		}

		/// <summary>
		///   <para>The collider that was hit by the controller.</para>
		/// </summary>
		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x00006D39 File Offset: 0x00004F39
		public Collider collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		/// <summary>
		///   <para>The rigidbody that was hit by the controller.</para>
		/// </summary>
		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000E73 RID: 3699 RVA: 0x00006D41 File Offset: 0x00004F41
		public Rigidbody rigidbody
		{
			get
			{
				return this.m_Collider.attachedRigidbody;
			}
		}

		/// <summary>
		///   <para>The game object that was hit by the controller.</para>
		/// </summary>
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x00006D4E File Offset: 0x00004F4E
		public GameObject gameObject
		{
			get
			{
				return this.m_Collider.gameObject;
			}
		}

		/// <summary>
		///   <para>The transform that was hit by the controller.</para>
		/// </summary>
		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x00006D5B File Offset: 0x00004F5B
		public Transform transform
		{
			get
			{
				return this.m_Collider.transform;
			}
		}

		/// <summary>
		///   <para>The impact point in world space.</para>
		/// </summary>
		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x00006D68 File Offset: 0x00004F68
		public Vector3 point
		{
			get
			{
				return this.m_Point;
			}
		}

		/// <summary>
		///   <para>The normal of the surface we collided with in world space.</para>
		/// </summary>
		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x00006D70 File Offset: 0x00004F70
		public Vector3 normal
		{
			get
			{
				return this.m_Normal;
			}
		}

		/// <summary>
		///   <para>The direction the CharacterController was moving in when the collision occured.</para>
		/// </summary>
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00006D78 File Offset: 0x00004F78
		public Vector3 moveDirection
		{
			get
			{
				return this.m_MoveDirection;
			}
		}

		/// <summary>
		///   <para>How far the character has travelled until it hit the collider.</para>
		/// </summary>
		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00006D80 File Offset: 0x00004F80
		public float moveLength
		{
			get
			{
				return this.m_MoveLength;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00006D88 File Offset: 0x00004F88
		// (set) Token: 0x06000E7B RID: 3707 RVA: 0x00006D96 File Offset: 0x00004F96
		private bool push
		{
			get
			{
				return this.m_Push != 0;
			}
			set
			{
				this.m_Push = ((!value) ? 0 : 1);
			}
		}

		// Token: 0x040002E5 RID: 741
		internal CharacterController m_Controller;

		// Token: 0x040002E6 RID: 742
		internal Collider m_Collider;

		// Token: 0x040002E7 RID: 743
		internal Vector3 m_Point;

		// Token: 0x040002E8 RID: 744
		internal Vector3 m_Normal;

		// Token: 0x040002E9 RID: 745
		internal Vector3 m_MoveDirection;

		// Token: 0x040002EA RID: 746
		internal float m_MoveLength;

		// Token: 0x040002EB RID: 747
		internal int m_Push;
	}
}
