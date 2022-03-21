using System.Collections.Generic;

[ChartComponent("Minigame")]
public class MinigameDefComponent : DefComponent
{
	[ChartInt]
	public int minPlayers;

	[ChartInt]
	public int maxPlayers;

	[ChartList]
	[ChartInt]
	public List<int> secondsToCompleteEachStage;

	[ChartList]
	public ChartDefList retryPurchaseDefs;
}
