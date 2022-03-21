using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class GetModelDefComponent : DefComponent
{
	[ChartBool]
	public bool useStageOverrides;

	[ChartFloat]
	public float stageOverrideScale;

	[ChartVector3]
	public Vector3 stageOverrideOffset;

	[ChartVector3]
	public Vector3 stageOverrideRotation;

	public virtual string BundleID
	{
		get
		{
			return null;
		}
	}

	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] string inForcedModelID, [Optional] Item inItem, [Optional] BaseDef inDef, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetModelRoutine>d__7))]
	protected virtual IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] string inForcedModelID, [Optional] Item inItem, [Optional] BaseDef inDef, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}

	protected override void LoadEntry()
	{
	}
}
