using UnityEngine;

public struct HSLColor
{
	public float h;

	public float s;

	public float l;

	public float a;

	public HSLColor(float h, float s, float l, float a)
	{
	}

	public HSLColor(float h, float s, float l)
	{
	}

	public HSLColor(Color c)
	{
	}

	public static HSLColor FromRGBA(Color c)
	{
		return default(HSLColor);
	}

	public Color ToRGBA()
	{
		return default(Color);
	}

	private static float Value(float n1, float n2, float hue)
	{
		return default(float);
	}

	public static implicit operator HSLColor(Color src)
	{
		return default(HSLColor);
	}

	public static implicit operator Color(HSLColor src)
	{
		return default(Color);
	}
}
