using System.Collections.Generic;

[ChartComponent("Minigame Reward List")]
public class MinigameRewardDefComponent : DefComponent
{
	[ChartList]
	public List<MinigameLootList> lootLists;
}
