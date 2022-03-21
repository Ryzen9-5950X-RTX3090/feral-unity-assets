using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class Match3PuzzleCollectionList : AtomList<Match3PuzzleCollection, Match3PuzzleCollectionEvent>
	{
	}
}
