using System;
using System.Collections;
using System.Runtime.CompilerServices;

public class TempLoadScene : ManagedBehaviour
{
	[Serializable]
	public class SceneInfo
	{
		[RootSelector("AdditiveLevelDefId", "LevelOverrideChartData", false, false)]
		public string levelAdditiveDefId;
	}

	public SceneInfo[] sceneInfos;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<LoadLevelAdditiveRoutine>d__3))]
	private IEnumerator LoadLevelAdditiveRoutine(LevelOverrideDefComponent inLevelAdditiveDef)
	{
		return null;
	}
}
