using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	[AddComponentMenu("Unity Atoms/Listeners/Match3PuzzleCollection Listener")]
	public sealed class Match3PuzzleCollectionListener : AtomListener<Match3PuzzleCollection, Match3PuzzleCollectionAction, Match3PuzzleCollectionEvent, Match3PuzzleCollectionUnityEvent>
	{
	}
}
