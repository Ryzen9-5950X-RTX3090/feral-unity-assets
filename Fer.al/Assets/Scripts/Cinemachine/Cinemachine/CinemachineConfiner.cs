using System.Collections.Generic;
using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineConfiner.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("")]
	public class CinemachineConfiner : CinemachineExtension
	{
		public enum Mode
		{
			Confine2D,
			Confine3D
		}

		private class VcamExtraState
		{
			public Vector3 m_previousDisplacement;

			public float confinerDisplacement;
		}

		[Tooltip("The confiner can operate using a 2D bounding shape or a 3D bounding volume")]
		public Mode m_ConfineMode;

		[Tooltip("The volume within which the camera is to be contained")]
		public Collider m_BoundingVolume;

		[Tooltip("The 2D shape within which the camera is to be contained")]
		public Collider2D m_BoundingShape2D;

		private Collider2D m_BoundingShape2DCache;

		[Tooltip("If camera is orthographic, screen edges will be confined to the volume.  If not checked, then only the camera center will be confined")]
		public bool m_ConfineScreenEdges;

		[Range(0f, 10f)]
		[Tooltip("How gradually to return the camera to the bounding volume if it goes beyond the borders.  Higher numbers are more gradual.")]
		public float m_Damping;

		private List<List<Vector2>> m_pathCache;

		private int m_pathTotalPointCount;

		public bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam)
		{
			return default(bool);
		}

		public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam)
		{
			return default(float);
		}

		private void OnValidate()
		{
		}

		protected override void ConnectToVcam(bool connect)
		{
		}

		public override float GetMaxDampTime()
		{
			return default(float);
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		public void InvalidatePathCache()
		{
		}

		private bool ValidatePathCache()
		{
			return default(bool);
		}

		private Vector3 ConfinePoint(Vector3 camPos)
		{
			return default(Vector3);
		}

		private Vector3 ConfineScreenEdges(CinemachineVirtualCameraBase vcam, ref CameraState state)
		{
			return default(Vector3);
		}
	}
}
