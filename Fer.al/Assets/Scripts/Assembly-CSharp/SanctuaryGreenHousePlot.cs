using System;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryGreenHousePlot : ManagedBehaviour
{
	public class Selected
	{
		public int boxIndex;

		public int plotIndex;
	}

	private DateTime? _timeToHarvest;

	private Vector3 _startSize;

	private Vector3 _endSize;

	private int? _growTime;

	private GameObject _matured;

	private GameObject _sapling;

	private string _seedDefId;

	public SanctuaryGreenHouseBox.EType type;

	public int boxIndex;

	public int plotIndex;

	public static Selected selected;

	public Action OnPlanted;

	public Action OnMatured;

	public Action OnHarvested;

	public Action OnCleared;

	public static SanctuaryGreenHousePlot Create(Transform inParent, SanctuaryGreenHouseBox.EType inType, int inBoxIndex, int inPlotIndex)
	{
		return null;
	}

	public void Setup(SanctuaryGreenHouseBox.EType inType, int inBoxIndex, int inPlotIndex)
	{
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnGUI()
	{
	}

	public override void MUpdate()
	{
	}

	private void OnSanctuaryGreenhousePlant(SanctuaryGreenhouseTempServer_Plant inMessage)
	{
	}

	private void OnSanctuaryGreenhouseHarvest(SanctuaryGreenhouseClient_SaplingMatured inMessage)
	{
	}

	private void OnSanctuaryGreenhouseWater(SanctuaryGreenhouseTempServer_Water inMessage)
	{
	}

	public void Plant(string inSeedDefId)
	{
	}

	private void SpawnHarvestable()
	{
	}

	public void Harvest()
	{
	}

	public double GetSecondsRemaining()
	{
		return default(double);
	}

	public bool HasPlanted()
	{
		return default(bool);
	}

	public bool CanHarvest()
	{
		return default(bool);
	}

	public bool CanPlant()
	{
		return default(bool);
	}
}
