using UnityEngine;

[CreateAssetMenu]
public class BakeryLightmapGroup : ScriptableObject
{
	public enum ftLMGroupMode
	{
		OriginalUV,
		PackAtlas,
		Vertex
	}

	public enum RenderMode
	{
		FullLighting = 0,
		Indirect = 1,
		Shadowmask = 2,
		Auto = 1000
	}

	public enum RenderDirMode
	{
		None = 0,
		BakedNormalMaps = 1,
		DominantDirection = 2,
		RNM = 3,
		SH = 4,
		ProbeSH = 5,
		Auto = 1000
	}

	[SerializeField]
	[Range(1f, 8192f)]
	public int resolution;

	[SerializeField]
	public int bitmask;

	[SerializeField]
	public int id;

	public int sortingID;

	[SerializeField]
	public bool isImplicit;

	[SerializeField]
	public float area;

	[SerializeField]
	public int totalVertexCount;

	[SerializeField]
	public int vertexCounter;

	[SerializeField]
	public int sceneLodLevel;

	[SerializeField]
	public string sceneName;

	[SerializeField]
	public bool containsTerrains;

	[SerializeField]
	public bool probes;

	[SerializeField]
	public ftLMGroupMode mode;

	[SerializeField]
	public RenderMode renderMode;

	[SerializeField]
	public RenderDirMode renderDirMode;

	[SerializeField]
	public bool computeSSS;

	[SerializeField]
	public int sssSamples;

	[SerializeField]
	public float sssDensity;

	[SerializeField]
	public Color sssColor;

	public BakeryLightmapGroupPlain GetPlainStruct()
	{
		return default(BakeryLightmapGroupPlain);
	}
}
