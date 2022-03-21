using System;
using System.Collections.Generic;

[Serializable]
public class BoosterShapeDataForDef
{
	[ChartEnum]
	public BoosterType boosterType;

	[ChartList]
	public List<BoosterMatchOffsetList> variations;
}
