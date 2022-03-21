using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

[ManagedBehaviourManager("WindowManager")]
public class UI_QuestStepTrackerMain : ManagedBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnPrimaryQuestUpdated>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_QuestStepTrackerMain <>4__this;

		public PrimaryQuestUpdatedMessage inMessage;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWImage _bgImage;

	[SerializeField]
	private UI_ObjectiveItem _objectiveItem;

	[SerializeField]
	private FeralAudioInfo _questAddedSound;

	[SerializeField]
	private FeralAudioInfo _questUpdatedSound;

	[SerializeField]
	private FeralAudioInfo _questCompletedSound;

	[SerializeField]
	private float _completeSoundDelay;

	private Quest _primaryQuest;

	private QuestObjective _currentlyRenderedObjective;

	private bool _isSlidOut;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_SlideOutTab()
	{
	}

	private void RemovePrimaryQuestItem()
	{
	}

	private void OnPrimaryQuestAdded(PrimaryQuestAddedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnPrimaryQuestUpdated>d__14))]
	private void OnPrimaryQuestUpdated(PrimaryQuestUpdatedMessage inMessage)
	{
	}

	private void OnPrimaryQuestRemoved(PrimaryQuestRemovedMessage inMessage)
	{
	}
}
