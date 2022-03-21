using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DiffPlex.DiffBuilder.Model;
using DiffPlex.Model;

namespace DiffPlex.DiffBuilder
{
	public class SideBySideDiffBuilder : ISideBySideDiffBuilder
	{
		private delegate void PieceBuilder(string oldText, string newText, List<DiffPiece> oldPieces, List<DiffPiece> newPieces);

		private readonly IDiffer differ;

		[CompilerGenerated]
		private readonly char[] <WordSeparaters>k__BackingField;

		public char[] WordSeparaters
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public SideBySideDiffBuilder(IDiffer differ)
		{
		}

		public SideBySideDiffBuilder(IDiffer differ, char[] wordSeparators)
		{
		}

		public SideBySideDiffModel BuildDiffModel(string oldText, string newText)
		{
			return null;
		}

		public SideBySideDiffModel BuildDiffModel(string oldText, string newText, bool ignoreWhitespace)
		{
			return null;
		}

		private SideBySideDiffModel BuildLineDiff(string oldText, string newText, bool ignoreWhitespace)
		{
			return null;
		}

		private void BuildWordDiffPieces(string oldText, string newText, List<DiffPiece> oldPieces, List<DiffPiece> newPieces)
		{
		}

		private static void BuildDiffPieces(DiffResult diffResult, List<DiffPiece> oldPieces, List<DiffPiece> newPieces, PieceBuilder subPieceBuilder)
		{
		}
	}
}
