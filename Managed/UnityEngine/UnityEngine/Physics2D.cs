using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Internal;

namespace UnityEngine
{
	/// <summary>
	///   <para>Global settings and helpers for 2D physics.</para>
	/// </summary>
	// Token: 0x0200011A RID: 282
	public class Physics2D
	{
		/// <summary>
		///   <para>The number of iterations of the physics solver when considering objects' velocities.</para>
		/// </summary>
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001132 RID: 4402
		// (set) Token: 0x06001133 RID: 4403
		public static extern int velocityIterations
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The number of iterations of the physics solver when considering objects' positions.</para>
		/// </summary>
		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001134 RID: 4404
		// (set) Token: 0x06001135 RID: 4405
		public static extern int positionIterations
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Acceleration due to gravity.</para>
		/// </summary>
		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x00018FFC File Offset: 0x000171FC
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x00007584 File Offset: 0x00005784
		public static Vector2 gravity
		{
			get
			{
				Vector2 vector;
				Physics2D.INTERNAL_get_gravity(out vector);
				return vector;
			}
			set
			{
				Physics2D.INTERNAL_set_gravity(ref value);
			}
		}

		// Token: 0x06001138 RID: 4408
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_get_gravity(out Vector2 value);

		// Token: 0x06001139 RID: 4409
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_set_gravity(ref Vector2 value);

		/// <summary>
		///   <para>Do raycasts detect Colliders configured as triggers?</para>
		/// </summary>
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x0600113A RID: 4410
		// (set) Token: 0x0600113B RID: 4411
		public static extern bool queriesHitTriggers
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Do ray/line casts that start inside a collider(s) detect those collider(s)?</para>
		/// </summary>
		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x0600113C RID: 4412
		// (set) Token: 0x0600113D RID: 4413
		public static extern bool queriesStartInColliders
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Whether or not to stop reporting collision callbacks immediately if any of the objects involved in the collision are deleted/moved. </para>
		/// </summary>
		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x0600113E RID: 4414
		// (set) Token: 0x0600113F RID: 4415
		public static extern bool changeStopsCallbacks
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Any collisions with a relative linear velocity below this threshold will be treated as inelastic.</para>
		/// </summary>
		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001140 RID: 4416
		// (set) Token: 0x06001141 RID: 4417
		public static extern float velocityThreshold
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum linear position correction used when solving constraints.  This helps to prevent overshoot.</para>
		/// </summary>
		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001142 RID: 4418
		// (set) Token: 0x06001143 RID: 4419
		public static extern float maxLinearCorrection
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum angular position correction used when solving constraints.  This helps to prevent overshoot.</para>
		/// </summary>
		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001144 RID: 4420
		// (set) Token: 0x06001145 RID: 4421
		public static extern float maxAngularCorrection
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum linear speed of a rigid-body per physics update.  Increasing this can cause numerical problems.</para>
		/// </summary>
		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001146 RID: 4422
		// (set) Token: 0x06001147 RID: 4423
		public static extern float maxTranslationSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum angular speed of a rigid-body per physics update.  Increasing this can cause numerical problems.</para>
		/// </summary>
		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001148 RID: 4424
		// (set) Token: 0x06001149 RID: 4425
		public static extern float maxRotationSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The minimum contact penetration radius allowed before any separation impulse force is applied.  Extreme caution should be used when modifying this value as making this smaller means that polygons will have an insufficient buffer for continuous collision and making it larger may create artefacts for vertex collision.</para>
		/// </summary>
		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x0600114A RID: 4426
		// (set) Token: 0x0600114B RID: 4427
		public static extern float minPenetrationForPenalty
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The scale factor that controls how fast overlaps are resolved.</para>
		/// </summary>
		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600114C RID: 4428
		// (set) Token: 0x0600114D RID: 4429
		public static extern float baumgarteScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The scale factor that controls how fast TOI overlaps are resolved.</para>
		/// </summary>
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600114E RID: 4430
		// (set) Token: 0x0600114F RID: 4431
		public static extern float baumgarteTOIScale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The time in seconds that a rigid-body must be still before it will go to sleep.</para>
		/// </summary>
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001150 RID: 4432
		// (set) Token: 0x06001151 RID: 4433
		public static extern float timeToSleep
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A rigid-body cannot sleep if its linear velocity is above this tolerance.</para>
		/// </summary>
		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001152 RID: 4434
		// (set) Token: 0x06001153 RID: 4435
		public static extern float linearSleepTolerance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>A rigid-body cannot sleep if its angular velocity is above this tolerance.</para>
		/// </summary>
		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001154 RID: 4436
		// (set) Token: 0x06001155 RID: 4437
		public static extern float angularSleepTolerance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Makes the collision detection system ignore all collisionstriggers between collider1 and collider2/.</para>
		/// </summary>
		/// <param name="collider1">The first collider to compare to collider2.</param>
		/// <param name="collider2">The second collider to compare to collider1.</param>
		/// <param name="ignore">Whether collisionstriggers between collider1 and collider2/ should be ignored or not.</param>
		// Token: 0x06001156 RID: 4438
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IgnoreCollision(Collider2D collider1, Collider2D collider2, [DefaultValue("true")] bool ignore);

