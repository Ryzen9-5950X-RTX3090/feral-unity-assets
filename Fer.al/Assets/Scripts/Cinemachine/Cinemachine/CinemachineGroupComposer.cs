using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineGroupComposer : CinemachineComposer
	{
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public enum FramingMode
		{
			Horizontal,
			Vertical,
			HorizontalAndVertical
		}

		public enum AdjustmentMode
		{
			ZoomOnly,
			DollyOnly,
			DollyThenZoom
		}

		[Space]
		[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
		public float m_GroupFramingSize;

		[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
		public FramingMode m_FramingMode;

		[Tooltip("How aggressively the camera tries to frame the group. Small numbers are more responsive, rapidly adjusting the camera to keep the group in the frame.  Larger numbers give a more heavy slowly responding camera.")]
		[Range(0f, 20f)]
		public float m_FrameDamping;

		[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
		public AdjustmentMode m_AdjustmentMode;

		[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyIn;

		[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
		public float m_MaxDollyOut;

		[Tooltip("Set this to limit how close to the target the camera can get.")]
		public float m_MinimumDistance;

		[Tooltip("Set this to limit how far from the target the camera can get.")]
		public float m_MaximumDistance;

		[Range(1f, 179f)]
		[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
		public float m_MinimumFOV;

		[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
		[Range(1f, 179f)]
		public float m_MaximumFOV;

		[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
		public float m_MinimumOrthoSize;

		[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
		public float m_MaximumOrthoSize;

		private float m_prevFramingDistance;

		private float m_prevFOV;

		public Bounds LastBounds
		{
			[CompilerGenerated]
			get
			{
				return default(Bounds);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Matrix4x4 LastBoundsMatrix
		{
			[CompilerGenerated]
			get
			{
				return default(Matrix4x4);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		private void OnValidate()
		{
		}

		public override float GetMaxDampTime()
		{
			return default(float);
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}

		private float GetTargetHeight(Vector2 boundsSize)
		{
			return default(float);
		}

		private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd)
		{
			return default(Bounds);
		}
	}
}
