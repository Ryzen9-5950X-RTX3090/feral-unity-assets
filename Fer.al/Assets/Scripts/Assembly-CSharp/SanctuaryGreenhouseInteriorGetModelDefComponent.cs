using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[ChartComponent("Sanctuary Greenhouse Interior Get Model")]
public class SanctuaryGreenhouseInteriorGetModelDefComponent : GetModelDefComponent
{
	[IteratorStateMachine(typeof(<GetModelRoutine>d__0))]
	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] string inForcedModelID, [Optional] Item inItem, [Optional] BaseDef inDef, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}
}
