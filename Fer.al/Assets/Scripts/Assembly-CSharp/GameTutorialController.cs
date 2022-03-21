using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine;

public static class GameTutorialController
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnSanctuaryEnterMessage>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SanctuaryEnterMessage inMessage;

		private string <sKey>5__2;

		private UniTask.Awaiter <>u__1;

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
	private struct <OnEnigmaAcquired>d__17 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private static readonly bool _forceTutorial;

	[RuntimeInitializeOnLoadMethod]
	public static void Init()
	{
	}

	private static void OnUpdraftApproached(UpdraftTutorialMessage inMessage)
	{
	}

	private static void OnLevelLoaded(Message inMessage)
	{
	}

	private static void OnLoginWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	private static void OnCreatureCustomizationWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnSanctuaryEnterMessage>d__6))]
	private static void OnSanctuaryEnterMessage(SanctuaryEnterMessage inMessage)
	{
	}

	private static void OnSanctuaryDecorateWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	private static void OnSanctuaryExpansionsWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	private static void OnSanctuaryRoomToggled(SanctuaryRoomToggleBtnPrssed inMessage)
	{
	}

	private static void OnInventoryWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	private static void OnSocialWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	private static void OnPlayerCardWindowOpened(WindowOpenCompleteMessage inMessage)
	{
	}

	private static void OnSocialWindowOrPlayerCardOpened()
	{
	}

	private static void OnInventoryItemAdded(InventoryItemAddedEvent inMessage)
	{
	}

	private static void OnInspirationAcquired()
	{
	}

	private static void OnInspirationsWindowOpened(WindowOpenCompleteMessage obj)
	{
	}

	[AsyncStateMachine(typeof(<OnEnigmaAcquired>d__17))]
	private static void OnEnigmaAcquired()
	{
	}

	private static void OnShopOpened(ShopOpenedMessage inMessage)
	{
	}

	private static void OnHudOpened(HudOpenedMessage inMessage)
	{
	}

	internal static bool GetBool(string inKey)
	{
		return default(bool);
	}

	private static void SetBool(string inKey)
	{
	}
}
