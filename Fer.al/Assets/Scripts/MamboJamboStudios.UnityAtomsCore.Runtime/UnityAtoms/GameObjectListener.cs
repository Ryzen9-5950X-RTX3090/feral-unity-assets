using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/GameObject Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class GameObjectListener : AtomListener<GameObject, GameObjectAction, GameObjectEvent, GameObjectUnityEvent>
	{
	}
}
