using UnityEngine;
using UnityEngine.Events;

public class InMainCameraView : ManagedBehaviour
{
	public enum EState
	{
		OFFSCREEN,
		ONSCREEN
	}

	[SerializeField]
	private Renderer _triggerer;

	private EState _state;

	[SerializeField]
	private UnityEvent OnOnScreen;

	[SerializeField]
	private UnityEvent OnOffScreen;

	public override void MUpdate()
	{
	}

	private void OnScreen()
	{
	}

	private void OffScreen()
	{
	}
}
