using System.Collections.Generic;
using UnityEngine;

public class SanctuaryGreenHouseInterior : ManagedBehaviour
{
	public List<Transform> upgrades;

	public List<SanctuaryGreenHouseBox> sanctuaryGreenHouseBoxes;

	public Transform spawn;

	public List<Transform> exitVolumes;

	public List<Transform> cameraMounts;

	public List<Transform> cameraInteracts;

	public List<SanctuaryGreenHouseCameraInteractable> cameraInteractables;

	private Vector2 _scroll;

	private Rect _guiWindowRect;

	private int _tempSeedSelection;

	private List<BaseDef> _tempSeeds;

	[RootSelector("Greenhouse", "CraftableItemChartData", false, false)]
	public string greenhouseDefId;

	private int _upgradeIndex;

	private SanctuaryGreenHouseCameraInteractable _activeGreenhouseCamera;

	private List<BaseDef> tempSeeds
	{
		get
		{
			return null;
		}
	}

	public int upgradeIndex
	{
		get
		{
			return default(int);
		}
	}

	public SanctuaryGreenHouseCameraInteractable activeGreenhouseCamera
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void TeleportToSpawn()
	{
	}

	public void EnableCamera(SanctuaryGreenHouseCameraInteractable inSanctuaryGreenHouseCameraInteractable)
	{
	}

	private void OnSanctuaryGreenhouseUpgrade(SanctuaryGreenhouseTempServer_Upgrade inMessage)
	{
	}

	private void SetUpgradesActive()
	{
	}

	private void OnSanctuaryGreenhouseWater(SanctuaryGreenhouseTempServer_Water inMessage)
	{
	}

	private void SetupCameraInteracts(SanctuaryGreenhouseDefComponent inDefComponent)
	{
	}

	private void SetupBoxes(int inUpgradeIndex, SanctuaryGreenhouseDefComponent inDefComponent, string inName, SanctuaryGreenHouseBox.EType inType)
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void OnTriggerExit(Collider inCollider)
	{
	}

	private bool CanWater()
	{
		return default(bool);
	}

	private void CreateMeshColliders()
	{
	}

	private void CreateInteriorVolumeTrigger()
	{
	}

	private void DestroyMeshRenderer(GameObject inGameObject)
	{
	}

	private void SpawnInteriorDoors()
	{
	}
}
