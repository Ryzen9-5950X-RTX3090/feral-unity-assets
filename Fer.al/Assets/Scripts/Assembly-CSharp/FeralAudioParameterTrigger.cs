using FMODUnity;
using UnityEngine;

public class FeralAudioParameterTrigger : ManagedBehaviour
{
	[Header("Audio - Event Data")]
	public FeralEmitterGameEvent triggerEvent;

	public string collisionTag;

	[Header("Audio - Emitter Parameters")]
	public FeralAudioEmitter emitter;

	public ParamRef[] Parameters;

	[Header("Audio - Quest Completion")]
	[RootSelector("Quest Id", "QuestChartData", false, false)]
	public string questId;

	public FeralAudioEmitter questCompletionEmitter;

	[SerializeField]
	private ParamRef[] questCompletionParameters;

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void OnCollisionEnter()
	{
	}

	private void OnCollisionExit()
	{
	}

	private void OnCollisionEnter2D()
	{
	}

	private void OnCollisionExit2D()
	{
	}

	private void HandleGameEvent(FeralEmitterGameEvent gameEvent)
	{
	}

	private void TriggerParameter()
	{
	}
}
