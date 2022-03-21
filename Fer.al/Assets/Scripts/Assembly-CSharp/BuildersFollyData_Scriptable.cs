using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using UnityEngine;

public class BuildersFollyData_Scriptable : ScriptableObject
{
	public BuildersFollyData.BuildersFollyCameraData[] CameraData;

	public BuildersFollyData.BuildersFollyStationData[] StationData;

	[Header("Level Data")]
	public BuildersFollyLevel_Scriptable TutorialLevel_1;

	public BuildersFollyLevel_Scriptable TutorialLevel_2;

	[Tooltip("Now Normal Levels")]
	public BuildersFollyLevel_Scriptable[] FurnitureLevels;

	public BuildersFollyLevel_Scriptable[] ExpertLevels;

	[DeMethodButton(null, 0, new object[] { })]
	public void TransferDataToPropertyEditor()
	{
	}

	private List<BuildersFollyGoal> GetGoals(BuildersFollyLevel_Scriptable.BuildersFollyGoal[] goals)
	{
		return null;
	}

	internal void SetGoal(ref BuildersFollyGoal refGoal, BuildersFollyLevel_Scriptable.BuildersFollyGoal inLevelGoal)
	{
	}
}
