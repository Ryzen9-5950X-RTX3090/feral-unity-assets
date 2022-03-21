using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeBreakerScoreUI : MonoBehaviour
{
	[Serializable]
	public class ScoreLine
	{
		public WWTextMeshProUGUI scoreLabel;

		public WWTextMeshProUGUI scoreText;

		public void Reset()
		{
		}

		public void SetScore(int inScore)
		{
		}

		public void PunchScoreText()
		{
		}
	}

	public CodeBreakerScoreLineUI scoreLinePrefab;

	public Transform scoreLineContainer;

	public ScoreLine totalScoreLine;

	public RectTransform totalScoreContainer;

	[Space]
	public ScoreStar star1;

	public ScoreStar star2;

	public ScoreStar star3;

	[Space]
	public WWImage scoreFillbar;

	public Color starColorFilled;

	public Color starColorUnfilled;

	public float scoreFillDuration;

	private bool _showingScore;

	private bool _showingScoreSkip;

	private List<CodeBreakerScoreLineUI> _scoreItems;

	private void Update()
	{
	}

	public void ShowScore(int timeScore, int ingredientScore, int inBonusFirstGuess, int inBonusLastIngredient, CodeBreakerLevel inLevelData)
	{
	}

	private void ResetScore()
	{
	}

	private void ResetScoreFillbar()
	{
	}

	[IteratorStateMachine(typeof(<DoScoreRevealRoutine>d__19))]
	private IEnumerator DoScoreRevealRoutine(int inTimeScore, int inIngredientScore, int inBonusFirstGuess, int inBonusLastIngredient, CodeBreakerLevel inLevelData)
	{
		return null;
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
}
