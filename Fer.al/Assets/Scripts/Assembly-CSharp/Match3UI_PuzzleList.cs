using System.Collections.Generic;
using DG.DeInspektor.Attributes;
using UnityAtoms;
using UnityEngine;

public class Match3UI_PuzzleList : MonoBehaviour
{
	[SerializeField]
	private Match3PuzzleCollectionReference _puzzleCollection;

	[SerializeField]
	private Match3UI_PuzzleItem _puzzleItemPrefab;

	[SerializeField]
	private Transform _puzzleItemParent;

	private bool _isFirstSetup;

	private List<Match3UI_PuzzleItem> _puzzleItems;

	[DeMethodButton(null, 0, new object[] { })]
	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void Setup()
	{
	}

	private void SpawnPuzzleItems()
	{
	}

	private void SetupPuzzleItems()
	{
	}
}
