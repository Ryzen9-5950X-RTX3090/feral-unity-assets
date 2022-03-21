using System;
using System.Collections.Generic;

[Serializable]
[ChartComponent("Actor Attach Node Group")]
public class ActorAttachNodeGroupDefComponent : DefComponent
{
	[ChartList]
	[ChartDef("ActorAttachNode", new string[] { })]
	public ChartDefList attachNodes;

	public List<BaseDef> AttachNodes
	{
		get
		{
			return null;
		}
	}

	public bool Contains(BaseDef inAttachNode)
	{
		return default(bool);
	}
}
