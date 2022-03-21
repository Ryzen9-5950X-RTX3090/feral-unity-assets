using UnityEngine;

[ChartComponent("Actor NPC")]
public class ActorNPCDefComponent : DefComponent
{
	[ChartVector3]
	public Vector3 interactableIconOffset;

	[ChartVector3]
	public Vector3 npcBubbleWorldOffsetOverride;

	public string interactableDefIDOverride;
}
