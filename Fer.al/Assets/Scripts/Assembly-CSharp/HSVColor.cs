using System;
using UnityEngine;

[Serializable]
public struct HSVColor : ISerializationCallbackReceiver
{
	private bool _colorIsConverted;

	private Color _color;

	[SerializeField]
	private string _h;

	[SerializeField]
	private string _s;

	[SerializeField]
	private string _v;

	[SerializeField]
	private string _hsv;

	private float _hFloat;

	private float _sFloat;

	private float _vFloat;

	public Color Color
	{
		get
		{
			return default(Color);
		}
	}

	private string HSV
	{
		get
		{
			return null;
		}
	}

	public float H
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float S
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float V
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	private void ConvertToNewFormat()
	{
	}

	public HSVColor(HSVColor inColor)
	{
	}

	public HSVColor(float h, float s, float v)
	{
	}

	public HSVColor(Color rgbColor)
	{
	}

	public override bool Equals(object obj)
	{
		return default(bool);
	}

	public static bool operator ==(HSVColor a, HSVColor b)
	{
		return default(bool);
	}

	public static bool operator !=(HSVColor a, HSVColor b)
	{
		return default(bool);
	}

	public override int GetHashCode()
	{
		return default(int);
	}

	public Vector4 ToVector4()
	{
		return default(Vector4);
	}

	public static HSVColor Random()
	{
		return default(HSVColor);
	}

	public static HSVColor RandomDark()
	{
		return default(HSVColor);
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
