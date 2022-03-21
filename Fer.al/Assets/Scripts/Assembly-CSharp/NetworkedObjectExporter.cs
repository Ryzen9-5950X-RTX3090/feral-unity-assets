using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using UnityEngine;

public class NetworkedObjectExporter
{
	[Serializable]
	public class QuestExportObject
	{
		public CompileNetworkObjectInfo[] actors;

		public string[] stringTable;

		public NetworkedScene.QuestTrackableItemDetails[] questTrackableItemDetails;

		public int numLockpicksAvailable;

		public int numBronzeChestsAvailable;

		public int numSilverChestsAvailable;

		public int numGoldChestsAvailable;

		public int numRockFlipsAvailable;

		public int numDigSpotsAvailable;

		public string version;
	}

	[Serializable]
	public class NetworkObjectState
	{
		public NetworkObjectCmd[] cmds;

		public string name;
	}

	[Serializable]
	public class CompileNetworkObjectInfo
	{
		public string name;

		public string defId;

		public string type;

		public string subDefId;

		public string subType;

		public string local;

		public string uuid;

		public Vector3 position;

		public Quaternion rotation;

		public NetworkObjectState[] states;

		public CompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo)
		{
		}

		protected void VerifyVolumes(Collider inCollider, NetworkedObjectInfo inNetworkerdObjectInfo)
		{
		}
	}

	[Serializable]
	public class NetworkObjectCmd
	{
		public string actor;

		public string cmd;

		public string[] cmdParams;
	}

	private class NetworkObjectCommand : NetworkObjectCmd
	{
		public NetworkObjectCommand(Task inTask, [Optional] string inName)
		{
		}
	}

	private class NetworkObjectBranch : NetworkObjectCmd
	{
		[SerializeField]
		public NetworkObjectState[] branches;

		internal NetworkObjectBranch(Task inTask, [Optional] Node inNode)
		{
		}

		private bool ChqBranchesForAsk(NetworkObjectState[] inBranches)
		{
			return default(bool);
		}
	}

	private class GroupCompileNetworkObjectInfo : CompileNetworkObjectInfo
	{
		public string groupUuid;

		public string groupCount;

		public GroupCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo)
		{
		}

		private GroupInfo FindClosestGroup(NetworkedObjectInfo inNetworkObjectInfo)
		{
			return null;
		}

		private string GetGroupUuid(GroupInfo inGroupInfo)
		{
			return null;
		}
	}

	private class SphereTriggerCompileNetworkObjectInfo : CompileNetworkObjectInfo
	{
		public string radius;

		public SphereTriggerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo, float inRadiusBufferAddition)
		{
		}
	}

	private class SphereBlockerCompileNetworkObjectInfo : SphereTriggerCompileNetworkObjectInfo
	{
		public SphereBlockerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo, float inRadiusBufferAddition)
		{
		}
	}

	private class PlayerCountVolumeTriggerCompileNetworkObjectInfo : VolumeTriggerCompileNetworkObjectInfo
	{
		public string playerCount;

		public PlayerCountVolumeTriggerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo)
		{
		}
	}

	private class VolumeTriggerCompileNetworkObjectInfo : CompileNetworkObjectInfo
	{
		public string halfWidthX;

		public string halfWidthY;

		public string halfWidthZ;

		public VolumeTriggerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo)
		{
		}
	}

	public class NetworkObjectsToolsHelper
	{
		public static void CheckNetworkedObjectInfoInteraction(NetworkedObjectInfo inNoi)
		{
		}

		public static void NewUUID(NetworkedObjectInfo inNoi)
		{
		}
	}

	private static NetworkedScene _networkedScene;

	private static bool _exportErrors;

	private static QuestExportObject _exportObject;

	private static List<CompileNetworkObjectInfo> _actorsList;

	private static int _hasQuestStart;

	public static string GetData(string inChartID)
	{
		return null;
	}

	private static string GetJson(NetworkedScene inNetworkedScene)
	{
		return null;
	}

	private static void SyncGroupLinearObjects(Interactable.EItemType inItemType, int inNumberAvailable)
	{
	}

	private static bool CompileData()
	{
		return default(bool);
	}

	private static void AddQuestItemCommand(NetworkedObjectInfo noi, CompileNetworkObjectInfo compileActor)
	{
	}

	private static List<NetworkObjectCmd> MakeCommands(Node inTargetNode, string inCallingActorName)
	{
		return null;
	}

	private static void CommandHelper(Task inTask, ref List<NetworkObjectCmd> inCmdsList)
	{
	}

	private static void NetworkActionTaskChq(Task inTask, string inCallingActorName)
	{
	}

	private static List<NetworkObjectState> GetStatesOrBranches(Node inNode, string inCallingActorName)
	{
		return null;
	}

	private static void NonServerActionChq(Node inTargetNode, string inCallingActorName)
	{
	}

	private static List<NetworkObjectState> GetDialogStatesOrBranches(List<Node> inOptions, string inCallingActorName)
	{
		return null;
	}

	private static List<NetworkObjectState> GetMakeStatesOrBranches(ProbabilitySelector inProbabilitySelector, string inCallingActorName)
	{
		return null;
	}

	private static string ParamsChq(string inCmd, out string[] outCmdParams, object[] inParams)
	{
		return null;
	}

	private static void SyncCommands(ref NetworkObjectCmd[] refQuestActorCommands)
	{
	}

	private static void SyncNames()
	{
	}

	private static NetworkObjectState[] CleanEmptyStates(List<NetworkObjectState> iNnetworkObjectState)
	{
		return null;
	}
}