		// Token: 0x06001157 RID: 4439 RVA: 0x00019014 File Offset: 0x00017214
		[ExcludeFromDocs]
		public static void IgnoreCollision(Collider2D collider1, Collider2D collider2)
		{
			bool flag = true;
			Physics2D.IgnoreCollision(collider1, collider2, flag);
		}

		/// <summary>
		///   <para>Checks whether the collision detection system will ignore all collisionstriggers between collider1 and collider2/ or not.</para>
		/// </summary>
		/// <param name="collider1">The first collider to compare to collider2.</param>
		/// <param name="collider2">The second collider to compare to collider1.</param>
		// Token: 0x06001158 RID: 4440
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetIgnoreCollision(Collider2D collider1, Collider2D collider2);

		/// <summary>
		///   <para>Choose whether to detect or ignore collisions between a specified pair of layers.</para>
		/// </summary>
		/// <param name="layer1">ID of the first layer.</param>
		/// <param name="layer2">ID of the second layer.</param>
		/// <param name="ignore">Should collisions between these layers be ignored?</param>
		// Token: 0x06001159 RID: 4441
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void IgnoreLayerCollision(int layer1, int layer2, [DefaultValue("true")] bool ignore);

		// Token: 0x0600115A RID: 4442 RVA: 0x0001902C File Offset: 0x0001722C
		[ExcludeFromDocs]
		public static void IgnoreLayerCollision(int layer1, int layer2)
		{
			bool flag = true;
			Physics2D.IgnoreLayerCollision(layer1, layer2, flag);
		}

		/// <summary>
		///   <para>Should collisions between the specified layers be ignored?</para>
		/// </summary>
		/// <param name="layer1">ID of first layer.</param>
		/// <param name="layer2">ID of second layer.</param>
		// Token: 0x0600115B RID: 4443
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetIgnoreLayerCollision(int layer1, int layer2);

		/// <summary>
		///   <para>Check whether collider1 is touching collider2 or not.</para>
		/// </summary>
		/// <param name="collider1">The collider to check if it is touching collider2.</param>
		/// <param name="collider2">The collider to check if it is touching collider1.</param>
		/// <returns>
		///   <para>Whether collider1 is touching collider2 or not.</para>
		/// </returns>
		// Token: 0x0600115C RID: 4444
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTouching(Collider2D collider1, Collider2D collider2);

		/// <summary>
		///   <para>Checks whether the collider is touching any colliders on the specified layerMask or not.</para>
		/// </summary>
		/// <param name="collider">The collider to check if it is touching colliders on the layerMask.</param>
		/// <param name="layerMask">Any colliders on any of these layers count as touching.</param>
		/// <returns>
		///   <para>Whether the collider is touching any colliders on the specified layerMask or not.</para>
		/// </returns>
		// Token: 0x0600115D RID: 4445
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsTouchingLayers(Collider2D collider, [DefaultValue("AllLayers")] int layerMask);

