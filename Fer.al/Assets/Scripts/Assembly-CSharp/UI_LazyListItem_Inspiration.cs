using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

public class UI_LazyListItem_Inspiration : UI_LazyListItem<InspirationItemComponent>
{
	[SerializeField]
	private RawImage _iconImage;

	[SerializeField]
	private WWTextMeshProUGUI _nameText;

	private UI_Window_Inspirations _inspirationWindow;

	private WW.Waiters.Waiter _iconLoadWaiter;

	public override void Setup(Action<UI_LazyListItem<InspirationItemComponent>> inOnClicked, Action<UI_LazyListItem<InspirationItemComponent>> inOnSelected, InspirationItemComponent inData, UI_LazyItemList<InspirationItemComponent> inItemList)
	{
	}

	private void OnInspirationAddedOrRemoved(InspirationItemComponent inInspiration)
	{
	}

	protected override void OnClicked()
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public override void Refresh()
	{
	}
}
