using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeBreakerLevelSelect : MonoBehaviour
{
	public GameObject buttonHolder;

	public ScrollRect levelScrollRect;

	public GameObject levelInfoContainer;

	public WWTextMeshProUGUI levelHeaderText;

	public WWImage levelScoreFillbar;

	public Color starColorFilled;

	public Color starColorUnfilled;

	public float scoreFillDuration;

	public WWTextMeshProUGUI levelScoreText;

	public ScoreStar star1;

	public ScoreStar star2;

	public ScoreStar star3;

	public GameObject ruleDuplicateIngredients;

	public GameObject ruleNoDuplicateIngredients;

	public WWTextMeshProUGUI ruleIngredientCountText;

	public CodeBreakerLevelButton levelButton;

	private List<CodeBreakerLevelButton> _buttons;

	private int _currentLevelIndex;

	private CodeBreakerDefComponent LevelData
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage)
	{
	}

	private void HideLevelInfo()
	{
	}

	private void SetScoreText(int inScore)
	{
	}

	private void SetLevelHeaderText(int inLevel)
	{
	}

	private void SetupLevelInfo(int inLevelIndex)
	{
	}

	[IteratorStateMachine(typeof(<DoScoreRevealRoutine>d__29))]
	private IEnumerator DoScoreRevealRoutine(long inBestScore, CodeBreakerLevel inLevel)
	{
		return null;
	}

	public void BtnClicked_LevelStart()
	{
	}

	private void UpdateStars(float inFillAmount, float inLastFillAmount)
	{
	}

	private bool CheckFillThreshold(ScoreStar inStar, float inFillAmount, float inLastFillAmount)
	{
		return default(bool);
	}

	private void ShowStarFilled(ScoreStar inStar)
	{
	}

	private float SetFillAmount(float inScore, CodeBreakerLevel inLevel)
	{
		return default(float);
	}

	public void Refresh()
	{
	}
}
