using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class SurfaceFXPrefab : ManagedBehaviour
{
	public bool destroyWhenFinished;

	private List<ParticleSystem> _particleSystems;

	private Color? _startingColor;

	private Color? _color;

	private List<FX_ColorizePerSurface> _colorizePerSurfaces;

	private List<ParticleSystem> ParticleSystems
	{
		get
		{
			return null;
		}
	}

	private List<FX_ColorizePerSurface> colorizePerSurfaces
	{
		get
		{
			return null;
		}
	}

	public bool IsPlaying
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsAnyParticleSystemEmitting
	{
		get
		{
			return default(bool);
		}
	}

	private bool IsAnyParticleSystemActive
	{
		get
		{
			return default(bool);
		}
	}

	public void ColorizeParticles([Optional] Color? inColor)
	{
	}

	public void SetLoop(bool inLoop)
	{
	}

	public void Play(bool inIncludeChildren = true)
	{
	}

	public void Stop(bool inIncludeChildren = true)
	{
	}

	[IteratorStateMachine(typeof(<UpdateRoutine>d__19))]
	private IEnumerator UpdateRoutine()
	{
		return null;
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}
}
