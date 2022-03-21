using UnityEngine;

public class QuestGeyser : MonoBehaviour
{
	public ParticleSystem mainParticleFX;

	private QuestGeyserManager _manager;

	public Collider triggerCollider;

	private float _randomTimeOn;

	private float _randomTimeOff;

	private void OnDrawGizmosSelected()
	{
	}

	internal void UpdateGeyserTime(float inDeltaTime)
	{
	}

	internal void InitGeyser()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	internal void Activate()
	{
	}

	internal void Deactivate()
	{
	}
}
