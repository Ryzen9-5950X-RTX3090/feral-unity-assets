using System;

[Serializable]
[ChartComponent("Actor Attach Node")]
public class ActorAttachNodeDefComponent : DefComponent
{
	[ChartString]
	public string jointName;
}
