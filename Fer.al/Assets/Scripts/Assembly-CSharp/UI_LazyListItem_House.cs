using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_House : UI_LazyListItem<SanctuaryLookItemComponent>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnClicked>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItem_House <>4__this;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private UI_ItemImage _itemImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	[SerializeField]
	[Header("Equipped")]
	private GameObject _equippedIcon;

	private bool _isEquipped;

	public override void Setup(Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnClicked, Action<UI_LazyListItem<SanctuaryLookItemComponent>> inOnSelected, SanctuaryLookItemComponent inData, UI_LazyItemList<SanctuaryLookItemComponent> inItemList)
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
