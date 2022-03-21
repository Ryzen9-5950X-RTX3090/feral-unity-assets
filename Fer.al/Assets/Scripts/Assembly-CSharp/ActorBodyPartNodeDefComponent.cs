using System;

[Serializable]
[ChartComponent("Actor Body Part Node")]
public class ActorBodyPartNodeDefComponent : DefComponent
{
	[NonSerialized]
	public bool copyUV1ToUV2;

	[NonSerialized]
	public bool uniqueMaterial;
}
