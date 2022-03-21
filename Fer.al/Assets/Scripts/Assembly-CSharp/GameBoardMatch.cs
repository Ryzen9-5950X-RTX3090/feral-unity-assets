using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class GameBoardMatch : HashSet<Match3Cell>
{
	public Match3Cell primaryCell;

	public Dictionary<Match3Cell, BoosterMatch> boosters;

	private List<BoosterShapeFound> _foundBoosterShapes;

	public int MatchCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool CanCombine
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool CanShapeMatch
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GameBoardMatch(List<Match3Cell> inMatchedCells, bool inCanCombine = true, bool inCanShapeMatch = true)
	{
	}

	private void SetupMatchSet(List<Match3Cell> inMatchedCells)
	{
	}

	private void AddBooster(Match3Cell atCell, BoosterType boosterType, IEnumerable<Match3Cell> cells)
	{
	}

	public void CombineMatches(GameBoardMatch inOtherMatch)
	{
	}

	public void FindBoosterShapeMatch(Match3Grid inGrid, BoosterShapeData inBoosterShape)
	{
	}

	private bool AnyCellSameRowOrColumn(IEnumerable<Match3Cell> inCells)
	{
		return default(bool);
	}

	private bool AnyCellSameRow(IEnumerable<Match3Cell> inCells)
	{
		return default(bool);
	}

	private bool AnyCellSameColumn(IEnumerable<Match3Cell> inCells)
	{
		return default(bool);
	}
}
