using UnityEngine;

[ManagedBehaviourManager("FeralAudioManager")]
public class FeralAudioEmitterFx : FeralAudioEmitter
{
	private ParticleSystem _particleSystem;

	private bool _hasParticleSystem;

	private bool? _emitting;

	[SerializeField]
	private bool _playOnPlayer;

	public override void MStart()
	{
	}

	public void ParticleSystemStopped()
	{
	}

	public void ParticleSystemStarted()
	{
	}

	public void OnParticleCollision(GameObject other)
	{
	}

	public override void MUpdate()
	{
	}

	public override void MOnDisable()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void UpdateParticleSystem(bool inDisable = false)
	{
	}
}
