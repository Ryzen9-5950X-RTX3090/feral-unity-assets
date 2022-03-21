using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class UI_LazyListItemDetailPanel<T> : MonoBehaviour where T : class
{
	[SerializeField]
	protected CanvasGroup _canvasGroup;

	protected UI_LazyListItem<T> _dataSrc;

	private bool _isSearchMode;

	public virtual void Setup(UI_LazyListItem<T> inDataSrc)
	{
	}

	public virtual void Refresh()
	{
	}

	public virtual void SetSearchMode(bool inIsSearchMode)
	{
	}

	public virtual void CalculateUINavigation(List<UI_LazyListItem<T>> inItemsAbove, List<UI_LazyListItem<T>> inItemsBelow)
	{
	}

	public virtual List<Selectable> GetSelectables()
	{
		return null;
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void Reset()
	{
	}
}
