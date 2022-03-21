using UnityEngine;
using UnityEngine.Rendering;

namespace Gaia
{
	public class GaiaDefaults : ScriptableObject
	{
		[HideInInspector]
		[Tooltip("Unique identifier for these defaults.")]
		public string m_defaultsID;

		[Tooltip("The absolute height of the sea or water table in meters. All spawn criteria heights are calculated relative to this. Used to populate initial sea level in new resources files.")]
		public float m_seaLevel;

		[Tooltip("The beach height in meters. Beaches are spawned at sea level and are extended for this height above sea level. This is used when creating default spawn rules in order to create a beach in the zone between water and land. Only used to populate initial beach height in new resources files.")]
		public float m_beachHeight;

		[HideInInspector]
		[Range(1f, 20f)]
		[Tooltip("Number of tiles in X direction.")]
		public int m_tilesX;

		[HideInInspector]
		[Range(1f, 20f)]
		[Tooltip("Number of tiles in Z direction.")]
		public int m_tilesZ;

		[Space]
		[Header("Base Terrain:")]
		[Space(5f)]
		[Tooltip("The accuracy of the mapping between the terrain maps (heightmap, textures, etc) and the generated terrain; higher values indicate lower accuracy but lower rendering overhead.")]
		[Range(1f, 200f)]
		public int m_pixelError;

		[Tooltip("The maximum distance at which terrain textures will be displayed at full resolution. Beyond this distance, a lower resolution composite image will be used for efficiency.")]
		[Range(0f, 2000f)]
		public int m_baseMapDist;

		[Tooltip("The shadow casting mode for the terrain.")]
		public ShadowCastingMode m_shaodwCastingMode;

		[Tooltip("The material used to render the terrain. This should use a suitable shader, for example Nature/Terrain/Diffuse. The default terrain shader is used if no material is supplied.")]
		public Material m_material;

		[Tooltip("The Physic Material used for the terrain surface to specify its friction and bounce.")]
		public PhysicMaterial m_physicsMaterial;

		[Space]
		[Header("Tree & Detail Objects:")]
		[Space(5f)]
		[Tooltip("Draw trees, grass & details.")]
		public bool m_draw;

		[Tooltip("The distance (from camera) beyond which details will be culled.")]
		[Range(0f, 250f)]
		public int m_detailDistance;

		[Tooltip("The number of detail/grass objects in a given unit of area. The value can be set lower to reduce rendering overhead.")]
		[Range(0f, 1f)]
		public float m_detailDensity;

		[Tooltip("The distance (from camera) beyond which trees will be culled.")]
		[Range(0f, 2000f)]
		public int m_treeDistance;

		[Tooltip("The distance (from camera) at which 3D tree objects will be replaced by billboard images.")]
		[Range(5f, 2000f)]
		public int m_billboardStart;

		[Tooltip("Distance over which trees will transition between 3D objects and billboards.There is often a rotation effect as this kicks in.")]
		[Range(0f, 200f)]
		public int m_fadeLength;

		[Tooltip("The maximum number of visible trees that will be represented as solid 3D meshes. Beyond this limit, trees will be replaced with billboards.")]
		[Range(0f, 10000f)]
		public int m_maxMeshTrees;

		[Space]
		[Header("Wind Settings:")]
		[Space(5f)]
		[Tooltip("The speed of the wind as it blows grass.")]
		[Range(0f, 1f)]
		public float m_speed;

		[Tooltip("The size of the â\u0080\u009cripplesâ\u0080\u009d on grassy areas as the wind blows over them.")]
		[Range(0f, 1f)]
		public float m_size;

		[Tooltip("The degree to which grass objects are bent over by the wind.")]
		[Range(0f, 1f)]
		public float m_bending;

		[Tooltip("Overall color tint applied to grass objects.")]
		public Color m_grassTint;

		[Space]
		[Header("Resolution Settings:")]
		[Space(5f)]
		[Tooltip("The size of terrain tile in X & Z axis (in world units).")]
		public int m_terrainSize;

		[Tooltip("The height of the terrain in world unit meters")]
		public int m_terrainHeight;

		[Tooltip("Pixel resolution of the terrainâ\u0080\u0099s heightmap (should be a power of two plus one e.g. 513 = 512 + 1). Higher resolutions allow for more detailed terrain features, at the cost of poorer performance.")]
		public int m_heightmapResolution;

		[Tooltip("Resolution of the map that determines the separate patches of details/grass. Higher resolution gives smaller and more detailed patches.")]
		public int m_detailResolution;

		[Tooltip("Length/width of the square of patches rendered with a single draw call.")]
		public int m_detailResolutionPerPatch;

		[Tooltip("Resolution of the â\u0080\u009csplatmapâ\u0080\u009d that controls the blending of the different terrain textures. Higher resolutions consumer more memory, but provide more accurate texturing.")]
		public int m_controlTextureResolution;

		[Tooltip("Resolution of the composite texture used on the terrain when viewed from a distance greater than the Basemap Distance (see above).")]
		public int m_baseMapSize;

		public void CreateTerrain()
		{
		}

		public void UpdateFromTerrain()
		{
		}

		public void CreateTerrain(GaiaResource resources)
		{
		}

		public GaiaOperation GetTerrainCreationOperation(GaiaResource resources)
		{
			return null;
		}

		public static Terrain GetActiveTerrain()
		{
			return null;
		}

		private void CreateTile(int tx, int tz, ref Terrain[,] world, GaiaResource resources)
		{
		}

		private void RemoveWorldSeams(ref Terrain[,] world)
		{
		}

		public string GetAndFixDefaults()
		{
			return null;
		}

		public string SerialiseJson()
		{
			return null;
		}

		public void DeSerialiseJson(string json)
		{
		}
	}
}
