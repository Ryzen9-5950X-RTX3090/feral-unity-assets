using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_GoToCustomizationPage : MonoBehaviour
{
	[SerializeField]
	private FeralButton _button;

	[SerializeField]
	private WWTextMeshProUGUI _text;

	[SerializeField]
	private UI_UnreadCount _unreadCount;

	private UI_CustomizationPageNavigationController _navController;

	private UI_CustomizationPageInfo _pageInfo;

	internal FeralButton button
	{
		get
		{
			return null;
		}
	}

	internal UI_CustomizationPageInfo pageInfo
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void GoToCustomizationPage()
	{
	}

	public void Setup(UI_CustomizationPageNavigationController inNavController, UI_CustomizationPageInfo inPageInfo)
	{
	}
}
