using System;
using System.Runtime.InteropServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Information returned by a collision in 2D physics.</para>
	/// </summary>
	// Token: 0x02000129 RID: 297
	[StructLayout(LayoutKind.Sequential)]
	public class Collision2D
	{
		/// <summary>
		///   <para>Whether the collision was disabled or not.</para>
		/// </summary>
		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00007865 File Offset: 0x00005A65
		public bool enabled
		{
			get
			{
				return this.m_Enabled;
			}
		}

		/// <summary>
		///   <para>The incoming Rigidbody2D involved in the collision.</para>
		/// </summary>
		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x0000786D File Offset: 0x00005A6D
		public Rigidbody2D rigidbody
		{
			get
			{
				return this.m_Rigidbody;
			}
		}

		/// <summary>
		///   <para>The incoming Collider2D involved in the collision.</para>
		/// </summary>
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00007875 File Offset: 0x00005A75
		public Collider2D collider
		{
			get
			{
				return this.m_Collider;
			}
		}

		/// <summary>
		///   <para>The Transform of the incoming object involved in the collision.</para>
		/// </summary>
		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x0000787D File Offset: 0x00005A7D
		public Transform transform
		{
			get
			{
				return (!(this.rigidbody != null)) ? this.collider.transform : this.rigidbody.transform;
			}
		}

		/// <summary>
		///   <para>The incoming GameObject involved in the collision.</para>
		/// </summary>
		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x0600127F RID: 4735 RVA: 0x000078AB File Offset: 0x00005AAB
		public GameObject gameObject
		{
			get
			{
				return (!(this.m_Rigidbody != null)) ? this.m_Collider.gameObject : this.m_Rigidbody.gameObject;
			}
		}

		/// <summary>
		///   <para>The specific points of contact with the incoming Collider2D.</para>
		/// </summary>
		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001280 RID: 4736 RVA: 0x000078D9 File Offset: 0x00005AD9
		public ContactPoint2D[] contacts
		{
			get
			{
				return this.m_Contacts;
			}
		}

		/// <summary>
		///   <para>The relative linear velocity of the two colliding objects (Read Only).</para>
		/// </summary>
		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001281 RID: 4737 RVA: 0x000078E1 File Offset: 0x00005AE1
		public Vector2 relativeVelocity
		{
			get
			{
				return this.m_RelativeVelocity;
			}
		}

		// Token: 0x04000354 RID: 852
		internal Rigidbody2D m_Rigidbody;

		// Token: 0x04000355 RID: 853
		internal Collider2D m_Collider;

		// Token: 0x04000356 RID: 854
		internal ContactPoint2D[] m_Contacts;

		// Token: 0x04000357 RID: 855
		internal Vector2 m_RelativeVelocity;

		// Token: 0x04000358 RID: 856
		internal bool m_Enabled;
	}
}
