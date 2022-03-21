using UnityEngine;

public class SpellBoltRefillStation : ManagedBehaviour
{
	public GameObject SpellboltContainerPrefab;

	public FeralAudioInfo RefillSound;

	private static string _blockedPromptTitle;

	private static string _blockedPromptBody;

	public override void MStart()
	{
	}

	public void OnInteract()
	{
	}

	private void DisplayBlockedActionPrompt()
	{
	}

	private SpellBoltContainer GetContainerOnPlayer()
	{
		return null;
	}
}
