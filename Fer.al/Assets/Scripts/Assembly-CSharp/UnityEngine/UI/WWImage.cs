using System;
using UnityEngine.Events;

namespace UnityEngine.UI
{
	[AddComponentMenu("UI/WWImage", 11)]
	public class WWImage : Image
	{
		[Serializable]
		public class WWLoadingImageEvent : UnityEvent
		{
		}

		[SerializeField]
		private bool m_useOverridePixelsPerUnit;

		[SerializeField]
		private float m_overridePixelsPerUnit;

		[SerializeField]
		private bool m_UseBundledImage;

		[SerializeField]
		[RootSelector("Texture to Assign", "ImageChartData", false, false)]
		private string m_BundledImageDefID;

		[SerializeField]
		private CoreSharedUtils.EImageQuality m_BundledImageQuality;

		[SerializeField]
		private GameObject m_LoadingGroup;

		[SerializeField]
		private WWLoadingImageEvent m_OnLoadingStarted;

		[SerializeField]
		private WWLoadingImageEvent m_OnLoadingCompleted;

		private static readonly Vector2[] s_VertScratch;

		private static readonly Vector2[] s_UVScratch;

		public bool useOverridePixelsPerUnit
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float overridePixelsPerUnit
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool useBundledImage
		{
			get
			{
				return default(bool);
			}
		}

		public CoreSharedUtils.EImageQuality bundledImageQuality
		{
			get
			{
				return default(CoreSharedUtils.EImageQuality);
			}
		}

		public GameObject loadingGroup
		{
			get
			{
				return null;
			}
		}

		public new float pixelsPerUnit
		{
			get
			{
				return default(float);
			}
		}

		protected override void Awake()
		{
		}

		private void DownloadAndAssignBundledImage()
		{
		}

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		private void GenerateSimpleSprite(VertexHelper vh, bool lPreserveAspect)
		{
		}

		private void GenerateSlicedSprite(VertexHelper toFill)
		{
		}

		private void GenerateTiledSprite(VertexHelper toFill)
		{
		}

		private static void AddQuad(VertexHelper vertexHelper, Vector3[] quadPositions, Color32 color, Vector3[] quadUVs)
		{
		}

		private static void AddQuad(VertexHelper vertexHelper, Vector2 posMin, Vector2 posMax, Color32 color, Vector2 uvMin, Vector2 uvMax)
		{
		}

		private Vector4 GetAdjustedBorders(Vector4 border, Rect adjustedRect)
		{
			return default(Vector4);
		}

		private Vector4 GetDrawingDimensions(bool shouldPreserveAspect)
		{
			return default(Vector4);
		}
	}
}
