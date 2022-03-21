using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

public class Match3AchievementTracker : MonoBehaviour
{
	[SerializeField]
	[EnumList(typeof(Match3AchievementType), 0.35f)]
	private List<Match3AchievementTypeData> _typeDatas;

	[SerializeField]
	[Header("Collection")]
	private Match3PuzzleCollectionReference _puzzleCollectionReference;

	[SerializeField]
	[Header("Event")]
	private IntIntEvent _achievementUnlockedEvent;

	[SerializeField]
	private PersistentAtomController persistentAtomController;

	private void Awake()
	{
	}

	private void GeneratePuzzleCollectionFromCharts()
	{
	}
}
