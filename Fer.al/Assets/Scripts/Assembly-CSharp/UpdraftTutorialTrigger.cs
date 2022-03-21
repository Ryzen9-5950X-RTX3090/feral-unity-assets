using System.Collections.Generic;
using UnityEngine;

public class UpdraftTutorialTrigger : MonoBehaviour
{
	private bool _isMultiplayerUpdraft;

	private bool _recheckNeeded;

	private bool _listenerAdded;

	private static readonly List<UpdraftTutorialTrigger> _allTriggers;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private bool HasTutorialBeenSeen()
	{
		return default(bool);
	}

	private void OnCustomizerWindowClosed(WindowClosedMessage inMessage)
	{
	}

	private static void TutorialHasBeenSeen()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}
}
