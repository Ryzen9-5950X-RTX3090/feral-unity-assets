using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;

public class UI_Window_Decrees : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <QueueWindowIfDecreeHasChanged>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private UniTask<ListDecreesResponse>.Awaiter <>u__1;

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
	private struct <SpawnDecrees>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_Decrees <>4__this;

		private UniTask<ListDecreesResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[EnumList(typeof(DecreeItem.DecreeLayoutType), 0.35f)]
	private List<UI_DecreeItem> _decreeItemTemplates;

	[SerializeField]
	[EnumList(typeof(DecreeItem.DecreeCategory), 0.35f)]
	private List<Transform> _decreeCategoryParents;

	[SerializeField]
	private WWTextMeshProUGUI _categoryHeaderText;

	[SerializeField]
	private UI_TabGroup _tabGroup;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void QueueWindowIfChanged()
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	[AsyncStateMachine(typeof(<QueueWindowIfDecreeHasChanged>d__11))]
	public static void QueueWindowIfDecreeHasChanged()
	{
	}

	[AsyncStateMachine(typeof(<SpawnDecrees>d__12))]
	private void SpawnDecrees()
	{
	}

	private void SpawnDecree(DecreeItem inDecreeItem)
	{
	}

	private void DespawnDecrees()
	{
	}

	public override void MOnDestroy()
	{
	}

	private void OnTabSelected(int inTabIndex)
	{
	}
}
