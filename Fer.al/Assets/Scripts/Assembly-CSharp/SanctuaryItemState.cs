using System;
using System.Collections.Generic;

[Serializable]
public class SanctuaryItemState
{
	public string stateName;

	[ChartBundle]
	public ChartBundle stateIcon;

	[ChartList]
	[ChartBundle]
	public List<ChartBundle> behaviours;
}
