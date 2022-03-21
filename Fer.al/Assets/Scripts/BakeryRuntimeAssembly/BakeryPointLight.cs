using UnityEngine;

[ExecuteInEditMode]
[DisallowMultipleComponent]
public class BakeryPointLight : MonoBehaviour
{
	public enum ftLightProjectionMode
	{
		Omni,
		Cookie,
		Cubemap,
		IES
	}

	public int UID;

	public Color color;

	public float intensity;

	public float shadowSpread;

	public float cutoff;

	public bool realisticFalloff;

	public int samples;

	public ftLightProjectionMode projMode;

	public Texture2D cookie;

	public float angle;

	public Cubemap cubemap;

	public Object iesFile;

	public int bitmask;

	public bool bakeToIndirect;

	public bool shadowmask;

	public float indirectIntensity;
}
