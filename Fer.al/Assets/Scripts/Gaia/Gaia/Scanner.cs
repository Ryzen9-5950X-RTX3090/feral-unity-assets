using UnityEngine;

namespace Gaia
{
	public class Scanner : MonoBehaviour
	{
		[Tooltip("The name of the stamp as it will be stored in the project. Initally based on the file name.")]
		public string m_featureName;

		[Tooltip("The type of stamp, also controls which directory the stamp will be loaded into.")]
		public GaiaConstants.FeatureType m_featureType;

		[Range(0f, 1f)]
		[Tooltip("Base level for this stamp, used by stamper to cut off all heights below the base. It is the highest point of the stamp around its edges.")]
		public float m_baseLevel;

		[HideInInspector]
		[Range(0.1f, 1f)]
		[Tooltip("Scan resolution in meters. Leave this at smaller values for higher quality scans.")]
		public float m_scanResolution;

		[Tooltip("The material that will be used to display the scan preview. This is just for visualisation and will not affect the scan.")]
		public Material m_previewMaterial;

		private HeightMap m_scanMap;

		private Bounds m_scanBounds;

		private int m_scanWidth;

		private int m_scanDepth;

		private int m_scanHeight;

		private Vector3 m_groundOffset;

		private Vector3 m_groundSize;

		private void OnEnable()
		{
		}

		private void Awake()
		{
		}

		public void Reset()
		{
		}

		public void LoadRawFile(string path, GaiaConstants.RawByteOrder byteOrder, ref GaiaConstants.RawBitDepth bitDepth, ref int resolution)
		{
		}

		public void LoadTextureFile(Texture2D texture)
		{
		}

		public void LoadTerain(Terrain terrain)
		{
		}

		public void LoadGameObject(GameObject go)
		{
		}

		public string SaveScan()
		{
			return null;
		}

		private void UpdateScanner()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
