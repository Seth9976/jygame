using System;
using System.Runtime.CompilerServices;

namespace UnityEngine
{
	/// <summary>
	///   <para>Navigation mesh agent.</para>
	/// </summary>
	// Token: 0x02000141 RID: 321
	public sealed class NavMeshAgent : Behaviour
	{
		/// <summary>
		///   <para>Sets or updates the destination thus triggering the calculation for a new path.</para>
		/// </summary>
		/// <param name="target">The target point to navigate to.</param>
		/// <returns>
		///   <para>True if the destination was requested successfully, otherwise false.</para>
		/// </returns>
		// Token: 0x06001347 RID: 4935 RVA: 0x00007A5A File Offset: 0x00005C5A
		public bool SetDestination(Vector3 target)
		{
			return NavMeshAgent.INTERNAL_CALL_SetDestination(this, ref target);
		}

		// Token: 0x06001348 RID: 4936
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_SetDestination(NavMeshAgent self, ref Vector3 target);

		/// <summary>
		///   <para>Gets or attempts to set the destination of the agent in world-space units.</para>
		/// </summary>
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0001A1EC File Offset: 0x000183EC
		// (set) Token: 0x0600134A RID: 4938 RVA: 0x00007A64 File Offset: 0x00005C64
		public Vector3 destination
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_destination(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_destination(ref value);
			}
		}

		// Token: 0x0600134B RID: 4939
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_destination(out Vector3 value);

		// Token: 0x0600134C RID: 4940
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_destination(ref Vector3 value);

