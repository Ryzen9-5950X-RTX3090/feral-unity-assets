using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using UnityEngine;

public class DialogUtils
{
	private static string[] parseArg;

	public static void GetDialog(GameObject inGameObject, string inDialogDefId, Action<GameObject> dialogTreeControllerGameObject)
	{
	}

	public static void GetDialog(GameObject inGameObject, string inDialogDefId, Action<DialogueTreeController> dialogTreeController)
	{
	}

	public static void GetDialogFromList(GameObject inGameObject, string inListDefId, Action<GameObject> dialogTreeControllerGameObject)
	{
	}

	public static void GetDialogFromList(GameObject inGameObject, string inListDefId, Action<DialogueTreeController> dialogTreeController)
	{
	}

	public static void GetAllAvailableDialogFromList(GameObject inGameObject, string inListDefId, Action<List<GameObject>> dialogTreeControllerGameObjects)
	{
	}

	public static void GetAllAvailableDialogFromList(GameObject inGameObject, string inListDefId, Action<List<DialogueTreeController>> dialogTreeControllers)
	{
	}

	[IteratorStateMachine(typeof(<GetAllAvailableDialogFromList>d__7))]
	private static IEnumerator GetAllAvailableDialogFromList(GameObject inGameObject, List<DialogDefComponent> inComponents, Action<List<DialogueTreeController>> dialogTreeControllers)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetAllAvailableDialogFromList>d__8))]
	private static IEnumerator GetAllAvailableDialogFromList(GameObject inGameObject, List<DialogDefComponent> inComponents, Action<List<GameObject>> dialogTreeControllerGameObjects)
	{
		return null;
	}

	private static List<DialogDefComponent> GetAllDialogDefComponentsAvailableFromList(string inListDefId)
	{
		return null;
	}

	private static DialogDefComponent GetDialogDefComponentAvailableFromList(string inListDefId)
	{
		return null;
	}

	private static bool IsDialogAvailable(string inDialogDefId)
	{
		return default(bool);
	}

	private static void GetExpressionAndTime(string inString, out string outExpression, out float outTime)
	{
	}

	public static string ParseDialog(string inText, GameObject inDialogAttach, Transform inActorDialoging)
	{
		return null;
	}

	private static string GetExpressionDef(string inExpression)
	{
		return null;
	}

	private static void PlayDialogEvent(string inDefId, float inTime, GameObject inDialogAttach, Transform inActorDialoging)
	{
	}
}
