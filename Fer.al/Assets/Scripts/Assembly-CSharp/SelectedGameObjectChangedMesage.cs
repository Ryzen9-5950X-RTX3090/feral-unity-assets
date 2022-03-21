using UnityEngine;

public class SelectedGameObjectChangedMesage : Message
{
	public readonly GameObject previousSelectedGameObject;

	public readonly GameObject currentlySelectedGameObject;

	public SelectedGameObjectChangedMesage(GameObject inPrevious, GameObject inCurrent)
	{
	}
}
