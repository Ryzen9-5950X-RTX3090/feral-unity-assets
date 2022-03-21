using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Control_Carousel_Temp : MonoBehaviour
{
	[SerializeField]
	private FancyScrollView_Temp _scrollView;

	[SerializeField]
	private WWTextMeshProUGUI _currentlySelectedText;

	[SerializeField]
	private Button _leftArrowBtn;

	[SerializeField]
	private Button _rightArrowBtn;

	private bool _isSetup;

	private bool _paddingNeeded;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void BtnClicked_LeftArrow()
	{
	}

	public void BtnClicked_RightArrow()
	{
	}

	private void HandleSelectedIndexChanged(int index)
	{
	}
}
