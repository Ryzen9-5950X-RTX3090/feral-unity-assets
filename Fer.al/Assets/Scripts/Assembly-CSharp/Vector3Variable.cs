using System;
using UnityEngine;

[CreateAssetMenu]
public class Vector3Variable : ScriptableObject, ISerializationCallbackReceiver
{
	[SerializeField]
	private Vector3 initialValue;

	[NonSerialized]
	public Vector3 runtimeValue;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