		/// <summary>
		///   <para>Stop within this distance from the target position.</para>
		/// </summary>
		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x0600134D RID: 4941
		// (set) Token: 0x0600134E RID: 4942
		public extern float stoppingDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Access the current velocity of the NavMeshAgent component, or set a velocity to control the agent manually.</para>
		/// </summary>
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0001A204 File Offset: 0x00018404
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x00007A6E File Offset: 0x00005C6E
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_velocity(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_velocity(ref value);
			}
		}

		// Token: 0x06001351 RID: 4945
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_velocity(out Vector3 value);

		// Token: 0x06001352 RID: 4946
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_velocity(ref Vector3 value);

		/// <summary>
		///   <para>Gets or sets the simulation position of the navmesh agent.</para>
		/// </summary>
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x0001A21C File Offset: 0x0001841C
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x00007A78 File Offset: 0x00005C78
		public Vector3 nextPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_nextPosition(out vector);
				return vector;
			}
			set
			{
				this.INTERNAL_set_nextPosition(ref value);
			}
		}

		// Token: 0x06001355 RID: 4949
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_nextPosition(out Vector3 value);

		// Token: 0x06001356 RID: 4950
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_set_nextPosition(ref Vector3 value);

		/// <summary>
		///   <para>Get the current steering target along the path. (Read Only)</para>
		/// </summary>
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0001A234 File Offset: 0x00018434
		public Vector3 steeringTarget
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_steeringTarget(out vector);
				return vector;
			}
		}

		// Token: 0x06001358 RID: 4952
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_steeringTarget(out Vector3 value);

		/// <summary>
		///   <para>The desired velocity of the agent including any potential contribution from avoidance. (Read Only)</para>
		/// </summary>
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0001A24C File Offset: 0x0001844C
		public Vector3 desiredVelocity
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_desiredVelocity(out vector);
				return vector;
			}
		}

		// Token: 0x0600135A RID: 4954
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_desiredVelocity(out Vector3 value);

		/// <summary>
		///   <para>The distance between the agent's position and the destination on the current path. (Read Only)</para>
		/// </summary>
		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x0600135B RID: 4955
		public extern float remainingDistance
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The relative vertical displacement of the owning GameObject.</para>
		/// </summary>
		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x0600135C RID: 4956
		// (set) Token: 0x0600135D RID: 4957
		public extern float baseOffset
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the agent currently positioned on an OffMeshLink? (Read Only)</para>
		/// </summary>
		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x0600135E RID: 4958
		public extern bool isOnOffMeshLink
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Enables or disables the current off-mesh link.</para>
		/// </summary>
		/// <param name="activated">Is the link activated?</param>
		// Token: 0x0600135F RID: 4959
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ActivateCurrentOffMeshLink(bool activated);

		/// <summary>
		///   <para>The current OffMeshLinkData.</para>
		/// </summary>
		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00007A82 File Offset: 0x00005C82
		public OffMeshLinkData currentOffMeshLinkData
		{
			get
			{
				return this.GetCurrentOffMeshLinkDataInternal();
			}
		}

		// Token: 0x06001361 RID: 4961
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern OffMeshLinkData GetCurrentOffMeshLinkDataInternal();

		/// <summary>
		///   <para>The next OffMeshLinkData on the current path.</para>
		/// </summary>
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001362 RID: 4962 RVA: 0x00007A8A File Offset: 0x00005C8A
		public OffMeshLinkData nextOffMeshLinkData
		{
			get
			{
				return this.GetNextOffMeshLinkDataInternal();
			}
		}

		// Token: 0x06001363 RID: 4963
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern OffMeshLinkData GetNextOffMeshLinkDataInternal();

		/// <summary>
		///   <para>Completes the movement on the current OffMeshLink.</para>
		/// </summary>
		// Token: 0x06001364 RID: 4964
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void CompleteOffMeshLink();

		/// <summary>
		///   <para>Should the agent move across OffMeshLinks automatically?</para>
		/// </summary>
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001365 RID: 4965
		// (set) Token: 0x06001366 RID: 4966
		public extern bool autoTraverseOffMeshLink
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the agent brake automatically to avoid overshooting the destination point?</para>
		/// </summary>
		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001367 RID: 4967
		// (set) Token: 0x06001368 RID: 4968
		public extern bool autoBraking
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the agent attempt to acquire a new path if the existing path becomes invalid?</para>
		/// </summary>
		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001369 RID: 4969
		// (set) Token: 0x0600136A RID: 4970
		public extern bool autoRepath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Does the agent currently have a path? (Read Only)</para>
		/// </summary>
		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x0600136B RID: 4971
		public extern bool hasPath
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is a path in the process of being computed but not yet ready? (Read Only)</para>
		/// </summary>
		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x0600136C RID: 4972
		public extern bool pathPending
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>Is the current path stale. (Read Only)</para>
		/// </summary>
		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x0600136D RID: 4973
		public extern bool isPathStale
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		/// <summary>
		///   <para>The status of the current path (complete, partial or invalid).</para>
		/// </summary>
		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x0600136E RID: 4974
		public extern NavMeshPathStatus pathStatus
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x0001A264 File Offset: 0x00018464
		public Vector3 pathEndPosition
		{
			get
			{
				Vector3 vector;
				this.INTERNAL_get_pathEndPosition(out vector);
				return vector;
			}
		}

		// Token: 0x06001370 RID: 4976
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void INTERNAL_get_pathEndPosition(out Vector3 value);

		/// <summary>
		///   <para>Warps agent to the provided position.</para>
		/// </summary>
		/// <param name="newPosition">New position to warp the agent to.</param>
		/// <returns>
		///   <para>True if agent is successfully warped, otherwise false.</para>
		/// </returns>
		// Token: 0x06001371 RID: 4977 RVA: 0x00007A92 File Offset: 0x00005C92
		public bool Warp(Vector3 newPosition)
		{
			return NavMeshAgent.INTERNAL_CALL_Warp(this, ref newPosition);
		}

		// Token: 0x06001372 RID: 4978
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Warp(NavMeshAgent self, ref Vector3 newPosition);

		/// <summary>
		///   <para>Apply relative movement to current position.</para>
		/// </summary>
		/// <param name="offset">The relative movement vector.</param>
		// Token: 0x06001373 RID: 4979 RVA: 0x00007A9C File Offset: 0x00005C9C
		public void Move(Vector3 offset)
		{
			NavMeshAgent.INTERNAL_CALL_Move(this, ref offset);
		}

		// Token: 0x06001374 RID: 4980
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void INTERNAL_CALL_Move(NavMeshAgent self, ref Vector3 offset);

		/// <summary>
		///   <para>Stop movement of this agent along its current path.</para>
		/// </summary>
		// Token: 0x06001375 RID: 4981 RVA: 0x00007AA6 File Offset: 0x00005CA6
		public void Stop()
		{
			this.StopInternal();
		}

		// Token: 0x06001376 RID: 4982
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void StopInternal();

		// Token: 0x06001377 RID: 4983 RVA: 0x00007AA6 File Offset: 0x00005CA6
		[Obsolete("Use Stop() instead")]
		public void Stop(bool stopUpdates)
		{
			this.StopInternal();
		}

		/// <summary>
		///   <para>Resumes the movement along the current path after a pause.</para>
		/// </summary>
		// Token: 0x06001378 RID: 4984
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void Resume();

		/// <summary>
		///   <para>Clears the current path.</para>
		/// </summary>
		// Token: 0x06001379 RID: 4985
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void ResetPath();

		/// <summary>
		///   <para>Assign a new path to this agent.</para>
		/// </summary>
		/// <param name="path">New path to follow.</param>
		/// <returns>
		///   <para>True if the path is succesfully assigned.</para>
		/// </returns>
		// Token: 0x0600137A RID: 4986
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SetPath(NavMeshPath path);

		/// <summary>
		///   <para>Property to get and set the current path.</para>
		/// </summary>
		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x0001A27C File Offset: 0x0001847C
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x00007AAE File Offset: 0x00005CAE
		public NavMeshPath path
		{
			get
			{
				NavMeshPath navMeshPath = new NavMeshPath();
				this.CopyPathTo(navMeshPath);
				return navMeshPath;
			}
			set
			{
				if (value == null)
				{
					throw new NullReferenceException();
				}
				this.SetPath(value);
			}
		}

		// Token: 0x0600137D RID: 4989
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern void CopyPathTo(NavMeshPath path);

		// Token: 0x0600137E RID: 4990
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool FindClosestEdge(out NavMeshHit hit);

		// Token: 0x0600137F RID: 4991 RVA: 0x00007AC4 File Offset: 0x00005CC4
		public bool Raycast(Vector3 targetPosition, out NavMeshHit hit)
		{
			return NavMeshAgent.INTERNAL_CALL_Raycast(this, ref targetPosition, out hit);
		}

		// Token: 0x06001380 RID: 4992
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_Raycast(NavMeshAgent self, ref Vector3 targetPosition, out NavMeshHit hit);

		/// <summary>
		///   <para>Calculate a path to a specified point and store the resulting path.</para>
		/// </summary>
		/// <param name="targetPosition">The final position of the path requested.</param>
		/// <param name="path">The resulting path.</param>
		/// <returns>
		///   <para>True if a path is found.</para>
		/// </returns>
		// Token: 0x06001381 RID: 4993 RVA: 0x00007ACF File Offset: 0x00005CCF
		public bool CalculatePath(Vector3 targetPosition, NavMeshPath path)
		{
			path.ClearCorners();
			return this.CalculatePathInternal(targetPosition, path);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x00007ADF File Offset: 0x00005CDF
		private bool CalculatePathInternal(Vector3 targetPosition, NavMeshPath path)
		{
			return NavMeshAgent.INTERNAL_CALL_CalculatePathInternal(this, ref targetPosition, path);
		}

		// Token: 0x06001383 RID: 4995
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool INTERNAL_CALL_CalculatePathInternal(NavMeshAgent self, ref Vector3 targetPosition, NavMeshPath path);

		// Token: 0x06001384 RID: 4996
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern bool SamplePathPosition(int areaMask, float maxDistance, out NavMeshHit hit);

		/// <summary>
		///   <para>Sets the cost for traversing over geometry of the layer type.</para>
		/// </summary>
		/// <param name="layer">Layer index.</param>
		/// <param name="cost">New cost for the specified layer.</param>
		// Token: 0x06001385 RID: 4997
		[Obsolete("Use SetAreaCost instead.")]
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetLayerCost(int layer, float cost);

		/// <summary>
		///   <para>Gets the cost for crossing ground of a particular type.</para>
		/// </summary>
		/// <param name="layer">Layer index.</param>
		/// <returns>
		///   <para>Current cost of specified layer.</para>
		/// </returns>
		// Token: 0x06001386 RID: 4998
		[WrapperlessIcall]
		[Obsolete("Use GetAreaCost instead.")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetLayerCost(int layer);

		/// <summary>
		///   <para>Sets the cost for traversing over areas of the area type.</para>
		/// </summary>
		/// <param name="areaIndex">Area cost.</param>
		/// <param name="areaCost">New cost for the specified area index.</param>
		// Token: 0x06001387 RID: 4999
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void SetAreaCost(int areaIndex, float areaCost);

		/// <summary>
		///   <para>Gets the cost for path calculation when crossing area of a particular type.</para>
		/// </summary>
		/// <param name="areaIndex">Area Index.</param>
		/// <returns>
		///   <para>Current cost for specified area index.</para>
		/// </returns>
		// Token: 0x06001388 RID: 5000
		[WrapperlessIcall]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern float GetAreaCost(int areaIndex);

		/// <summary>
		///   <para>Specifies which NavMesh layers are passable (bitfield). Changing walkableMask will make the path stale (see isPathStale).</para>
		/// </summary>
		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001389 RID: 5001
		// (set) Token: 0x0600138A RID: 5002
		[Obsolete("Use areaMask instead.")]
		public extern int walkableMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Specifies which NavMesh areas are passable. Changing areaMask will make the path stale (see isPathStale).</para>
		/// </summary>
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600138B RID: 5003
		// (set) Token: 0x0600138C RID: 5004
		public extern int areaMask
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Maximum movement speed when following a path.</para>
		/// </summary>
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x0600138D RID: 5005
		// (set) Token: 0x0600138E RID: 5006
		public extern float speed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Maximum turning speed in (deg/s) while following a path.</para>
		/// </summary>
		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600138F RID: 5007
		// (set) Token: 0x06001390 RID: 5008
		public extern float angularSpeed
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The maximum acceleration of an agent as it follows a path, given in units / sec^2.</para>
		/// </summary>
		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001391 RID: 5009
		// (set) Token: 0x06001392 RID: 5010
		public extern float acceleration
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Gets or sets whether the transform position is synchronized with the simulated agent position. The default value is true.</para>
		/// </summary>
		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001393 RID: 5011
		// (set) Token: 0x06001394 RID: 5012
		public extern bool updatePosition
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Should the agent update the transform orientation?</para>
		/// </summary>
		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001395 RID: 5013
		// (set) Token: 0x06001396 RID: 5014
		public extern bool updateRotation
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The avoidance radius for the agent.</para>
		/// </summary>
		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001397 RID: 5015
		// (set) Token: 0x06001398 RID: 5016
		public extern float radius
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The height of the agent for purposes of passing under obstacles, etc.</para>
		/// </summary>
		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001399 RID: 5017
		// (set) Token: 0x0600139A RID: 5018
		public extern float height
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The level of quality of avoidance.</para>
		/// </summary>
		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x0600139B RID: 5019
		// (set) Token: 0x0600139C RID: 5020
		public extern ObstacleAvoidanceType obstacleAvoidanceType
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>The avoidance priority level.</para>
		/// </summary>
		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x0600139D RID: 5021
		// (set) Token: 0x0600139E RID: 5022
		public extern int avoidancePriority
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		/// <summary>
		///   <para>Is the agent currently bound to the navmesh? (Read Only)</para>
		/// </summary>
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600139F RID: 5023
		public extern bool isOnNavMesh
		{
			[WrapperlessIcall]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}
	}
}
