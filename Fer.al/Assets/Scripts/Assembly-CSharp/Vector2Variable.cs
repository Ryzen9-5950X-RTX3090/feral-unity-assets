using System;
using UnityEngine;

[CreateAssetMenu]
public class Vector2Variable : ScriptableObject, ISerializationCallbackReceiver
{
	[SerializeField]
	private Vector2 initialValue;

	[NonSerialized]
	public Vector2 runtimeValue;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
