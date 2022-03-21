using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class Match3PuzzleCollectionVariable : AtomVariable<Match3PuzzleCollection, Match3PuzzleCollectionEvent, Match3PuzzleCollectionMatch3PuzzleCollectionEvent>
	{
		protected override bool AreEqual(Match3PuzzleCollection first, Match3PuzzleCollection second)
		{
			return default(bool);
		}
	}
}
