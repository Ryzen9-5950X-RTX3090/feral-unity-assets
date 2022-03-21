using TMPro;
using UnityEngine;

public class UI_CustomizationBreadcrumb : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _pageNameText;

	private UI_CustomizationPageInfo _pageInfo;

	private UI_CustomizationPageNavigationController _navigationController;

	public void Setup(UI_CustomizationPageInfo inPageInfo, UI_CustomizationPageNavigationController inNavigationController)
	{
	}

	public void BtnClicked_GoToPage()
	{
	}
}
