using System;
using System.Runtime.InteropServices;
using UnityEngine;

[ChartComponent("Icon 3D")]
public class Icon3DDefComponent : DefComponent
{
	[ChartVector3]
	public Vector3 rotation;

	[ChartBool]
	public bool useAutoCentering;

	[ChartFloat]
	public float scale;

	[ChartVector3]
	public Vector3 offset;

	public QRoutine Get3DIconModel(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] Item inItem, [Optional] BaseDef inDef, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}
}
