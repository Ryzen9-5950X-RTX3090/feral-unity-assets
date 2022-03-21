using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

[ManagedBehaviourManager("CinematicManager")]
public class TimelineDialog : ManagedBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _textMesh;

	public void SetDialog(string inDefId)
	{
	}

	[IteratorStateMachine(typeof(<SetDialogCoroutine>d__2))]
	private IEnumerator SetDialogCoroutine(string inDefId)
	{
		return null;
	}
}
