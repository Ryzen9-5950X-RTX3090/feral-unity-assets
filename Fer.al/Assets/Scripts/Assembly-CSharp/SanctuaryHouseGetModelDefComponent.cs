using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

[ChartComponent("Sanctuary House Get Model")]
public class SanctuaryHouseGetModelDefComponent : GetModelDefComponent
{
	public enum EHouseMod
	{
		None,
		Base,
		Edge,
		Decor,
		Shrub,
		Door,
		Light,
		Roof,
		Window
	}

	private int ModifyIdx(int inIdx, int inMax)
	{
		return default(int);
	}

	protected override IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<GameObject> inResult, [Optional] string inForcedModelID, [Optional] Item inItem, [Optional] BaseDef inDef, [Optional] BaseInfo inInfo, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}

	private void ChangeFromStandardShaderToFeralUnlit(GameObject inGameObject)
	{
	}

	public QRoutine GetHouseMod(GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, [Optional] Item inItem, [Optional] BaseDef inDef, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetHouseModsRoutine>d__5))]
	private IEnumerator GetHouseModsRoutine(GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, [Optional] Item inItem, [Optional] BaseDef inDef, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadHouseModComponent>d__6))]
	private IEnumerator LoadHouseModComponent(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, EHouseMod inType, Action<GameObject> inGameObject, int inModIndex = -1)
	{
		return null;
	}

	public QRoutine GetModel(GameObject inTargetGameObject, Transform inParentTransform, Action<List<GameObject>> inBases, [Optional] Item inItem, [Optional] BaseDef inDef, bool inInSanctuary = false, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetModelRoutine>d__8))]
	private IEnumerator GetModelRoutine(GameObject inTargetGameObject, Transform inParentTransform, Action<List<GameObject>> inBases, [Optional] Item inItem, [Optional] BaseDef inDef, bool inInSanctuary = false, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadLayoutData>d__9))]
	private IEnumerator LoadLayoutData(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, HouseItemComponent inHouseItemComponent, GameObject inTargetGameObject)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<LoadHouseComponents>d__10))]
	private IEnumerator LoadHouseComponents(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, bool inInSanctuary, int inExpansionIndex, int inModIndex)
	{
		return null;
	}

	private bool ValidNameAndIndex(Transform inTransform, int inIdx)
	{
		return default(bool);
	}

	private SanctuaryHouseDefComponent.Expansion GetExpansionIndex(List<SanctuaryHouseDefComponent.Expansion> inExpansion, int inIndex)
	{
		return null;
	}

	private bool GetLocatorEnabled(Transform inTransform, int inExpansionIndex)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<BuildBases>d__14))]
	private IEnumerator BuildBases(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inParent, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildEdges>d__15))]
	private IEnumerator BuildEdges(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildShrubs>d__16))]
	private IEnumerator BuildShrubs(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildDecor>d__17))]
	private IEnumerator BuildDecor(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildDoors>d__18))]
	private IEnumerator BuildDoors(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, bool inInSanctuary, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildLights>d__19))]
	private IEnumerator BuildLights(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildRoofs>d__20))]
	private IEnumerator BuildRoofs(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<BuildWindows>d__21))]
	private IEnumerator BuildWindows(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inBase, int inExpansionIdx, Action<List<GameObject>> inGameObjects, int inModIndex = -1)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<SpawnComponent>d__22))]
	private IEnumerator SpawnComponent(SanctuaryHouseDefComponent inSanctuaryHouseDefComponent, GameObject inTargetGameObject, Transform inParentTransform, ChartDef inChartDef, int iExpansionIndex, [Optional] Action<GameObject> inResult, int inModIndex = -1)
	{
		return null;
	}

	public static int GetIndex(Transform inTransform)
	{
		return default(int);
	}
}
