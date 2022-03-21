using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestActorCustomizer : ManagedBehaviour
{
	private bool _visible;

	private Vector2 _scrollPos;

	private EventSystem _rewiredEventSystem;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<MoveToBottom>d__4))]
	private IEnumerator MoveToBottom()
	{
		return null;
	}

	private void OnGUI()
	{
	}

	private void OnWindow(int inID)
	{
	}
}
