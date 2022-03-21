using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	[AddComponentMenu("Unity Atoms/Listeners/GameObject x 2 Listener")]
	public sealed class GameObjectGameObjectListener : AtomListener<GameObject, GameObject, GameObjectGameObjectAction, GameObjectGameObjectEvent, GameObjectGameObjectUnityEvent>
	{
	}
}
