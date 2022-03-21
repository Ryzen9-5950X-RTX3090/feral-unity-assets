public class SanctuaryGreenhouseTempServer_Plant : Message
{
	public readonly int boxIndex;

	public readonly int plotIndex;

	public readonly string seedDefId;

	public readonly SanctuaryGreenHouseBox.EType type;

	public SanctuaryGreenhouseTempServer_Plant(string inSeedDefId, SanctuaryGreenHouseBox.EType inType, int inBoxIndex, int inPlotIndex)
	{
	}
}
