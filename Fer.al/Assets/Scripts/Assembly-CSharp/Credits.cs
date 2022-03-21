using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Credits : MonoBehaviour
{
	[SerializeField]
	private float _fadeInTimer;

	[SerializeField]
	private float _holdTimer;

	[SerializeField]
	private float _fadeOutTimer;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(<TransToSplash>d__5))]
	private IEnumerator TransToSplash()
	{
		return null;
	}
}
