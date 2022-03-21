using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(FeralButton))]
[RequireComponent(typeof(RectTransform))]
public class UI_LazyListItem<T> : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, ISelectHandler where T : class
{
	[SerializeField]
	private bool _useOnSelect;

	protected UI_LazyItemList<T> _itemList;

	private Action<UI_LazyListItem<T>> _onClicked;

	private Action<UI_LazyListItem<T>> _onSelected;

	private T _data;

	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private RectTransform _rectTransform;

	private bool _pointerIsDown;

	private bool _isSearchMode;

	public T Data
	{
		get
		{
			return null;
		}
	}

	public FeralButton Button
	{
		get
		{
			return null;
		}
	}

	public RectTransform RectTransform
	{
		get
		{
			return null;
		}
	}

	public virtual void Setup(Action<UI_LazyListItem<T>> inOnClicked, Action<UI_LazyListItem<T>> inOnSelected, T inData, UI_LazyItemList<T> inItemList)
	{
	}

	public virtual void ResetData()
	{
	}

	public virtual void Refresh()
	{
	}

	public virtual void MarkAsSelected(bool inIsSelected)
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}

	public virtual void OnSelect(BaseEventData eventData)
	{
	}

	public void ClickItem()
	{
	}

	public virtual void SetSearchMode(bool inIsSearchMode)
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void OnClicked()
	{
	}

	private void Reset()
	{
	}
}
