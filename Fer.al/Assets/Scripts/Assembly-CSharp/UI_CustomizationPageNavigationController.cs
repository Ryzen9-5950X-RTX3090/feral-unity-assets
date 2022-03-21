using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_CustomizationPageNavigationController : MonoBehaviour
{
	public class ItemPool
	{
		private Transform _itemParent;

		private UI_GoToCustomizationPage _itemPrefab;

		private Stack<UI_GoToCustomizationPage> _availableItems;

		private List<UI_GoToCustomizationPage> _itemsInUse;

		public ItemPool(Transform inItemParent, UI_GoToCustomizationPage inItemPrefab, int inInitialPoolSize = 50)
		{
		}

		public UI_GoToCustomizationPage GetItemFromPool()
		{
			return null;
		}

		public void ReturnItemToPool(UI_GoToCustomizationPage inItem)
		{
		}

		private void SpawnItem()
		{
		}
	}

	[SerializeField]
	private UI_CustomizationPageBody _bodyA;

	[SerializeField]
	private UI_CustomizationPageBody _bodyB;

	[SerializeField]
	private UI_GoToCustomizationPage _navButtonPrefab;

	private ItemPool _navButtonPool;

	private Stack<UI_CustomizationPageInfo> _pageStack;

	private UI_CustomizationPageInfo _currentPage;

	private UI_CustomizationPageBody _currentBody;

	public Action<UI_CustomizationPageInfo> OnNavigation;

	public ItemPool NavButtonPool
	{
		get
		{
			return null;
		}
	}

	public Stack<UI_CustomizationPageInfo> PageStack
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void NavigateToRootPage(UI_CustomizationPageInfo inPageInfo)
	{
	}

	public void NavigateForwardToPage(UI_CustomizationPageInfo inPageInfo)
	{
	}

	public void NavigateBackToPage(UI_CustomizationPageInfo inPageInfo)
	{
	}

	public void NavigateBack()
	{
	}

	private void DoNavigate(UI_CustomizationPageInfo inPageInfo, bool inForward)
	{
	}

	private void NavigateToPage(UI_CustomizationPageInfo inPageInfo, bool inForward)
	{
	}
}
