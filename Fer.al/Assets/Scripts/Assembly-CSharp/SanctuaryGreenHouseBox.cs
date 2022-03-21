using UnityEngine;

public class SanctuaryGreenHouseBox : ManagedBehaviour
{
	public enum EType
	{
		None,
		Planter,
		Community
	}

	public SanctuaryGreenHousePlot[] plots;

	public EType boxType;

	public int boxIndex;

	public int upgradeIndex;

	private Transform _group;

	public Transform group
	{
		get
		{
			return null;
		}
	}

	public static SanctuaryGreenHouseBox Create(int inUpgradeIndex, Transform inParent, string inPlotName, int inBoxIndex, EType inType)
	{
		return null;
	}

	public void Setup(string inPlotName, int inUpgradeIndex, int inBoxIndex, EType inType)
	{
	}

	private bool Unlocked()
	{
		return default(bool);
	}

	private void OnGUI()
	{
	}

	private void Unlock()
	{
	}
}
