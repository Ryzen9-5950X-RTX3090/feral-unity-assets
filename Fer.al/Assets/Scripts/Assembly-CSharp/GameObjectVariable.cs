using System;
using UnityEngine;

[CreateAssetMenu]
public class GameObjectVariable : ScriptableObject, ISerializationCallbackReceiver
{
	[SerializeField]
	private GameObject initialValue;

	[NonSerialized]
	public GameObject runtimeValue;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
