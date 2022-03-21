using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BoosterMatchOffsetList
{
	[ChartList]
	[ChartVector2Int]
	public List<Vector2Int> offsets;
}
