using System.Collections;
using System.Runtime.CompilerServices;
using Gaia.FullSerializer;
using UnityEngine;

namespace Gaia
{
	[ExecuteInEditMode]
	public class Stamper : MonoBehaviour
	{
		public string m_stampID;

		public Texture2D m_stampPreviewImage;

		public float m_x;

		public float m_y;

		public float m_z;

		public float m_width;

		public float m_height;

		public float m_rotation;

		public bool m_stickBaseToGround;

		[fsIgnore]
		public GaiaResource m_resources;

		[fsIgnore]
		public float m_seaLevel;

		public string m_resourcesPath;

		public bool m_invertStamp;

		public bool m_normaliseStamp;

		public float m_baseLevel;

		public bool m_drawStampBase;

		public GaiaConstants.FeatureOperation m_stampOperation;

		public int m_smoothIterations;

		public float m_blendStrength;

		public float m_stencilHeight;

		public AnimationCurve m_heightModifier;

		public AnimationCurve m_distanceMask;

		public GaiaConstants.ImageFitnessFilterMode m_areaMaskMode;

		public Texture2D m_imageMask;

		public bool m_imageMaskInvert;

		public bool m_imageMaskNormalise;

		public bool m_imageMaskFlip;

		public int m_imageMaskSmoothIterations;

		[fsIgnore]
		public HeightMap m_imageMaskHM;

		public float m_noiseMaskSeed;

		public int m_noiseMaskOctaves;

		public float m_noiseMaskPersistence;

		public float m_noiseMaskFrequency;

		public float m_noiseMaskLacunarity;

		public float m_noiseZoom;

		public bool m_alwaysShow;

		public bool m_showBase;

		public bool m_showSeaLevel;

		public bool m_showRulers;

		public bool m_showTerrainHelper;

		[fsIgnore]
		public Color m_gizmoColour;

		[fsIgnore]
		public IEnumerator m_updateCoroutine;

		[fsIgnore]
		public float m_updateTimeAllowed;

		[fsIgnore]
		public float m_stampProgress;

		[fsIgnore]
		public bool m_stampComplete;

		[fsIgnore]
		public bool m_cancelStamp;

		[fsIgnore]
		public Material m_previewMaterial;

		private int m_featureID;

		private int m_scanWidth;

		private int m_scanDepth;

		private int m_scanHeight;

		private float m_scanResolution;

		private Bounds m_scanBounds;

		private UnityHeightMap m_stampHM;

		private GaiaWorldManager m_undoMgr;

		private GaiaWorldManager m_redoMgr;

		private MeshFilter m_previewFilter;

		private MeshRenderer m_previewRenderer;

		public void LoadStamp()
		{
		}

		public void LoadStamp(string imagePreviewPath)
		{
		}

		public bool LoadRuntimeStamp(TextAsset stamp)
		{
			return default(bool);
		}

		public void InvertStamp()
		{
		}

		public void NormaliseStamp()
		{
		}

		public void Stamp()
		{
		}

		public void CancelStamp()
		{
		}

		public bool IsStamping()
		{
			return default(bool);
		}

		public void UpdateStamp()
		{
		}

		public void AlignToGround()
		{
		}

		public bool GetHeightRange(ref float baseLevel, ref float minHeight, ref float maxHeight)
		{
			return default(bool);
		}

		public void FitToTerrain()
		{
		}

		public bool IsFitToTerrain()
		{
			return default(bool);
		}

		public void AddToSession(GaiaOperation.OperationType opType, string opName)
		{
		}

		public string SerialiseJson()
		{
			return null;
		}

		public void DeSerialiseJson(string json)
		{
		}

		public void FlattenTerrain()
		{
		}

		public void SmoothTerrain()
		{
		}

		public void ClearTrees()
		{
		}

		public void ClearDetails()
		{
		}

		public bool CanPreview()
		{
			return default(bool);
		}

		public bool CurrentPreviewState()
		{
			return default(bool);
		}

		public void ShowPreview()
		{
		}

		public void HidePreview()
		{
		}

		public void TogglePreview()
		{
		}

		public bool CanUndo()
		{
			return default(bool);
		}

		public void CreateUndo()
		{
		}

		public void Undo()
		{
		}

		public bool CanRedo()
		{
			return default(bool);
		}

		public void Redo()
		{
		}

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		public void StartEditorUpdates()
		{
		}

		public void StopEditorUpdates()
		{
		}

		private void EditorUpdate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		private void OnDrawGizmos()
		{
		}

		private void DrawGizmos(bool isSelected)
		{
		}

		private void DrawRulers()
		{
		}

		[IteratorStateMachine(typeof(<ApplyStamp>d__97))]
		public IEnumerator ApplyStamp()
		{
			return null;
		}

		private void GeneratePreviewMesh()
		{
		}

		private bool LoadImageMask()
		{
			return default(bool);
		}

		private float CalculateHeight(float terrainHeight, float smHeightRaw, float smHeightAdj, float stencilHeightNU, float strength)
		{
			return default(float);
		}

		private Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angle)
		{
			return default(Vector3);
		}
	}
}
