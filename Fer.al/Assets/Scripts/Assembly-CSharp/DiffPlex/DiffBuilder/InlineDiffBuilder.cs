using System.Collections.Generic;
using DiffPlex.DiffBuilder.Model;
using DiffPlex.Model;

namespace DiffPlex.DiffBuilder
{
	public class InlineDiffBuilder : IInlineDiffBuilder
	{
		private readonly IDiffer differ;

		public InlineDiffBuilder(IDiffer differ)
		{
		}

		public DiffPaneModel BuildDiffModel(string oldText, string newText)
		{
			return null;
		}

		public DiffPaneModel BuildDiffModel(string oldText, string newText, bool ignoreWhitespace)
		{
			return null;
		}

		private static void BuildDiffPieces(DiffResult diffResult, List<DiffPiece> pieces)
		{
		}
	}
}
