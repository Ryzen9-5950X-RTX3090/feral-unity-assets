using UnityEngine;

public class QueensDuelUIManager : MonoBehaviour
{
	public Canvas hudCanvas;

	[Space]
	public GameObject gameHUD;

	public GameObject selectReRollScreen;

	public GameObject attackScreen;

	public QueensDuelUI_ColumnScore[] playerColumnScores;

	public QueensDuelUI_ColumnScore[] opponentColumnScores;

	public QueensDuelUI_ColumnScore[] diceKeepers;

	public float columnScoreOffset;

	private QueensDuelGame _game;

	internal void Init()
	{
	}

	internal void UpdateScores(bool inPlayer)
	{
	}

	internal void ShowHUD(bool inShow)
	{
	}

	internal void ShowSelectReRoll(bool inShow)
	{
	}

	internal void ShowCompare(bool inShow)
	{
	}

	public void BtnClicked_SelectReRoll()
	{
	}

	public void BtnClicked_Attack()
	{
	}
}
