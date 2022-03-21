using System;
using System.Collections.Generic;
using UnityEngine;

public abstract class UI_SelectableList<T> : MonoBehaviour
{
	[SerializeField]
	private WWSmoothLayout _layout;

	[SerializeField]
	private bool _allowMultiSelect;

	public Action<T> OnItemSelected;

	public Action<List<T>> OnMultiSelectedItemsChanged;

	public Action<bool> OnMultiSelectModeChanged;

	protected List<UI_SelectableListItem<T>> _listItems;

	private UI_SelectableListItem<T> _currentlySelectedItem;

	private List<UI_SelectableListItem<T>> _multiSelectedItems;

	private bool _multiSelectMode;

	protected abstract UI_SelectableListItem<T> ListItemPrefab { get; }

	public bool MultiSelectMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public void AddItem(T inItemData, int inDesiredIndex = -1)
	{
	}

	public T RemoveSelected()
	{
		return (T)null;
	}

	public List<T> RemoveMultiSelected()
	{
		return null;
	}

	public List<T> RemoveAll()
	{
		return null;
	}

	public T RemoveItem(T inItemData)
	{
		return (T)null;
	}

	public T RemoveItem(UI_SelectableListItem<T> inItem)
	{
		return (T)null;
	}

	public void CancelMultiSelect()
	{
	}

	private void ItemClicked(UI_SelectableListItem<T> inItem)
	{
	}

	private void ItemLongPressed(UI_SelectableListItem<T> inItem)
	{
	}
}
