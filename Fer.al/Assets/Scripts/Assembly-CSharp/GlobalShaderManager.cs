using System;
using System.Collections.Generic;
using UnityEngine;

public class GlobalShaderManager : SingletonManagerBase<GlobalShaderManager>
{
	public abstract class ShaderPropertyBase
	{
		public string propertyName;

		public abstract void Apply(Material inMaterial);
	}

	[Serializable]
	public class ShaderTexture : ShaderPropertyBase
	{
		public Texture2D texture;

		public override void Apply(Material inMaterial)
		{
		}
	}

	[Serializable]
	public class ShaderZeroOneRange : ShaderPropertyBase
	{
		[Range(0f, 1f)]
		public float value;

		public override void Apply(Material inMaterial)
		{
		}
	}

	[Serializable]
	public class ShaderFloat : ShaderPropertyBase
	{
		public float value;

		public override void Apply(Material inMaterial)
		{
		}
	}

	[Serializable]
	public class ShaderVector : ShaderPropertyBase
	{
		public Vector3 value;

		public override void Apply(Material inMaterial)
		{
		}
	}

	public List<ShaderTexture> textures;

	public List<ShaderZeroOneRange> ranges;

	public List<ShaderFloat> floats;

	public List<ShaderVector> vectors;

	private List<ShaderPropertyBase> AllProperties
	{
		get
		{
			return null;
		}
	}

	public void ApplyToMaterial(Material inMaterial)
	{
	}
}
