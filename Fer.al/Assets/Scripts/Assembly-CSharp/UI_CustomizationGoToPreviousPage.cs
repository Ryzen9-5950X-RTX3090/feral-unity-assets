using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_CustomizationGoToPreviousPage : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _pageNameText;

	[SerializeField]
	private FeralButton _button;

	private UI_CustomizationPageInfo _pageInfo;

	private UI_CustomizationPageNavigationController _navController;

	private void Awake()
	{
	}

	private void GoToPreviousPage()
	{
	}

	public void Setup(UI_CustomizationPageNavigationController inNavController, UI_CustomizationPageInfo inTargetPage)
	{
	}
}
