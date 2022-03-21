using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_PrimaryAvatarLook : UI_LazyListItem<AvatarLookItemComponent>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnClicked>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItem_PrimaryAvatarLook <>4__this;

		private TaskAwaiter<CreatureCustomizationTarget> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private UI_AvatarLookImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	private FeralAudioInfo _equipLookSound;

	private bool _isEquipped;

	public override void Setup(Action<UI_LazyListItem<AvatarLookItemComponent>> inOnClicked, Action<UI_LazyListItem<AvatarLookItemComponent>> inOnSelected, AvatarLookItemComponent inData, UI_LazyItemList<AvatarLookItemComponent> inItemList)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	[AsyncStateMachine(typeof(<OnClicked>d__6))]
	protected override void OnClicked()
	{
	}

	public override void Refresh()
	{
	}

	private void RefreshEquipped()
	{
	}
}
