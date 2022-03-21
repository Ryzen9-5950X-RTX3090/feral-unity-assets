using System;
using System.Collections.Generic;

[Serializable]
public class ParlorGameListEntry
{
	[ChartEnum]
	public ParlorManager.EParlorGame parlorGame;

	[ChartInt]
	public int maxBet;

	[ChartList]
	[ChartInt]
	public List<int> additionalParameters;
}
