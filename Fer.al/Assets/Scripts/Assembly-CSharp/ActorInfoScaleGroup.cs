using System;

[Serializable]
public class ActorInfoScaleGroup
{
	[ChartDef("ActorScaleGroup", new string[] { })]
	public string scaleGroupDefID;

	[NonSerialized]
	private ActorScaleGroupDefComponent _scaleGroupDef;

	[NonSerialized]
	public bool enabled;

	public float scale;

	public ActorScaleGroupDefComponent ScaleGroupDef
	{
		get
		{
			return null;
		}
	}

	public void ResetCaches()
	{
	}
}
