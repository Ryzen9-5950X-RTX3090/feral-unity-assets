using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryGreenHouse : ManagedBehaviour
{
	public SanctuaryGreenHouseInterior interior;

	public SanctuaryGreenHouseExterior exterior;

	public bool insideGreenhouse;

	public bool onGreenhouseIsland;

	public GameObject _island;

	public Transform _placementNode;

	public Transform _blockerNode;

	public Transform _bridgeNode;

	public static SanctuaryGreenHouse instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Setup(string inDefId, GameObject inIsland)
	{
	}

	public void EnableBridge(bool inActive)
	{
	}

	[IteratorStateMachine(typeof(<SpawnGreenhouse>d__14))]
	private IEnumerator SpawnGreenhouse(string inDefId)
	{
		return null;
	}

	private void SpawnGreenHouseTriggerVolume()
	{
	}

	private void SpawnGreenhouseInterior(BaseDef inBaseDef)
	{
	}

	private void SpawnGreenhouseExterior(BaseDef inBaseDef)
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnSanctuaryGreenhouseEntered(SanctuaryGreenhouseClient_Entered inMessage)
	{
	}

	private void OnSanctuaryGreenhouseIslandEntered(SanctuaryGreenhouseClient_IslandEntered inMessage)
	{
	}

	private void OnSanctuaryGreenhouseWater(SanctuaryGreenhouseClient_Water inMessage)
	{
	}

	private void OnSanctuaryGreenhouseUpgrade(SanctuaryGreenhouseClient_Upgrade inMessage)
	{
	}

	private void OnSanctuaryGreenhousePlant(SanctuaryGreenhouseClient_Plant inMessage)
	{
	}
}
