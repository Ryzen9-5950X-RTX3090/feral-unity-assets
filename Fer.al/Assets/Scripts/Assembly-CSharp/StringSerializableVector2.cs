using System;
using UnityEngine;

[Serializable]
public class StringSerializableVector2
{
	public string x;

	public string y;

	public float xFloat
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float yFloat
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public StringSerializableVector2(Vector2 inVector2)
	{
	}

	public Vector2 ToVector2()
	{
		return default(Vector2);
	}

	public Vector3 ToVector3()
	{
		return default(Vector3);
	}

	public static implicit operator Vector2(StringSerializableVector2 inObj)
	{
		return default(Vector2);
	}

	public static implicit operator Vector3(StringSerializableVector2 inObj)
	{
		return default(Vector3);
	}

	public static implicit operator StringSerializableVector2(Vector2 inObj)
	{
		return null;
	}
}
