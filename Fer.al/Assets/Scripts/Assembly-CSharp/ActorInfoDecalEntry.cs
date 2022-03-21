using System;

[Serializable]
public class ActorInfoDecalEntry
{
	[RootSelector("Actor Decal", "ActorDecalChartData", false, false)]
	public string defID;

	[ChartBool]
	public bool isDefault;

	[ChartBool]
	public bool disabled;

	public Action<bool> OnDecalVisibilityChanged;

	[ChartVector2]
	public StringSerializableVector2 position;

	[ChartVector2]
	public StringSerializableVector2 mirroredPosition;

	[ChartHSV]
	public HSVColor color1HSV;

	[ChartString]
	public string rotation;

	[ChartString]
	public string rotationCompensation;

	[ChartString]
	public string mirrorRotationCompensation;

	[ChartString]
	public string scale;

	[NonSerialized]
	public float alpha;

	[ChartBool]
	public bool flipX;

	[ChartBool]
	public bool flipY;

	[ChartBool]
	public bool mirror;

	public float Rotation
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float RotationCompensation
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float MirrorRotationCompensation
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float Scale
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool IsEye
	{
		get
		{
			return default(bool);
		}
	}
}
