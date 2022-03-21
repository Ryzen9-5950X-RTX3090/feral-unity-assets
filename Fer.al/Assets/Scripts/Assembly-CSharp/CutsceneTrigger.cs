using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
	[SerializeField]
	private Cutscene _cutsceneToPlay;

	private CinematicManager CinematicManager
	{
		get
		{
			return null;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	protected virtual bool IsTriggerConditionMet(Collider other)
	{
		return default(bool);
	}
}
