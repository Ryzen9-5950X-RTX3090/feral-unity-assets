using System;
using UnityEngine;

[CreateAssetMenu]
public class ObjectVariable : ScriptableObject, ISerializationCallbackReceiver
{
	[SerializeField]
	private UnityEngine.Object initialValue;

	[NonSerialized]
	public UnityEngine.Object runtimeValue;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
