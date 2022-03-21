using System.Runtime.InteropServices;
using Server;
using UnityEngine;

[MessageRouteHandler]
public static class WorldXtHandler
{
	[MessageRouteHandler]
	private static class DefaultHandlers
	{
	}

	[MessageSender(XtCmd.WorldReady, false)]
	public static void RequestReady(string uniqueMapId, [Optional] string jumpToUserId)
	{
	}

	[MessageSender(XtCmd.WorldObjectInfo, true)]
	public static void RequestWorldObjectInfo(int objectId)
	{
	}

	[MessageSender(XtCmd.WorldObjectAction, true)]
	public static void RequestWorldObjectAction(string objectName)
	{
	}

	[MessageSender(XtCmd.WorldObjectAskResponse, true)]
	public static void RequestWorldObjectAskResponse(string objectName, string askResponse)
	{
	}

	[MessageSender(XtCmd.WorldObjectActionStart, true)]
	public static void RequestWorldObjectInteractionStart(string objectName)
	{
	}

	[MessageSender(XtCmd.WorldObjectActionCancel, true)]
	public static void RequestWorldObjectInteractionCancel(string objectName)
	{
	}

	[MessageSender(XtCmd.WorldObjectActionFinish, true)]
	public static void RequestWorldObjectInteractionFinish(string objectName)
	{
	}

	[MessageSender(XtCmd.WorldObjectUpdate, false)]
	public static void RequestUpdate(WorldObjectMoverNodeType nodeType, Vector3 position, Vector3 direction, Quaternion rotation, float speed, ActorActionType actionType)
	{
	}

	[MessageSender(XtCmd.WorldObjectUpdate, false)]
	public static void RequestUpdate(WorldObjectMoverNodeType nodeType, ActorActionType actionType, string uniqueMapId, string userToGoTo)
	{
	}

	[MessageSender(XtCmd.WorldObjectUpdate, false)]
	public static void RequestUpdate(WorldObjectMoverNodeType nodeType)
	{
	}

	[MessageSender(XtCmd.WorldObjectGlide, false)]
	public static void RequestGlide(string updraftUUID)
	{
	}

	[MessageSender(XtCmd.WorldObjectGlideEnterExit, false)]
	public static void RequestGlideEnterExit(string updraftUUID, bool entering)
	{
	}

	[MessageSender(XtCmd.WorldObjectRespawnRequest, false)]
	public static void RequestRespawn()
	{
	}

	[MessageSender(XtCmd.WorldObjectRespawnSet, false)]
	public static void RequestWorldObjectRespawnSet(Vector3 position, Quaternion rotation)
	{
	}

	[MessageRoute(XtCmd.WorldObjectUpdate, QueueMessageMode.Never)]
	private static void HandleMove(WorldObjectMoveMessage message)
	{
	}

	[MessageRoute(XtCmd.WorldObjectGlide, QueueMessageMode.Never)]
	private static void HandleGlide(WorldObjectGlideMessage message)
	{
	}

	[MessageRoute(XtCmd.WorldObjectGlideEnterExit, QueueMessageMode.Never)]
	private static void HandleGlideEnterExit(WorldObjectGlideEnterExitMessage message)
	{
	}

	[MessageRoute(XtCmd.WorldObjectAction, QueueMessageMode.Never)]
	private static void HandleAction(WorldObjectActionMessage message)
	{
	}

	[MessageRoute(XtCmd.WorldObjectActionStart, QueueMessageMode.Never)]
	private static void HandleActionStart(WorldObjectActionStartMessage message)
	{
	}

	[MessageRoute(XtCmd.WorldObjectActionCancel, QueueMessageMode.Never)]
	private static void HandleActionCancel(WorldObjectActionCancelMessage message)
	{
	}

	[MessageRoute(XtCmd.WorldObjectActionFinish, QueueMessageMode.Never)]
	private static void HandleActionFinish(WorldObjectActionFinishMessage message)
	{
	}

	[MessageRoute(XtCmd.WorldObjectRespawnRequest, QueueMessageMode.Never)]
	private static void HandleRecievedRespawn(WorldObjectRecievedRespawnMessage message)
	{
	}
}
