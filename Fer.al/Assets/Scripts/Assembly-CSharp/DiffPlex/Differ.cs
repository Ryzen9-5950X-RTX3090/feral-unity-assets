using System;
using System.Collections.Generic;
using DiffPlex.Model;

namespace DiffPlex
{
	public class Differ : IDiffer
	{
		private static readonly string[] emptyStringArray;

		public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace)
		{
			return null;
		}

		public DiffResult CreateLineDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase)
		{
			return null;
		}

		public DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace)
		{
			return null;
		}

		public DiffResult CreateCharacterDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase)
		{
			return null;
		}

		public DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, char[] separators)
		{
			return null;
		}

		public DiffResult CreateWordDiffs(string oldText, string newText, bool ignoreWhitespace, bool ignoreCase, char[] separators)
		{
			return null;
		}

		public DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, Func<string, string[]> chunker)
		{
			return null;
		}

		public DiffResult CreateCustomDiffs(string oldText, string newText, bool ignoreWhiteSpace, bool ignoreCase, Func<string, string[]> chunker)
		{
			return null;
		}

		private static string[] SmartSplit(string str, char[] delims)
		{
			return null;
		}

		protected static EditLengthResult CalculateEditLength(int[] A, int startA, int endA, int[] B, int startB, int endB)
		{
			return null;
		}

		private static EditLengthResult CalculateEditLength(int[] A, int startA, int endA, int[] B, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal)
		{
			return null;
		}

		protected static void BuildModificationData(ModificationData A, ModificationData B)
		{
		}

		private static void BuildModificationData(ModificationData A, int startA, int endA, ModificationData B, int startB, int endB, int[] forwardDiagonal, int[] reverseDiagonal)
		{
		}

		private static void BuildPieceHashes(IDictionary<string, int> pieceHash, ModificationData data, bool ignoreWhitespace, bool ignoreCase, Func<string, string[]> chunker)
		{
		}
	}
}
