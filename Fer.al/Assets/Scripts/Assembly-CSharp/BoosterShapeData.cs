using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoosterShapeData : ScriptableObject
{
	[ChartEnum]
	public BoosterType boosterType;

	[ChartList]
	public List<BoosterMatchOffsetList> variations;
}
