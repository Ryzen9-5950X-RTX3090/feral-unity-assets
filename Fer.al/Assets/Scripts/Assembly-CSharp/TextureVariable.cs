using System;
using UnityEngine;

[CreateAssetMenu]
public class TextureVariable : ScriptableObject, ISerializationCallbackReceiver
{
	[SerializeField]
	private Texture initialValue;

	[NonSerialized]
	public Texture runtimeValue;

	public void OnAfterDeserialize()
	{
	}

	public void OnBeforeSerialize()
	{
	}
}
