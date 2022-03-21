using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CustomizationNavPanel : MonoBehaviour
{
	[SerializeField]
	private UI_CustomizationPageNavigationController _navigationController;

	[SerializeField]
	private UI_CustomizationBreadcrumb _breadcrumbPrefab;

	[SerializeField]
	private GameObject _breadcrumbDividerPrefab;

	[SerializeField]
	private Transform _breadcrumbLayout;

	[SerializeField]
	private FeralButton _backButton;

	private List<GameObject> _breadCrumbItems;

	private bool? _allowBack;

	public void BtnClicked_Back()
	{
	}

	public void Refresh(UI_CustomizationPageInfo inCurrentPage)
	{
	}

	private void Start()
	{
	}

	private void OnPageNavigation(UI_CustomizationPageInfo inPageInfo)
	{
	}
}
