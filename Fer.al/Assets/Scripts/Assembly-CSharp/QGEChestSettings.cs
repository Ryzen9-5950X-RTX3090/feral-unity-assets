using System;

public class QGEChestSettings : MonoBehaviour
{
	public enum RingSize
	{
		Easy = 3,
		Medium = 2,
		Hard = 1,
		Expert = 0,
		Disabled = -1
	}

	public enum RingSpeed
	{
		Speed1 = 75,
		Speed2 = 90,
		Speed3 = 105,
		Speed4 = 120,
		Speed5 = 135,
		Speed6 = 150,
		Speed7 = 165,
		Speed8 = 180,
		Speed9 = 195,
		Speed10 = 210,
		Speed11 = 225
	}

	[Serializable]
	public class RingInfo
	{
		[ChartEnum]
		public RingSize ringSize;

		[ChartEnum]
		public RingSpeed ringSpeed;
	}

	[Serializable]
	public class ChestLevel
	{
		[ChartClassHorizontal]
		public RingInfo ring1;

		[ChartClassHorizontal]
		public RingInfo ring2;

		[ChartClassHorizontal]
		public RingInfo ring3;

		[ChartClassHorizontal]
		public RingInfo ring4;

		[ChartClassHorizontal]
		public RingInfo ring5;

		[ChartClassHorizontal]
		public RingInfo ring6;
	}

	[RootSelectorCompact("Chest Settings Def", "GlobalChartData", null, false, false)]
	public string chestSettingsDefId;

	public bool debugChest;

	public const int kMaxRingsPerLevel = 6;

	private QGEChestDefComponent _chestSettingsDef;

	public QGEChestDefComponent ChestSettings
	{
		get
		{
			return null;
		}
	}

	public int GetAvailalbeLockPickCount()
	{
		return default(int);
	}

	public int GetLevelCount()
	{
		return default(int);
	}

	public int GetChestTypeIndex()
	{
		return default(int);
	}

	public RingInfo GetLevelRing(int inLevel, int inRing)
	{
		return null;
	}

	public int GetLevelRingCount(int inLevel)
	{
		return default(int);
	}
}
