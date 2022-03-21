using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cinemachine
{
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineStoryboard.html")]
	public class CinemachineStoryboard : CinemachineExtension
	{
		public enum FillStrategy
		{
			BestFit,
			CropImageToFit,
			StretchToFit
		}

		private class CanvasInfo
		{
			public GameObject mCanvas;

			public CinemachineBrain mCanvasParent;

			public RectTransform mViewport;

			public RawImage mRawImage;
		}

		[Tooltip("If checked, all storyboards are globally muted")]
		public static bool s_StoryboardGlobalMute;

		[Tooltip("If checked, the specified image will be displayed as an overlay over the virtual camera's output")]
		public bool m_ShowImage;

		[Tooltip("The image to display")]
		public Texture m_Image;

		[Tooltip("How to handle differences between image aspect and screen aspect")]
		public FillStrategy m_Aspect;

		[Range(0f, 1f)]
		[Tooltip("The opacity of the image.  0 is transparent, 1 is opaque")]
		public float m_Alpha;

		[Tooltip("The screen-space position at which to display the image.  Zero is center")]
		public Vector2 m_Center;

		[Tooltip("The screen-space rotation to apply to the image")]
		public Vector3 m_Rotation;

		[Tooltip("The screen-space scaling to apply to the image")]
		public Vector2 m_Scale;

		[Tooltip("If checked, X and Y scale are synchronized")]
		public bool m_SyncScale;

		[Tooltip("If checked, Camera transform will not be controlled by this virtual camera")]
		public bool m_MuteCamera;

		[Range(-1f, 1f)]
		[Tooltip("Wipe the image on and off horizontally")]
		public float m_SplitView;

		private List<CanvasInfo> mCanvasInfo;

		private string CanvasName
		{
			get
			{
				return null;
			}
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		protected override void ConnectToVcam(bool connect)
		{
		}

		private void CameraUpdatedCallback(CinemachineBrain brain)
		{
		}

		private CanvasInfo LocateMyCanvas(CinemachineBrain parent, bool createIfNotFound)
		{
			return null;
		}

		private void CreateCanvas(CanvasInfo ci)
		{
		}

		private void DestroyCanvas()
		{
		}

		private void PlaceImage(CanvasInfo ci, float alpha)
		{
		}

		private static void StaticBlendingHandler(CinemachineBrain brain)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}
	}
}
