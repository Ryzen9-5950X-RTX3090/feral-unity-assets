using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;

public class NotificationController : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnFollowOnlineStatusUpdate>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public RelationshipFollowOnlineStatusUpdateResponse inMessage;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnChat>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ChatConversationMessage inMessage;

		private UniTask<bool>.Awaiter <>u__1;

		private UniTask<UserInfo>.Awaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<OnFollowOnlineStatusUpdate>d__2))]
	private void OnFollowOnlineStatusUpdate(RelationshipFollowOnlineStatusUpdateResponse inMessage)
	{
	}

	private void OnPrimaryQuestAdded(PrimaryQuestAddedMessage inMessage)
	{
	}

	private void OnPrimaryQuestUpdated(PrimaryQuestUpdatedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnChat>d__5))]
	private void OnChat(ChatConversationMessage inMessage)
	{
	}

	private void OnGiftPush(GiftPushMessage inMessage)
	{
	}

	private void OnNetworkAvatarSpawned(NetworkedAvatarSpawnedMessage inMessage)
	{
	}

	private void OnSeasonPassChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage)
	{
	}

	private void OnSeasonPassChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage)
	{
	}

	private void OnSeasonPassTierCompleted(SeasonPassTierCompletedMessage inMessage)
	{
	}

	private void OnXPUpdated(XPUpdateMessage inMessage)
	{
	}
}
