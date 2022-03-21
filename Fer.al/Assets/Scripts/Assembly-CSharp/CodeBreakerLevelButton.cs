using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeBreakerLevelButton : MonoBehaviour
{
	public bool redLevel;

	public WWButton levelButton;

	public WWTextMeshProUGUI levelText;

	public CanvasGroup canvasGroup;

	public GameObject levelIcon;

	public GameObject levelIcon_Red;

	public GameObject levelIconSelected_NoStar;

	public GameObject levelIconSelected_NoStar_Red;

	public GameObject levelIconSelected_OneStar;

	public GameObject levelIconSelected_OneStar_Red;

	public GameObject levelIconSelected_TwoStar;

	public GameObject levelIconSelected_TwoStar_Red;

	public GameObject levelIconSelected_ThreeStar;

	public GameObject levelIconSelected_ThreeStar_Red;

	public GameObject oneStar;

	public GameObject twoStar;

	public GameObject threeStar;

	public GameObject levelLockedIcon;

	private ObscuredInt _level;

	private bool _locked;

	private long _bestScore;

	private int _stars;

	public long BestScore
	{
		get
		{
			return default(long);
		}
	}

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

	private void ShowStars(int inStarCount)
	{
	}

	private void ShowSelected(int inStarCount)
	{
	}

	private void SetLevelText(int inLevel)
	{
	}

	public void SetLevel(int inLevelIndex, CodeBreakerLevel inLevel)
	{
	}

	public void BtnClicked_LevelSelected()
	{
	}
}
