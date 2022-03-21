using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_GainHarvestableFX : MonoBehaviour
{
	[SerializeField]
	private UI_Window _window;

	[SerializeField]
	private RectTransform _parent;

	[SerializeField]
	private WWImage _imagePrefab;

	[SerializeField]
	private RectTransform _target;

	[SerializeField]
	private FeralAudioInfo _harvestFXAudio;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnInteractableHarvested(InteractableHarvestedMessage inMessage)
	{
	}

	[IteratorStateMachine(typeof(<DoHarvestFX>d__8))]
	private IEnumerator DoHarvestFX(InteractableHarvestedMessage inMessage)
	{
		return null;
	}
}
