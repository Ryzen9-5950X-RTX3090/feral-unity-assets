using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ChartDuration : ISerializationCallbackReceiver
{
	[Serializable]
	public enum ChartDurationType
	{
		Month,
		Week,
		Day,
		Hour,
		Minute,
		Second
	}

	[Serializable]
	public enum ChartDurationMode
	{
		Always,
		Timed,
		None
	}

	private static Dictionary<ChartDurationType, string> _typeToToken;

	private static Dictionary<string, ChartDurationType> _tokenToType;

	private static Dictionary<string, ChartDurationMode> _tokenToTypeMode;

	[ChartInt]
	private int _durationValue;

	[ChartEnum]
	private ChartDurationType _durationType;

	[ChartEnum]
	private ChartDurationMode _durationMode;

	[SerializeField]
	private string _serializedDuration;

	[SerializeField]
	private string _serializedMode;

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
