using System;
using UnityEngine;

public abstract class UI_SelectableListItem<T> : MonoBehaviour
{
	[SerializeField]
	protected GameObject _groupSelected;

	private T _data;

	protected bool _isSelected;

	private Action<UI_SelectableListItem<T>> _onClicked;

	private Action<UI_SelectableListItem<T>> _onLongPressed;

	public T Data
	{
		get
		{
			return (T)null;
		}
	}

	public virtual void Setup(T inData, Action<UI_SelectableListItem<T>> inOnClicked, Action<UI_SelectableListItem<T>> inOnLongPressed)
	{
	}

	public void BtnClicked_Select()
	{
	}

	public void BtnLongClicked_Select()
	{
	}

	public virtual void MarkAsSelected(bool inSelected, bool inMultiSelectMode)
	{
	}
}
