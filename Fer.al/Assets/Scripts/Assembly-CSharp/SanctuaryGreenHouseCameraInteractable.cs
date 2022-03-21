using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class SanctuaryGreenHouseCameraInteractable : Interactable
{
	[Header("SanctuaryGreenHouseCameraInteractable")]
	public CinemachineVirtualCamera virtualCamera;

	public List<SanctuaryGreenHouseBox> viewableBoxes;

	[SerializeField]
	private SanctuaryGreenHouseBox.EType _cameraType;

	public SanctuaryGreenHouseBox.EType cameraType
	{
		get
		{
			return default(SanctuaryGreenHouseBox.EType);
		}
	}

	public static SanctuaryGreenHouseCameraInteractable Create(Transform inParent, string inInteractableDefId)
	{
		return null;
	}

	public void Setup(string inInteractableDefId)
	{
	}

	public void AddBox(SanctuaryGreenHouseBox inBox)
	{
	}

	public void ClearBoxes()
	{
	}

	public void SetAllowInteraction(bool inAllowInteraction)
	{
	}

	public override void RequestInteraction(EInteractableMessage inInteractableMessage)
	{
	}
}
