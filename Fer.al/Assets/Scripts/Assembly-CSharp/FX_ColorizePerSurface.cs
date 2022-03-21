using System;
using UnityEngine;

public class FX_ColorizePerSurface : ManagedBehaviour
{
	[Serializable]
	public enum ColorModeType
	{
		StartColor = 0,
		TrailsColorOverLifetime = 10
	}

	private ParticleSystem _currentParticleSystem;

	private Color? _surfaceColor;

	private Color? _initialColor;

	public ColorModeType colorMode;

	public ParticleSystem currentParticleSystem
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	public void Colorize(Color? inColor)
	{
	}
}
