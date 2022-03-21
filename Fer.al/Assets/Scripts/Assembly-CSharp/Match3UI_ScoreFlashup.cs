using TMPro;
using UnityEngine;

public class Match3UI_ScoreFlashup : MonoBehaviour
{
	public WWTextMeshProUGUI scoreText;

	public DOTweenAnimator movementTween;

	public int score;

	public Color color;

	public bool doMovement;

	public void Setup(int inScore, Color inColor, bool inDoMovement = true)
	{
	}

	private void OnEnable()
	{
	}

	private void SetScoreText()
	{
	}
}
