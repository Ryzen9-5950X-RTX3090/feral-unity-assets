using Boxophobic;
using UnityEngine;

public class ADSGlobalSettings : MonoBehaviour
{
	public enum UpdateMode
	{
		Off,
		On
	}

	public enum GlobalSettingEnum
	{
		Simple,
		Seasons
	}

	[BCategory("Update")]
	public int category_Update;

	public UpdateMode realtimeUpdate;

	[BCategory("Globals")]
	public int category_Globals;

	public Texture2D globalTexture;

	public Vector4 globalSizeCenter;

	[Space]
	public GlobalSettingEnum globalSettings;

	[BCategory("Globals Simple")]
	public int category_Simple;

	[BInteractive(1)]
	public int InteractiveGlobalsSimple;

	[Range(0f, 8f)]
	public float globalTintIntensity;

	public Color globalTintColorOne;

	public Color globalTintColorTwo;

	[Range(0f, 1f)]
	public float globalLeavesAmount;

	[Range(0f, 1f)]
	public float globalLeavesVar;

	[Range(0f, 1f)]
	public float globalSizeMin;

	[Range(0f, 1f)]
	public float globalSizeMax;

	[BCategory("Globals Seasons (Experimental)")]
	public int category_Seasons;

	[BInteractive(1)]
	public int InteractiveGlobalsSeasons;

	public float season;

	[Space]
	[Space(10f)]
	[Range(0f, 8f)]
	public float winterTintIntensity;

	public Color winterTintColorOne;

	public Color winterTintColorTwo;

	[Range(0f, 1f)]
	public float winterLeavesAmount;

	[Range(0f, 1f)]
	public float winterLeavesVar;

	[Range(0f, 1f)]
	public float winterSizeMin;

	[Range(0f, 1f)]
	public float winterSizeMax;

	[Space]
	[Space(10f)]
	[Range(0f, 8f)]
	public float springTintIntensity;

	public Color springTintColorOne;

	public Color springTintColorTwo;

	[Range(0f, 1f)]
	public float springLeavesAmount;

	[Range(0f, 1f)]
	public float springLeavesVar;

	[Range(0f, 1f)]
	public float springSizeMin;

	[Range(0f, 1f)]
	public float springSizeMax;

	[Space]
	[Space(10f)]
	[Range(0f, 8f)]
	public float summerTintIntensity;

	public Color summerTintColorOne;

	public Color summerTintColorTwo;

	[Range(0f, 1f)]
	public float summerLeavesAmount;

	[Range(0f, 1f)]
	public float summerLeavesVar;

	[Range(0f, 1f)]
	public float summerSizeMin;

	[Range(0f, 1f)]
	public float summerSizeMax;

	[Space]
	[Space(10f)]
	[Range(0f, 8f)]
	public float autumnTintIntensity;

	public Color autumnTintColorOne;

	public Color autumnTintColorTwo;

	[Range(0f, 1f)]
	public float autumnLeavesAmount;

	[Range(0f, 1f)]
	public float autumnLeavesVar;

	[Range(0f, 1f)]
	public float autumnSizeMin;

	[Range(0f, 1f)]
	public float autumnSizeMax;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void SetGlobalShaderProperties()
	{
	}
}
