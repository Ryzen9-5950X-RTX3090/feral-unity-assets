using System;
using UnityEngine;

public class FX_ConformColorsToActorShader : ManagedBehaviour
{
	[Serializable]
	public enum ColorModeType
	{
		StartColor = 0,
		TrailsColorOverLifetime = 10
	}

	public Renderer sourceRenderer;

	public int colorID;

	public float alpha;

	public ColorModeType colorMode;

	private string _colorIDProperty;

	private ParticleSystem _currentParticleSystem;

	private float _timer;

	private Vector4? _lastColor;

	private string ColorIDProperty
	{
		get
		{
			return null;
		}
	}

	public ParticleSystem CurrentParticleSystem
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	public void ApplyColors()
	{
	}
}
