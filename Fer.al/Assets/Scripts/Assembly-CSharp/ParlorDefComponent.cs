using System.Collections.Generic;

[ChartComponent("Parlor")]
public class ParlorDefComponent : DefComponent
{
	[ChartList]
	public List<ParlorGameListEntry> parlorGames;
}
