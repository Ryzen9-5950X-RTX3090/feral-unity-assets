using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_Feedback : UI_Window
{
	[SerializeField]
	private TMP_InputField _feedbackInput;

	[SerializeField]
	private FeralButton _submitButton;

	[SerializeField]
	private UI_Panel_Dropdown _categoryDropdown;

	private FeedbackCategory _feedbackCategory;

	public FeedbackCategory FeedbackCategory
	{
		get
		{
			return default(FeedbackCategory);
		}
		set
		{
		}
	}

	public static void OpenWindow(FeedbackCategory inCategory = FeedbackCategory.Clothing)
	{
	}

	public static void QueueWindow(FeedbackCategory inCategory = FeedbackCategory.Clothing)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(FeedbackCategory inCategory = FeedbackCategory.Clothing)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}

	public void BtnClicked_GiveFeedback()
	{
	}

	public void OnDropDownItemSelected_Category(int inCategory)
	{
	}

	public void OnFeedbackTextUpdated(string inFeedbackText)
	{
	}
}
