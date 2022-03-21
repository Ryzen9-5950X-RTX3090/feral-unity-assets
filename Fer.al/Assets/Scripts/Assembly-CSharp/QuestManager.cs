using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

public class QuestManager : SingletonManagerBase<QuestManager>
{
	public enum EQuestCMD
	{
		SET_STATE = 1,
		SAY = 2,
		ASK = 3,
		GAME = 4,
		TAKE_ITEM = 7,
		TELEPORT = 14,
		FOCUS = 15,
		ON_EXIT = 19,
		TASK_PROGRESS = 20,
		NOTIFY = 38,
		GIVE_OBJECTIVE = 81,
		SUMMARY_TALLY = 82,
		DEBUGSAY = 1001
	}

	public enum EGiveObjectiveResetMode
	{
		None,
		Forward,
		All,
		OnlyThisOne
	}

	public enum EGiveXpParamAction
	{
		QuestStep = 1
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestServerQuestOpen>d__48 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public QuestDefComponent inQuestDef;

		public Action<RequestQuestOpenSuccessMessage> onSuccess;

		public Action<RequestQuestGenericFailedMessage> onFailed;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private Quest _primaryQuest;

	private Dictionary<int, Quest> _secondaryQuestIndexMap;

	private List<Quest> _secondaryQuests;

	private NetworkedSceneGroupListObjects[] _networkedSceneGroupListObjects;

	private ILinearQuestListData _linearQuestListData;

	private int _linearQuestAlerts;

	public static string allCompletePrizeDefId;

	public static QuestSummary questSummary;

	internal static bool updateNetworkedObjects;

	private static Dictionary<string, NetworkedObject> _networkedObjectDictionary;

	private static Dictionary<string, WorldObject> _worldObjectDictionary;

	private Dictionary<MinimapBlip, UI_QuestGiverIconography> _questGiverIconographys;

	private static QueensQuestEventDefComponent _queensQuestEventDef;

	private static CachedUserVar _queensQuestEventCachedUserVar;

	private static int completedGroupLinearType;

	public Quest PrimaryQuest
	{
		get
		{
			return null;
		}
	}

	public List<Quest> SecondaryQuests
	{
		get
		{
			return null;
		}
	}

	public ILinearQuestListData LinearQuestListData
	{
		get
		{
			return null;
		}
	}

	public int LinearQuestAlerts
	{
		get
		{
			return default(int);
		}
		private set
		{
		}
	}

	internal bool IsQueensQuestEventIntroAvailable
	{
		get
		{
			return default(bool);
		}
	}

	public static string SocialExpanseAreaToLevelDefId(SocialExpanseArea area)
	{
		return null;
	}

	public static void ClearDictionaries()
	{
	}

	[IteratorStateMachine(typeof(<SetQuestGiverIconography>d__26))]
	internal IEnumerator SetQuestGiverIconography(MinimapBlip inMinimapBlip, bool inEnable)
	{
		return null;
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	private void OnDestroy()
	{
	}

	public void ClearLinearQuestAlerts()
	{
	}

	private ILinearQuestListData CreateLinearQuestListData()
	{
		return null;
	}

	public bool IsOnSocialExpanseQuest()
	{
		return default(bool);
	}

	public SocialExpanseDefComponent GetActiveSocialExpanseQuest()
	{
		return null;
	}

	private void OnGiftPushMessage(GiftPushMessage inMessage)
	{
	}

	public bool GetQuestCompleted(string inQuestDefId)
	{
		return default(bool);
	}

	private void OnRoomJoinSuccessMessage(RoomJoinSuccessMessage inMessage)
	{
	}

	private void SetupQueensQuestEvent()
	{
	}

	internal void SetQueensQuestEventIntroAvailable(long inVal)
	{
	}

	internal void SetupNetworkedScene(NetworkedScene inNetworkedScene)
	{
	}

	private static int UpdateSceneNetworkedObjectInfos()
	{
		return default(int);
	}

	internal void ShowResults(QuestShowResults _inQuestShowResultsAction)
	{
	}

	public Coroutine QuestOpen(string inQuestDefID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<_QuestOpen>d__47))]
	private IEnumerator _QuestOpen(string inQuestDefID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestServerQuestOpen>d__48))]
	public void RequestServerQuestOpen(QuestDefComponent inQuestDef, [Optional] Action<RequestQuestOpenSuccessMessage> onSuccess, [Optional] Action<RequestQuestGenericFailedMessage> onFailed)
	{
	}

	public void NetworkObjectAskResponse(string inActorID, string inResponse)
	{
	}

	internal WorldObject GetWorldObject(string inUUID)
	{
		return null;
	}

	internal void PrimaryQuestAdd(QuestDefComponent inPrimaryQuestDef)
	{
	}

	internal void PrimarySocialExpanseQuestAdd(SocialExpanseDefComponent inSocialExpanseDef)
	{
	}

	internal void PrimaryTutorialQuestAdd(TutorialQuestDefComponent inTutorialDef)
	{
	}

	internal void QueensQuestEventAdd()
	{
	}

	internal static void OnStartQuestInit()
	{
	}

	private static NetworkedObject GetNetworkedObjectFromDictionary(string inKey)
	{
		return null;
	}

	internal static void AddActorDictionary(Dictionary<string, NetworkedObject> inDict)
	{
	}

	internal static void HandleQuestStartResponse(XtReader data)
	{
	}

	internal static void HandleQuestOpenResponse(XtReader data)
	{
	}

	internal static void HandleCommand(XtReader inData)
	{
	}

	internal static void HandleQuestGenericLinearQuestCompleteResponse(int completedLinearGenericQuestDefId)
	{
	}

	private void OnQuestRewardWindowClosed(WindowClosedMessage inMessage)
	{
	}

	internal static void HandleQuestGroupLinearObjectsCompleteResponse(int inCompletedGroupLinearType)
	{
	}

	private void OnGroupLinearObjectRewardWindowClosed(WindowClosedMessage inMessage)
	{
	}

	private void ShowGroupLinearObjectRewardComplete(string inTitleDefID, string inMessageDefID, string inImageDefID)
	{
	}

	private static void ShowInData(XtReader inData)
	{
	}

	private static void CommandGiveObjective(XtReader inData)
	{
	}

	private static void CommandTaskProgress(XtReader inData)
	{
	}

	private static void CommandSummaryTally(XtReader inData)
	{
	}

	private static void CommandNotify(XtReader inData)
	{
	}

	private static void CommandSetState(XtReader inData)
	{
	}

	private static void CommandAsk(XtReader inData)
	{
	}

	internal static void HandleQuestSetupGroupObjects(XtReader data)
	{
	}
}
