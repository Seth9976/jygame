using System;

namespace UnityEngine
{
	// Token: 0x020002B4 RID: 692
	internal class SendMouseEvents
	{
		// Token: 0x06002158 RID: 8536 RVA: 0x0000D6A5 File Offset: 0x0000B8A5
		private static void SetMouseMoved()
		{
			SendMouseEvents.s_MouseUsed = true;
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0002937C File Offset: 0x0002757C
		private static void DoSendMouseEvents(int skipRTCameras)
		{
			Vector3 mousePosition = Input.mousePosition;
			int allCamerasCount = Camera.allCamerasCount;
			if (SendMouseEvents.m_Cameras == null || SendMouseEvents.m_Cameras.Length != allCamerasCount)
			{
				SendMouseEvents.m_Cameras = new Camera[allCamerasCount];
			}
			Camera.GetAllCameras(SendMouseEvents.m_Cameras);
			for (int i = 0; i < SendMouseEvents.m_CurrentHit.Length; i++)
			{
				SendMouseEvents.m_CurrentHit[i] = default(SendMouseEvents.HitInfo);
			}
			if (!SendMouseEvents.s_MouseUsed)
			{
				foreach (Camera camera in SendMouseEvents.m_Cameras)
				{
					if (!(camera == null) && (skipRTCameras == 0 || !(camera.targetTexture != null)))
					{
						if (camera.pixelRect.Contains(mousePosition))
						{
							GUILayer component = camera.GetComponent<GUILayer>();
							if (component)
							{
								GUIElement guielement = component.HitTest(mousePosition);
								if (guielement)
								{
									SendMouseEvents.m_CurrentHit[0].target = guielement.gameObject;
									SendMouseEvents.m_CurrentHit[0].camera = camera;
								}
								else
								{
									SendMouseEvents.m_CurrentHit[0].target = null;
									SendMouseEvents.m_CurrentHit[0].camera = null;
								}
							}
							if (camera.eventMask != 0)
							{
								Ray ray = camera.ScreenPointToRay(mousePosition);
								float z = ray.direction.z;
								float num = ((!Mathf.Approximately(0f, z)) ? Mathf.Abs((camera.farClipPlane - camera.nearClipPlane) / z) : float.PositiveInfinity);
								GameObject gameObject = camera.RaycastTry(ray, num, camera.cullingMask & camera.eventMask);
								if (gameObject != null)
								{
									SendMouseEvents.m_CurrentHit[1].target = gameObject;
									SendMouseEvents.m_CurrentHit[1].camera = camera;
								}
								else if (camera.clearFlags == CameraClearFlags.Skybox || camera.clearFlags == CameraClearFlags.Color)
								{
									SendMouseEvents.m_CurrentHit[1].target = null;
									SendMouseEvents.m_CurrentHit[1].camera = null;
								}
								GameObject gameObject2 = camera.RaycastTry2D(ray, num, camera.cullingMask & camera.eventMask);
								if (gameObject2 != null)
								{
									SendMouseEvents.m_CurrentHit[2].target = gameObject2;
									SendMouseEvents.m_CurrentHit[2].camera = camera;
								}
								else if (camera.clearFlags == CameraClearFlags.Skybox || camera.clearFlags == CameraClearFlags.Color)
								{
									SendMouseEvents.m_CurrentHit[2].target = null;
									SendMouseEvents.m_CurrentHit[2].camera = null;
								}
							}
						}
					}
				}
			}
			for (int k = 0; k < SendMouseEvents.m_CurrentHit.Length; k++)
			{
				SendMouseEvents.SendEvents(k, SendMouseEvents.m_CurrentHit[k]);
			}
			SendMouseEvents.s_MouseUsed = false;
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x00029688 File Offset: 0x00027888
		private static void SendEvents(int i, SendMouseEvents.HitInfo hit)
		{
			bool mouseButtonDown = Input.GetMouseButtonDown(0);
			bool mouseButton = Input.GetMouseButton(0);
			if (mouseButtonDown)
			{
				if (hit)
				{
					SendMouseEvents.m_MouseDownHit[i] = hit;
					SendMouseEvents.m_MouseDownHit[i].SendMessage("OnMouseDown");
				}
			}
			else if (!mouseButton)
			{
				if (SendMouseEvents.m_MouseDownHit[i])
				{
					if (SendMouseEvents.HitInfo.Compare(hit, SendMouseEvents.m_MouseDownHit[i]))
					{
						SendMouseEvents.m_MouseDownHit[i].SendMessage("OnMouseUpAsButton");
					}
					SendMouseEvents.m_MouseDownHit[i].SendMessage("OnMouseUp");
					SendMouseEvents.m_MouseDownHit[i] = default(SendMouseEvents.HitInfo);
				}
			}
			else if (SendMouseEvents.m_MouseDownHit[i])
			{
				SendMouseEvents.m_MouseDownHit[i].SendMessage("OnMouseDrag");
			}
			if (SendMouseEvents.HitInfo.Compare(hit, SendMouseEvents.m_LastHit[i]))
			{
				if (hit)
				{
					hit.SendMessage("OnMouseOver");
				}
			}
			else
			{
				if (SendMouseEvents.m_LastHit[i])
				{
					SendMouseEvents.m_LastHit[i].SendMessage("OnMouseExit");
				}
				if (hit)
				{
					hit.SendMessage("OnMouseEnter");
					hit.SendMessage("OnMouseOver");
				}
			}
			SendMouseEvents.m_LastHit[i] = hit;
		}

		// Token: 0x04000AC0 RID: 2752
		private const int m_HitIndexGUI = 0;

		// Token: 0x04000AC1 RID: 2753
		private const int m_HitIndexPhysics3D = 1;

		// Token: 0x04000AC2 RID: 2754
		private const int m_HitIndexPhysics2D = 2;

		// Token: 0x04000AC3 RID: 2755
		private static bool s_MouseUsed = false;

		// Token: 0x04000AC4 RID: 2756
		private static readonly SendMouseEvents.HitInfo[] m_LastHit = new SendMouseEvents.HitInfo[]
		{
			default(SendMouseEvents.HitInfo),
			default(SendMouseEvents.HitInfo),
			default(SendMouseEvents.HitInfo)
		};

		// Token: 0x04000AC5 RID: 2757
		private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit = new SendMouseEvents.HitInfo[]
		{
			default(SendMouseEvents.HitInfo),
			default(SendMouseEvents.HitInfo),
			default(SendMouseEvents.HitInfo)
		};

		// Token: 0x04000AC6 RID: 2758
		private static readonly SendMouseEvents.HitInfo[] m_CurrentHit = new SendMouseEvents.HitInfo[]
		{
			default(SendMouseEvents.HitInfo),
			default(SendMouseEvents.HitInfo),
			default(SendMouseEvents.HitInfo)
		};

		// Token: 0x04000AC7 RID: 2759
		private static Camera[] m_Cameras;

		// Token: 0x020002B5 RID: 693
		private struct HitInfo
		{
			// Token: 0x0600215B RID: 8539 RVA: 0x0000D6AD File Offset: 0x0000B8AD
			public void SendMessage(string name)
			{
				this.target.SendMessage(name, null, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600215C RID: 8540 RVA: 0x0000D6BD File Offset: 0x0000B8BD
			public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs)
			{
				return lhs.target == rhs.target && lhs.camera == rhs.camera;
			}

			// Token: 0x0600215D RID: 8541 RVA: 0x0000D6ED File Offset: 0x0000B8ED
			public static implicit operator bool(SendMouseEvents.HitInfo exists)
			{
				return exists.target != null && exists.camera != null;
			}

			// Token: 0x04000AC8 RID: 2760
			public GameObject target;

			// Token: 0x04000AC9 RID: 2761
			public Camera camera;
		}
	}
}
