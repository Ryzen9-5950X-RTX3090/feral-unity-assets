using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

public class Match3LevelObjectiveTracker : MonoBehaviour
{
	public IntEvent removeBlockersObjectiveStarted;

	public IntEvent specialOrderObjectiveStarted;

	[Header("Events")]
	public VoidEvent orderCompleteEvent;

	public VoidEvent orderCompleteEvent_Combo;

	public VoidEvent orderCompleteEvent_RushHour;

	public VoidEvent orderCompleteEvent_ShortStaffed;

	public VoidEvent orderCompleteEvent_SpecialItems;

	private List<Match3LevelObjectiveTrackingInfo> _tracking;

	public bool AllObjectivesComplete
	{
		get
		{
			return default(bool);
		}
	}

	public Match3LevelObjectiveTrackingInfo ScoreTrackingInfo
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void ClearTrackedObjectives()
	{
	}

	public bool IsTrackingObjective(Match3LevelObjectiveType inObjectiveType)
	{
		return default(bool);
	}

	public Match3LevelObjectiveTrackingInfo GetTrackingInfoByType(Match3LevelObjectiveType inObjectiveType)
	{
		return null;
	}

	public void SetLevelObjectives(int inLevelNumber, List<Match3LevelObjectiveTrackingInfo> inTrackedObjectives, bool doObjectiveBoardEffects, bool forceVisualEffectUpdate = false)
	{
	}

	public void OnLevelStart(int inLevelIndex)
	{
	}

	public void OnObjectiveUpdated_Score(int inAddScore)
	{
	}

	public void OnObjectiveUpdated_TileTypeRemoved(Match3TileType inType, int inCount)
	{
	}

	public void OnObjectiveUpdated_BlockerRemoved()
	{
	}

	public void OnObjectiveUpdated_SpecialOrderRemoved()
	{
	}

	public void OnObjectiveComplete(Match3LevelObjectiveTrackingInfo inTrack)
	{
	}

	public void TriggerOrderCompleteEvents()
	{
	}
}
