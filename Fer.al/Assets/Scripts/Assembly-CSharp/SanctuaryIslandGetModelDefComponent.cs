using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[ChartComponent("Sanctuary Island Get Model")]
public class SanctuaryIslandGetModelDefComponent : DefComponent
{
	public virtual string BundleID
	{
		get
		{
			return null;
		}
	}

	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] Item inItem, [Optional] BaseDef inDef, bool inInSanctuary = false, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetSanctuaryIslandModelRoutine>d__3))]
	private IEnumerator GetSanctuaryIslandModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] Item inItem, [Optional] BaseDef inDef, bool inInSanctuary = false, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}
}