		// Token: 0x0600115E RID: 4446 RVA: 0x00019044 File Offset: 0x00017244
		[ExcludeFromDocs]
		public static bool IsTouchingLayers(Collider2D collider)
		{
			int num = -1;
			return Physics2D.IsTouchingLayers(collider, num);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x0001905C File Offset: 0x0001725C
		internal static void SetEditorDragMovement(bool dragging, GameObject[] objs)
		{
			foreach (Rigidbody2D rigidbody2D in Physics2D.m_LastDisabledRigidbody2D)
			{
				if (rigidbody2D != null)
				{
					rigidbody2D.isKinematic = false;
				}
			}
			Physics2D.m_LastDisabledRigidbody2D.Clear();
			if (!dragging)
			{
				return;
			}
			foreach (GameObject gameObject in objs)
			{
				Rigidbody2D[] componentsInChildren = gameObject.GetComponentsInChildren<Rigidbody2D>(false);
				foreach (Rigidbody2D rigidbody2D2 in componentsInChildren)
				{
					if (!rigidbody2D2.isKinematic)
					{
						rigidbody2D2.isKinematic = true;
						Physics2D.m_LastDisabledRigidbody2D.Add(rigidbody2D2);
					}
				}
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0000758D File Offset: 0x0000578D
		private static void Internal_Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_Linecast(ref start, ref end, layerMask, minDepth, maxDepth, out raycastHit);
		}

		// Token: 0x06001161 RID: 4449
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Linecast(ref Vector2 start, ref Vector2 end, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit);

		// Token: 0x06001162 RID: 4450 RVA: 0x00019140 File Offset: 0x00017340
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.Linecast(start, end, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00019160 File Offset: 0x00017360
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.Linecast(start, end, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00019184 File Offset: 0x00017384
		[ExcludeFromDocs]
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.Linecast(start, end, num, negativeInfinity, positiveInfinity);
		}

		/// <summary>
		///   <para>Casts a line against colliders in the scene.</para>
		/// </summary>
		/// <param name="start">The start point of the line in world space.</param>
		/// <param name="end">The end point of the line in world space.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x06001165 RID: 4453 RVA: 0x000191AC File Offset: 0x000173AC
		public static RaycastHit2D Linecast(Vector2 start, Vector2 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			RaycastHit2D raycastHit2D;
			Physics2D.Internal_Linecast(start, end, layerMask, minDepth, maxDepth, out raycastHit2D);
			return raycastHit2D;
		}

		/// <summary>
		///   <para>Casts a line against colliders in the scene.</para>
		/// </summary>
		/// <param name="start">The start point of the line in world space.</param>
		/// <param name="end">The end point of the line in world space.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x06001166 RID: 4454 RVA: 0x0000759E File Offset: 0x0000579E
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_LinecastAll(ref start, ref end, layerMask, minDepth, maxDepth);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x000191C8 File Offset: 0x000173C8
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_LinecastAll(ref start, ref end, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000191E8 File Offset: 0x000173E8
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_LinecastAll(ref start, ref end, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00019210 File Offset: 0x00017410
		[ExcludeFromDocs]
		public static RaycastHit2D[] LinecastAll(Vector2 start, Vector2 end)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_LinecastAll(ref start, ref end, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600116A RID: 4458
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_LinecastAll(ref Vector2 start, ref Vector2 end, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Casts a line against colliders in the scene.</para>
		/// </summary>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <param name="start">The start point of the line in world space.</param>
		/// <param name="end">The end point of the line in world space.</param>
		/// <param name="results">Returned array of objects that intersect the line.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x0600116B RID: 4459 RVA: 0x000075AD File Offset: 0x000057AD
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_LinecastNonAlloc(ref start, ref end, results, layerMask, minDepth, maxDepth);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00019238 File Offset: 0x00017438
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_LinecastNonAlloc(ref start, ref end, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x0001925C File Offset: 0x0001745C
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_LinecastNonAlloc(ref start, ref end, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00019284 File Offset: 0x00017484
		[ExcludeFromDocs]
		public static int LinecastNonAlloc(Vector2 start, Vector2 end, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_LinecastNonAlloc(ref start, ref end, results, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600116F RID: 4463
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_LinecastNonAlloc(ref Vector2 start, ref Vector2 end, RaycastHit2D[] results, int layerMask, float minDepth, float maxDepth);

		// Token: 0x06001170 RID: 4464 RVA: 0x000075BE File Offset: 0x000057BE
		private static void Internal_Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_Raycast(ref origin, ref direction, distance, layerMask, minDepth, maxDepth, out raycastHit);
		}

		// Token: 0x06001171 RID: 4465
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_Raycast(ref Vector2 origin, ref Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit);

		// Token: 0x06001172 RID: 4466 RVA: 0x000192B0 File Offset: 0x000174B0
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.Raycast(origin, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000192D0 File Offset: 0x000174D0
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.Raycast(origin, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000192F4 File Offset: 0x000174F4
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.Raycast(origin, direction, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x0001931C File Offset: 0x0001751C
		[ExcludeFromDocs]
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.Raycast(origin, direction, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		/// <summary>
		///   <para>Casts a ray against colliders in the scene.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the ray originates.</param>
		/// <param name="direction">Vector representing the direction of the ray.</param>
		/// <param name="distance">Maximum distance over which to cast the ray.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x06001176 RID: 4470 RVA: 0x0001934C File Offset: 0x0001754C
		public static RaycastHit2D Raycast(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			RaycastHit2D raycastHit2D;
			Physics2D.Internal_Raycast(origin, direction, distance, layerMask, minDepth, maxDepth, out raycastHit2D);
			return raycastHit2D;
		}

		/// <summary>
		///   <para>Casts a ray against colliders in the scene, returning all colliders that contact with it.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the ray originates.</param>
		/// <param name="direction">Vector representing the direction of the ray.</param>
		/// <param name="distance">Maximum distance over which to cast the ray.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x06001177 RID: 4471 RVA: 0x000075D1 File Offset: 0x000057D1
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_RaycastAll(ref origin, ref direction, distance, layerMask, minDepth, maxDepth);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x0001936C File Offset: 0x0001756C
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_RaycastAll(ref origin, ref direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00019390 File Offset: 0x00017590
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_RaycastAll(ref origin, ref direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x000193B8 File Offset: 0x000175B8
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_RaycastAll(ref origin, ref direction, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x000193E4 File Offset: 0x000175E4
		[ExcludeFromDocs]
		public static RaycastHit2D[] RaycastAll(Vector2 origin, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_RaycastAll(ref origin, ref direction, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600117C RID: 4476
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_RaycastAll(ref Vector2 origin, ref Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Casts a ray into the scene.</para>
		/// </summary>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <param name="origin">The point in 2D space where the ray originates.</param>
		/// <param name="direction">Vector representing the direction of the ray.</param>
		/// <param name="results">Array to receive results.</param>
		/// <param name="distance">Maximum distance over which to cast the ray.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x0600117D RID: 4477 RVA: 0x000075E2 File Offset: 0x000057E2
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, distance, layerMask, minDepth, maxDepth);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00019414 File Offset: 0x00017614
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00019438 File Offset: 0x00017638
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00019460 File Offset: 0x00017660
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x0001948C File Offset: 0x0001768C
		[ExcludeFromDocs]
		public static int RaycastNonAlloc(Vector2 origin, Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_RaycastNonAlloc(ref origin, ref direction, results, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001182 RID: 4482
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_RaycastNonAlloc(ref Vector2 origin, ref Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);

		// Token: 0x06001183 RID: 4483 RVA: 0x000075F5 File Offset: 0x000057F5
		private static void Internal_CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_CircleCast(ref origin, radius, ref direction, distance, layerMask, minDepth, maxDepth, out raycastHit);
		}

		// Token: 0x06001184 RID: 4484
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_CircleCast(ref Vector2 origin, float radius, ref Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit);

		// Token: 0x06001185 RID: 4485 RVA: 0x000194BC File Offset: 0x000176BC
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.CircleCast(origin, radius, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x000194E0 File Offset: 0x000176E0
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.CircleCast(origin, radius, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x00019508 File Offset: 0x00017708
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.CircleCast(origin, radius, direction, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x00019530 File Offset: 0x00017730
		[ExcludeFromDocs]
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.CircleCast(origin, radius, direction, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		/// <summary>
		///   <para>Casts a circle against colliders in the scene, returning the first collider to contact with it.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the shape originates.</param>
		/// <param name="radius">The radius of the shape.</param>
		/// <param name="direction">Vector representing the direction of the shape.</param>
		/// <param name="distance">Maximum distance over which to cast the shape.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x06001189 RID: 4489 RVA: 0x00019560 File Offset: 0x00017760
		public static RaycastHit2D CircleCast(Vector2 origin, float radius, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			RaycastHit2D raycastHit2D;
			Physics2D.Internal_CircleCast(origin, radius, direction, distance, layerMask, minDepth, maxDepth, out raycastHit2D);
			return raycastHit2D;
		}

		/// <summary>
		///   <para>Casts a circle against colliders in the scene, returning all colliders that contact with it.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the shape originates.</param>
		/// <param name="radius">The radius of the shape.</param>
		/// <param name="direction">Vector representing the direction of the shape.</param>
		/// <param name="distance">Maximum distance over which to cast the shape.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x0600118A RID: 4490 RVA: 0x0000760A File Offset: 0x0000580A
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_CircleCastAll(ref origin, radius, ref direction, distance, layerMask, minDepth, maxDepth);
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00019580 File Offset: 0x00017780
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_CircleCastAll(ref origin, radius, ref direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x000195A4 File Offset: 0x000177A4
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_CircleCastAll(ref origin, radius, ref direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000195CC File Offset: 0x000177CC
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_CircleCastAll(ref origin, radius, ref direction, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000195F8 File Offset: 0x000177F8
		[ExcludeFromDocs]
		public static RaycastHit2D[] CircleCastAll(Vector2 origin, float radius, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_CircleCastAll(ref origin, radius, ref direction, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600118F RID: 4495
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_CircleCastAll(ref Vector2 origin, float radius, ref Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Casts a circle into the scene, returning colliders that contact with it into the provided results array.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the shape originates.</param>
		/// <param name="radius">The radius of the shape.</param>
		/// <param name="direction">Vector representing the direction of the shape.</param>
		/// <param name="results">Array to receive results.</param>
		/// <param name="distance">Maximum distance over which to cast the shape.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x06001190 RID: 4496 RVA: 0x0000761D File Offset: 0x0000581D
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_CircleCastNonAlloc(ref origin, radius, ref direction, results, distance, layerMask, minDepth, maxDepth);
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00019628 File Offset: 0x00017828
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_CircleCastNonAlloc(ref origin, radius, ref direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x00019650 File Offset: 0x00017850
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_CircleCastNonAlloc(ref origin, radius, ref direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x0001967C File Offset: 0x0001787C
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_CircleCastNonAlloc(ref origin, radius, ref direction, results, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x000196A8 File Offset: 0x000178A8
		[ExcludeFromDocs]
		public static int CircleCastNonAlloc(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_CircleCastNonAlloc(ref origin, radius, ref direction, results, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x06001195 RID: 4501
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_CircleCastNonAlloc(ref Vector2 origin, float radius, ref Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);

		// Token: 0x06001196 RID: 4502 RVA: 0x000196DC File Offset: 0x000178DC
		private static void Internal_BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_BoxCast(ref origin, ref size, angle, ref direction, distance, layerMask, minDepth, maxDepth, out raycastHit);
		}

		// Token: 0x06001197 RID: 4503
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_BoxCast(ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth, out RaycastHit2D raycastHit);

		// Token: 0x06001198 RID: 4504 RVA: 0x00019700 File Offset: 0x00017900
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.BoxCast(origin, size, angle, direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00019724 File Offset: 0x00017924
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.BoxCast(origin, size, angle, direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x0001974C File Offset: 0x0001794C
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.BoxCast(origin, size, angle, direction, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00019778 File Offset: 0x00017978
		[ExcludeFromDocs]
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.BoxCast(origin, size, angle, direction, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		/// <summary>
		///   <para>Casts a box against colliders in the scene, returning the first collider to contact with it.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the shape originates.</param>
		/// <param name="size">The size of the shape.</param>
		/// <param name="angle">The angle of the shape (in degrees).</param>
		/// <param name="direction">Vector representing the direction of the shape.</param>
		/// <param name="distance">Maximum distance over which to cast the shape.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x0600119C RID: 4508 RVA: 0x000197A8 File Offset: 0x000179A8
		public static RaycastHit2D BoxCast(Vector2 origin, Vector2 size, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			RaycastHit2D raycastHit2D;
			Physics2D.Internal_BoxCast(origin, size, angle, direction, distance, layerMask, minDepth, maxDepth, out raycastHit2D);
			return raycastHit2D;
		}

		/// <summary>
		///   <para>Casts a box against colliders in the scene, returning all colliders that contact with it.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the shape originates.</param>
		/// <param name="size">The size of the shape.</param>
		/// <param name="angle">The angle of the shape (in degrees).</param>
		/// <param name="direction">Vector representing the direction of the shape.</param>
		/// <param name="distance">Maximum distance over which to cast the shape.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x0600119D RID: 4509 RVA: 0x00007632 File Offset: 0x00005832
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_BoxCastAll(ref origin, ref size, angle, ref direction, distance, layerMask, minDepth, maxDepth);
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000197CC File Offset: 0x000179CC
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_BoxCastAll(ref origin, ref size, angle, ref direction, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000197F4 File Offset: 0x000179F4
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_BoxCastAll(ref origin, ref size, angle, ref direction, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00019820 File Offset: 0x00017A20
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_BoxCastAll(ref origin, ref size, angle, ref direction, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00019850 File Offset: 0x00017A50
		[ExcludeFromDocs]
		public static RaycastHit2D[] BoxCastAll(Vector2 origin, Vector2 size, float angle, Vector2 direction)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_BoxCastAll(ref origin, ref size, angle, ref direction, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011A2 RID: 4514
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_BoxCastAll(ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, float distance, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Casts a box into the scene, returning colliders that contact with it into the provided results array.</para>
		/// </summary>
		/// <param name="origin">The point in 2D space where the shape originates.</param>
		/// <param name="size">The size of the shape.</param>
		/// <param name="angle">The angle of the shape (in degrees).</param>
		/// <param name="direction">Vector representing the direction of the shape.</param>
		/// <param name="results">Array to receive results.</param>
		/// <param name="distance">Maximum distance over which to cast the shape.</param>
		/// <param name="layerMask">Filter to detect Colliders only on certain layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x060011A3 RID: 4515 RVA: 0x00019884 File Offset: 0x00017A84
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_BoxCastNonAlloc(ref origin, ref size, angle, ref direction, results, distance, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000198A8 File Offset: 0x00017AA8
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_BoxCastNonAlloc(ref origin, ref size, angle, ref direction, results, distance, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x000198D0 File Offset: 0x00017AD0
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_BoxCastNonAlloc(ref origin, ref size, angle, ref direction, results, distance, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x00019900 File Offset: 0x00017B00
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results, float distance)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_BoxCastNonAlloc(ref origin, ref size, angle, ref direction, results, distance, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00019930 File Offset: 0x00017B30
		[ExcludeFromDocs]
		public static int BoxCastNonAlloc(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			float positiveInfinity2 = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_BoxCastNonAlloc(ref origin, ref size, angle, ref direction, results, positiveInfinity2, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011A8 RID: 4520
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_BoxCastNonAlloc(ref Vector2 origin, ref Vector2 size, float angle, ref Vector2 direction, RaycastHit2D[] results, float distance, int layerMask, float minDepth, float maxDepth);

		// Token: 0x060011A9 RID: 4521 RVA: 0x00007648 File Offset: 0x00005848
		private static void Internal_GetRayIntersection(Ray ray, float distance, int layerMask, out RaycastHit2D raycastHit)
		{
			Physics2D.INTERNAL_CALL_Internal_GetRayIntersection(ref ray, distance, layerMask, out raycastHit);
		}

		// Token: 0x060011AA RID: 4522
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Internal_GetRayIntersection(ref Ray ray, float distance, int layerMask, out RaycastHit2D raycastHit);

		// Token: 0x060011AB RID: 4523 RVA: 0x00019964 File Offset: 0x00017B64
		[ExcludeFromDocs]
		public static RaycastHit2D GetRayIntersection(Ray ray, float distance)
		{
			int num = -5;
			return Physics2D.GetRayIntersection(ray, distance, num);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0001997C File Offset: 0x00017B7C
		[ExcludeFromDocs]
		public static RaycastHit2D GetRayIntersection(Ray ray)
		{
			int num = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.GetRayIntersection(ray, positiveInfinity, num);
		}

		/// <summary>
		///   <para>Cast a 3D ray against the colliders in the scene returning the first collider along the ray.</para>
		/// </summary>
		/// <param name="ray">The 3D ray defining origin and direction to test.</param>
		/// <param name="distance">Maximum distance over which to cast the ray.</param>
		/// <param name="layerMask">Filter to detect colliders only on certain layers.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x060011AD RID: 4525 RVA: 0x0001999C File Offset: 0x00017B9C
		public static RaycastHit2D GetRayIntersection(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			RaycastHit2D raycastHit2D;
			Physics2D.Internal_GetRayIntersection(ray, distance, layerMask, out raycastHit2D);
			return raycastHit2D;
		}

		/// <summary>
		///   <para>Cast a 3D ray against the colliders in the scene returning all the colliders along the ray.</para>
		/// </summary>
		/// <param name="ray">The 3D ray defining origin and direction to test.</param>
		/// <param name="distance">Maximum distance over which to cast the ray.</param>
		/// <param name="layerMask">Filter to detect colliders only on certain layers.</param>
		/// <returns>
		///   <para>The cast results returned.</para>
		/// </returns>
		// Token: 0x060011AE RID: 4526 RVA: 0x00007654 File Offset: 0x00005854
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return Physics2D.INTERNAL_CALL_GetRayIntersectionAll(ref ray, distance, layerMask);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000199B4 File Offset: 0x00017BB4
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray, float distance)
		{
			int num = -5;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionAll(ref ray, distance, num);
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x000199D0 File Offset: 0x00017BD0
		[ExcludeFromDocs]
		public static RaycastHit2D[] GetRayIntersectionAll(Ray ray)
		{
			int num = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionAll(ref ray, positiveInfinity, num);
		}

		// Token: 0x060011B1 RID: 4529
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern RaycastHit2D[] INTERNAL_CALL_GetRayIntersectionAll(ref Ray ray, float distance, int layerMask);

		/// <summary>
		///   <para>Cast a 3D ray against the colliders in the scene returning the colliders along the ray.</para>
		/// </summary>
		/// <param name="ray">The 3D ray defining origin and direction to test.</param>
		/// <param name="distance">Maximum distance over which to cast the ray.</param>
		/// <param name="layerMask">Filter to detect colliders only on certain layers.</param>
		/// <param name="results">Array to receive results.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x060011B2 RID: 4530 RVA: 0x0000765F File Offset: 0x0000585F
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, [DefaultValue("Mathf.Infinity")] float distance, [DefaultValue("DefaultRaycastLayers")] int layerMask)
		{
			return Physics2D.INTERNAL_CALL_GetRayIntersectionNonAlloc(ref ray, results, distance, layerMask);
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x000199F0 File Offset: 0x00017BF0
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results, float distance)
		{
			int num = -5;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionNonAlloc(ref ray, results, distance, num);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00019A0C File Offset: 0x00017C0C
		[ExcludeFromDocs]
		public static int GetRayIntersectionNonAlloc(Ray ray, RaycastHit2D[] results)
		{
			int num = -5;
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_GetRayIntersectionNonAlloc(ref ray, results, positiveInfinity, num);
		}

		// Token: 0x060011B5 RID: 4533
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_GetRayIntersectionNonAlloc(ref Ray ray, RaycastHit2D[] results, float distance, int layerMask);

		/// <summary>
		///   <para>Check if a collider overlaps a point in space.</para>
		/// </summary>
		/// <param name="point">A point in world space.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		// Token: 0x060011B6 RID: 4534 RVA: 0x0000766B File Offset: 0x0000586B
		public static Collider2D OverlapPoint(Vector2 point, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapPoint(ref point, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00019A2C File Offset: 0x00017C2C
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapPoint(ref point, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00019A4C File Offset: 0x00017C4C
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapPoint(ref point, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00019A70 File Offset: 0x00017C70
		[ExcludeFromDocs]
		public static Collider2D OverlapPoint(Vector2 point)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapPoint(ref point, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011BA RID: 4538
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_OverlapPoint(ref Vector2 point, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Get a list of all colliders that overlap a point in space.</para>
		/// </summary>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <param name="point">A point in space.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		// Token: 0x060011BB RID: 4539 RVA: 0x00007677 File Offset: 0x00005877
		public static Collider2D[] OverlapPointAll(Vector2 point, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapPointAll(ref point, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00019A98 File Offset: 0x00017C98
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapPointAll(ref point, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapPointAll(ref point, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00019ADC File Offset: 0x00017CDC
		[ExcludeFromDocs]
		public static Collider2D[] OverlapPointAll(Vector2 point)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapPointAll(ref point, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011BF RID: 4543
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_OverlapPointAll(ref Vector2 point, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Get a list of all colliders that overlap a point in space.</para>
		/// </summary>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <param name="point">A point in space.</param>
		/// <param name="results">Array to receive results.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x060011C0 RID: 4544 RVA: 0x00007683 File Offset: 0x00005883
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapPointNonAlloc(ref point, results, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00019B04 File Offset: 0x00017D04
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapPointNonAlloc(ref point, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00019B24 File Offset: 0x00017D24
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapPointNonAlloc(ref point, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00019B48 File Offset: 0x00017D48
		[ExcludeFromDocs]
		public static int OverlapPointNonAlloc(Vector2 point, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapPointNonAlloc(ref point, results, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011C4 RID: 4548
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapPointNonAlloc(ref Vector2 point, Collider2D[] results, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Check if a collider falls within a circular area.</para>
		/// </summary>
		/// <param name="point">Centre of the circle.</param>
		/// <param name="radius">Radius of the circle.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		// Token: 0x060011C5 RID: 4549 RVA: 0x00007691 File Offset: 0x00005891
		public static Collider2D OverlapCircle(Vector2 point, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapCircle(ref point, radius, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00019B70 File Offset: 0x00017D70
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapCircle(ref point, radius, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00019B90 File Offset: 0x00017D90
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapCircle(ref point, radius, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00019BB4 File Offset: 0x00017DB4
		[ExcludeFromDocs]
		public static Collider2D OverlapCircle(Vector2 point, float radius)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapCircle(ref point, radius, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011C9 RID: 4553
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_OverlapCircle(ref Vector2 point, float radius, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Get a list of all colliders that fall within a circular area.</para>
		/// </summary>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <param name="point">Center of the circle.</param>
		/// <param name="radius">Radius of the circle.</param>
		/// <param name="layerMask">Filter to check objects only on specified layers.</param>
		// Token: 0x060011CA RID: 4554 RVA: 0x0000769F File Offset: 0x0000589F
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapCircleAll(ref point, radius, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00019BDC File Offset: 0x00017DDC
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapCircleAll(ref point, radius, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00019BFC File Offset: 0x00017DFC
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapCircleAll(ref point, radius, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00019C20 File Offset: 0x00017E20
		[ExcludeFromDocs]
		public static Collider2D[] OverlapCircleAll(Vector2 point, float radius)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapCircleAll(ref point, radius, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011CE RID: 4558
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_OverlapCircleAll(ref Vector2 point, float radius, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Get a list of all colliders that fall within a circular area.</para>
		/// </summary>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <param name="point">Center of the circle.</param>
		/// <param name="radius">Radius of the circle.</param>
		/// <param name="results">Array to receive results.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x060011CF RID: 4559 RVA: 0x000076AD File Offset: 0x000058AD
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapCircleNonAlloc(ref point, radius, results, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00019C48 File Offset: 0x00017E48
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapCircleNonAlloc(ref point, radius, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00019C68 File Offset: 0x00017E68
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapCircleNonAlloc(ref point, radius, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00019C90 File Offset: 0x00017E90
		[ExcludeFromDocs]
		public static int OverlapCircleNonAlloc(Vector2 point, float radius, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapCircleNonAlloc(ref point, radius, results, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011D3 RID: 4563
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapCircleNonAlloc(ref Vector2 point, float radius, Collider2D[] results, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Check if a collider falls within a rectangular area.</para>
		/// </summary>
		/// <param name="pointA">One corner of the rectangle.</param>
		/// <param name="pointB">Diagonally opposite corner of the rectangle.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		// Token: 0x060011D4 RID: 4564 RVA: 0x000076BD File Offset: 0x000058BD
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapArea(ref pointA, ref pointB, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00019CB8 File Offset: 0x00017EB8
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapArea(ref pointA, ref pointB, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00019CD8 File Offset: 0x00017ED8
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapArea(ref pointA, ref pointB, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00019D00 File Offset: 0x00017F00
		[ExcludeFromDocs]
		public static Collider2D OverlapArea(Vector2 pointA, Vector2 pointB)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapArea(ref pointA, ref pointB, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011D8 RID: 4568
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D INTERNAL_CALL_OverlapArea(ref Vector2 pointA, ref Vector2 pointB, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Get a list of all colliders that fall within a rectangular area.</para>
		/// </summary>
		/// <param name="pointA">One corner of the rectangle.</param>
		/// <param name="pointB">Diagonally opposite corner of the rectangle.</param>
		/// <param name="layerMask">Filter to check objects only on specific layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		// Token: 0x060011D9 RID: 4569 RVA: 0x000076CC File Offset: 0x000058CC
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapAreaAll(ref pointA, ref pointB, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00019D28 File Offset: 0x00017F28
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapAreaAll(ref pointA, ref pointB, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00019D48 File Offset: 0x00017F48
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapAreaAll(ref pointA, ref pointB, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00019D70 File Offset: 0x00017F70
		[ExcludeFromDocs]
		public static Collider2D[] OverlapAreaAll(Vector2 pointA, Vector2 pointB)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapAreaAll(ref pointA, ref pointB, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011DD RID: 4573
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Collider2D[] INTERNAL_CALL_OverlapAreaAll(ref Vector2 pointA, ref Vector2 pointB, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Get a list of all colliders that fall within a specified area.</para>
		/// </summary>
		/// <param name="pointA">One corner of the rectangle.</param>
		/// <param name="pointB">Diagonally opposite corner of the rectangle.</param>
		/// <param name="results">Array to receive results.</param>
		/// <param name="layerMask">Filter to check objects only on specified layers.</param>
		/// <param name="minDepth">Only include objects with a Z coordinate (depth) greater than this value.</param>
		/// <param name="maxDepth">Only include objects with a Z coordinate (depth) less than this value.</param>
		/// <returns>
		///   <para>The number of results returned.</para>
		/// </returns>
		// Token: 0x060011DE RID: 4574 RVA: 0x000076DB File Offset: 0x000058DB
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, [DefaultValue("DefaultRaycastLayers")] int layerMask, [DefaultValue("-Mathf.Infinity")] float minDepth, [DefaultValue("Mathf.Infinity")] float maxDepth)
		{
			return Physics2D.INTERNAL_CALL_OverlapAreaNonAlloc(ref pointA, ref pointB, results, layerMask, minDepth, maxDepth);
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00019D98 File Offset: 0x00017F98
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask, float minDepth)
		{
			float positiveInfinity = float.PositiveInfinity;
			return Physics2D.INTERNAL_CALL_OverlapAreaNonAlloc(ref pointA, ref pointB, results, layerMask, minDepth, positiveInfinity);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00019DBC File Offset: 0x00017FBC
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results, int layerMask)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			return Physics2D.INTERNAL_CALL_OverlapAreaNonAlloc(ref pointA, ref pointB, results, layerMask, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00019DE4 File Offset: 0x00017FE4
		[ExcludeFromDocs]
		public static int OverlapAreaNonAlloc(Vector2 pointA, Vector2 pointB, Collider2D[] results)
		{
			float positiveInfinity = float.PositiveInfinity;
			float negativeInfinity = float.NegativeInfinity;
			int num = -5;
			return Physics2D.INTERNAL_CALL_OverlapAreaNonAlloc(ref pointA, ref pointB, results, num, negativeInfinity, positiveInfinity);
		}

		// Token: 0x060011E2 RID: 4578
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int INTERNAL_CALL_OverlapAreaNonAlloc(ref Vector2 pointA, ref Vector2 pointB, Collider2D[] results, int layerMask, float minDepth, float maxDepth);

		/// <summary>
		///   <para>Layer mask constant for the default layer that ignores raycasts.</para>
		/// </summary>
		// Token: 0x0400032C RID: 812
		public const int IgnoreRaycastLayer = 4;

		/// <summary>
		///   <para>Layer mask constant that includes all layers participating in raycasts by default.</para>
		/// </summary>
		// Token: 0x0400032D RID: 813
		public const int DefaultRaycastLayers = -5;

		/// <summary>
		///   <para>Layer mask constant that includes all layers.</para>
		/// </summary>
		// Token: 0x0400032E RID: 814
		public const int AllLayers = -1;

		// Token: 0x0400032F RID: 815
		private static List<Rigidbody2D> m_LastDisabledRigidbody2D = new List<Rigidbody2D>();
	}
}
