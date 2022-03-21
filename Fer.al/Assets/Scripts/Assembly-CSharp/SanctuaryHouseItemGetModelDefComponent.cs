using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[ChartComponent("Sanctuary House Item Get Model")]
public class SanctuaryHouseItemGetModelDefComponent : DefComponent
{
	public virtual string BundleID
	{
		get
		{
			return null;
		}
	}

	public virtual QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] Item inItem, [Optional] BaseDef inDef, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetSanctuaryModelRoutine>d__3))]
	private IEnumerator GetSanctuaryModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] Item inItem, [Optional] BaseDef inDef, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}
}
