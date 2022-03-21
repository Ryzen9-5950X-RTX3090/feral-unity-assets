using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_CustomizationPageBody : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _titleText;

	[SerializeField]
	private Transform _fullPageControlParent;

	[SerializeField]
	private GameObject _assembledContentGroup;

	[SerializeField]
	private Transform _navControlParent;

	[SerializeField]
	private Transform _standardControlParent;

	private UI_CustomizationPageInfo _currentPageInfo;

	public List<UI_GoToCustomizationPage> navButtons;

	public CanvasGroup CanvasGroup
	{
		get
		{
			return null;
		}
	}

	public void Show(bool inForward)
	{
	}

	public void Hide(bool inForward, UI_CustomizationPageNavigationController inNavigationController)
	{
	}

	public void AttachPage(UI_CustomizationPageInfo inPage, UI_CustomizationPageNavigationController inNavigationController)
	{
	}

	public void DetachPage(UI_CustomizationPageInfo inPage, UI_CustomizationPageNavigationController inNavigationController)
	{
	}
}
