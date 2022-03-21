using System;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityAtoms;

[Serializable]
public class Match3Achievement : IAtomListener<ObscuredInt, ObscuredInt>
{
	[ChartEnum]
	public Match3AchievementType achievementType;

	[ChartInt]
	public int threshold;

	private Match3AchievementTypeData _achievementTypeData;

	private int _puzzleIndex;

	private int _pieceIndex;

	private IntIntEvent _unlockedEvent;

	public int Progress
	{
		get
		{
			return default(int);
		}
	}

	public float NormalizedProgress
	{
		get
		{
			return default(float);
		}
	}

	public bool IsCompleted
	{
		get
		{
			return default(bool);
		}
	}

	public string LocalizedText
	{
		get
		{
			return null;
		}
	}

	public void Init(Match3AchievementTypeData inTypeData, int inPuzzleIndex, int inPieceIndex, IntIntEvent inUnlockedEvent)
	{
	}

	public void OnEventRaised(ObscuredInt inCurrentValue, ObscuredInt inOldValue)
	{
	}
}
