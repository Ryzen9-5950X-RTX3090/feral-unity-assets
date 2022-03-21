using UnityEngine;

public class QueensQuestEvent : ManagedBehaviour
{
	[Tooltip("ON if intro is available - OFF if not")]
	public GameObject[] onIfIntroAvailable;

	[Tooltip("OFF if intro is available - ON if not")]
	public GameObject[] offIfIntroAvailable;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnLevelLoaded(Message inMessage)
	{
	}
}
