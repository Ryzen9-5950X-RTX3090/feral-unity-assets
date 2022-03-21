using System;
using UnityEngine;

public class OSShaderSwap : ManagedBehaviour
{
	[Serializable]
	public class ShaderSwap
	{
		public string shaderName;

		public RuntimePlatform[] platforms;
	}

	[SerializeField]
	private ShaderSwap[] _shaderSwap;

	public override void MStart()
	{
	}

	private void AssignShader(ShaderSwap inShaderSwap)
	{
	}
}
