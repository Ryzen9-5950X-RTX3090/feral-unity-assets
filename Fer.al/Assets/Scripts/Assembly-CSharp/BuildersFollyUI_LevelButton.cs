using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildersFollyUI_LevelButton : MonoBehaviour
{
	public WWButton levelButton;

	public WWTextMeshProUGUI levelText;

	public CanvasGroup canvasGroup;

	public GameObject levelIcon;

	public GameObject levelIconSelected;

	public GameObject levelLockedIcon;

	public UI_ColorizedIcon halfStar;

	public UI_ColorizedIcon oneStar;

	public UI_ColorizedIcon oneHalfStar;

	public UI_ColorizedIcon twoStar;

	public UI_ColorizedIcon twoHalfStar;

	public UI_ColorizedIcon threeStar;

	private int _level;

	private bool _locked;

	private int _points;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage)
	{
	}

	public void SetSelected(bool inSelected)
	{
	}

	private void ShowStars()
	{
	}

	public void SetLevel(int inLevelIndex, BuildersFollyLevel_Scriptable inLevel)
	{
	}

	public void BtnClicked_LevelSelected()
	{
	}
}
