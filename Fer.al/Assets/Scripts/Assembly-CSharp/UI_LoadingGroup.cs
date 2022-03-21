using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using UnityEngine;

[DeComponentDescription("Toggles groups of objects on/off depending on an externally provided loading state")]
public class UI_LoadingGroup : MonoBehaviour
{
	[SerializeField]
	[DeComment("ON during loading", 3)]
	private List<GameObject> _loadingObjectsOn;

	[SerializeField]
	[DeComment("OFF during loading", 3)]
	private List<GameObject> _loadingObjectsOff;

	private bool _isLoading;

	private void OnEnable()
	{
	}

	public void SetIsLoading(bool inIsLoading)
	{
	}

	private void UpdateObjects()
	{
	}
}
