using System;
using UnityEngine;

[CreateAssetMenu]
public class TransformVariable : ScriptableObject, ISerializationCallbackReceiver
{
	[SerializeField]
	private Transform initialValue;

	[NonSerialized]
	public Transform runtimeValue;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
