using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;

public class NetworkedObjectInfo : WorldObject
{
	public enum EActorType
	{
		NONE = 0,
		npc = 1,
		volumeTrigger = 3,
		circleTrigger = 4,
		volumeBlocker = 5,
		circleBlocker = 6,
		variable = 7,
		timer = 8,
		treasure = 13,
		speaker = 16,
		startup = 18,
		harvestItem = 31,
		npcQuestItem = 32,
		dailyQuest = 33,
		playerCountVolume = 34
	}

	public EActorType actorType;

	public Interactable.EItemType subType;

	public string uuid;

	public int State;

	[RootSelector("Downloadable Dialog List DefId", "ListChartData", false, false)]
	public string dialogListDefId;

	public DialogueTreeController[] dialogueTreeController;

	protected GraphOwner _graphOwner;

	protected Switch _switchNode;

	private int _numStates;

	public int Local
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage)
	{
	}

	public override void Unsubscribe()
	{
	}

	internal bool HasStates()
	{
		return default(bool);
	}

	internal void UpdateState(int inState)
	{
	}

	[IteratorStateMachine(typeof(<GraphInitializeWait>d__18))]
	private IEnumerator GraphInitializeWait()
	{
		return null;
	}
}
