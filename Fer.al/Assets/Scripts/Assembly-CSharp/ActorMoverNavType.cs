using System;

[Serializable]
public enum ActorMoverNavType
{
	StandardPathFind = 0,
	NetworkQueue = 1,
	SmoothFollowTarget = 2,
	LocalCharacterController = 3,
	NPCCharacterController = 4,
	NotActive = 100
}
