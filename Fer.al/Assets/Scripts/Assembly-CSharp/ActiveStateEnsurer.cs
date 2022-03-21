using DG.DeInspektor.Attributes;
using UnityEngine;

public class ActiveStateEnsurer : MonoBehaviour, ISerializationCallbackReceiver
{
	[SerializeField]
	private bool _active;

	[SerializeField]
	[DeComment("Optional: Will change enabled state of component rather than acive state of gameobject", 3)]
	private Behaviour _component;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
