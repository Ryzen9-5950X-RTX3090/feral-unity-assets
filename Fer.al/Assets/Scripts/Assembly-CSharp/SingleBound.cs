using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class SingleBound : PropertyAttribute
{
	private float m_floatBound;

	private int m_intBound;

	public int IntBound
	{
		get
		{
			return default(int);
		}
		protected set
		{
		}
	}

	public float FloatBound
	{
		get
		{
			return default(float);
		}
		protected set
		{
		}
	}

	private Type FixedType
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}
}
