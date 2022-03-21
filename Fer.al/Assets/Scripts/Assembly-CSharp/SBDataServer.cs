using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using WyrmTale;

public class SBDataServer
{
	public class SDBCommands
	{
		public const string CHANGE_PROPS = "CCG";

		public const string GET_SHEET = "GAX";

		public const string GET_ALL_PROJECTS = "GTS";

		public const string GET_NEW_ID = "GID";

		public const string POST_TO_GAME = "PTG";
	}

	private static Hashtable queryCallBack;

	private static Dictionary<WWW, delegateNetworkData> queryFailCallBack;

	private static WWW www;

	private static string _command;

	private static string _json;

	private static delegateNetworkData _callback;

	private static delegateNetworkFail _failCallback;

	private static delegateNetworkData _callbackQueue;

	private static Dictionary<int, Dictionary<string, List<SBPROP>>> _changePropQueue;

	private static bool busy;

	private static SBDataServerConfig _config;

	private static int _queueIterator;

	private static int _queueProcessingProjectId;

	private static string _queueProcessingSheet;

	private static string _queueProcessingComments;

	public static SBDataServerConfig Config
	{
		get
		{
			return null;
		}
	}

	private static void sendData(string command, string json, [Optional] delegateNetworkData callBack, [Optional] delegateNetworkFail failCallBack)
	{
	}

	public static void fabrikaCallReturn(bool success, string token)
	{
	}

	private static void callSbDataServer(string command, string json)
	{
	}

	[IteratorStateMachine(typeof(<OnGameUpdate>d__17))]
	private static IEnumerator OnGameUpdate()
	{
		return null;
	}

	public void OnDestroy()
	{
	}

	public static void LoadCompleted()
	{
	}

	public static void GetAllProjectSchemas([Optional] delegateNetworkData callBack, [Optional] delegateNetworkFail failCallBack)
	{
	}

	public static void GetAllProjectsSummary([Optional] delegateNetworkData callback, [Optional] delegateNetworkFail failCallback)
	{
	}

	public static void GetSheet(string sheetName, [Optional] delegateNetworkData callBack, [Optional] delegateNetworkFail failCallBack)
	{
	}

	public static void ChangeProperty(string sheetName, SBPROP prop, string comment = "", [Optional] delegateNetworkData callBack, [Optional] delegateNetworkFail failCallBack)
	{
	}

	public static void AddProperty(string sheetName, SBPROP prop, string comment = "", [Optional] delegateNetworkData callback, [Optional] delegateNetworkFail failCallback)
	{
	}

	public static void QueueChange(string sheetName, SBPROP prop)
	{
	}

	public static void GetNewID(Action<int> inCallback)
	{
	}

	public static void PostToGame(Action<bool> inCallback)
	{
	}

	public static void PostToGame([Optional] delegateNetworkData callback, [Optional] delegateNetworkFail failCallback)
	{
	}

	public static void WriteQueue(string comments = "", [Optional] delegateNetworkData callBack, [Optional] delegateNetworkFail failCallBack)
	{
	}

	private static void processQueue()
	{
	}

	private static void ChangeProperties(int projectId, string sheetName, List<SBPROP> props, string comment = "", [Optional] delegateNetworkData callBack, [Optional] delegateNetworkFail failCallBack)
	{
	}

	private static void queueReturn([Optional] JSON dataObj)
	{
	}
}
