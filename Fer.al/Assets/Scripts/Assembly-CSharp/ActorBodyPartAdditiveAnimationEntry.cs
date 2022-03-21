using System;

[Serializable]
public class ActorBodyPartAdditiveAnimationEntry
{
	[ChartEnum]
	public ActorBodyPartAdditiveAnimationParameter parameter;

	[NonSerialized]
	private string _parameterName;

	[NonSerialized]
	private string _parameterNumName;

	[ChartInt]
	public int parameterValue;

	public string ParameterName
	{
		get
		{
			return null;
		}
	}

	public string ParameterNumName
	{
		get
		{
			return null;
		}
	}
}
