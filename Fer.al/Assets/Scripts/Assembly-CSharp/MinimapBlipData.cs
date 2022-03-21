using UnityEngine;

[CreateAssetMenu]
public class MinimapBlipData : ScriptableObject
{
	[Range(-1f, 99f)]
	[Tooltip("What child index should the blip have. Layers on other blips.")]
	public int blipPriority;

	[Tooltip("What blip to use in the minimap")]
	public GameObject blipObject;

	[Tooltip("Rotate to facing direction - ie: players, npc, friends")]
	public bool rotateToFacing;

	[Tooltip("Show outside of minimap to stop state state transitions - ie: area blip")]
	public bool showOutsideOfMap;

	[Tooltip("Always show in fullscreen map")]
	public bool forceShowInFullscreenMap;

	[Tooltip("Whether or not to scale the blip up or down based upon zoom")]
	public bool freezeScale;

	[Tooltip("Scale within minimap")]
	public float insideMapScale;

	[Tooltip("What blip to use when it leaves the minimap")]
	public GameObject blipObjectOutsideMap;

	[Tooltip("Face egde of map - ie: directional arrows")]
	public bool blipObjectOutsideMapRotateToMapEdge;

	[Tooltip("Scale outside minimap")]
	public float outsideMapScale;

	[Tooltip("Clamp to edge of minimap - not allowing it to transition off - ie: quest objective marker")]
	public bool clampToEdge;

	[Tooltip("What range should the blip hide outside of the minimap")]
	public float outsideHideDistance;

	[Tooltip("Object that rotate around the hud")]
	public GameObject blipIndicator;

	[Tooltip("Does the indicator points to the object")]
	public bool blipIndicatorRotateToEdge;

	[Tooltip("Alpha of indicator")]
	public float blipIndicatorAlpha;

	[Tooltip("Scale of the indicator")]
	public float indicatorScale;

	[Tooltip("What range should the indicator turn off")]
	public float indicatorHideDistance;
}
