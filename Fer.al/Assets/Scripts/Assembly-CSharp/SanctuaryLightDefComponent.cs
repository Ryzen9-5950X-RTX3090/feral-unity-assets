using UnityEngine;

[ChartComponent("Sanctuary Light")]
public class SanctuaryLightDefComponent : DefComponent
{
	[ChartColor]
	public Color color;

	[SerializeField]
	[ChartMinMax(0.5f, 1.5f)]
	private Vector2 _minMaxBrightness;

	[ChartBool]
	public bool isBlank;

	public const string DEFID_DEFAULT_EXTERIOR = "12553";

	public const string DEFID_DEFAULT_INTERIOR = "12555";

	public float MinBrightness
	{
		get
		{
			return default(float);
		}
	}

	public float MaxBrightness
	{
		get
		{
			return default(float);
		}
	}
}
