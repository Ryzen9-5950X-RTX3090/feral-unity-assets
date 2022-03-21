using UnityEngine;

public class Match3GameBoardInput : MonoBehaviour
{
	public Match3GameBoard gameBoard;

	public Camera gameBoardCamera;

	public LayerMask touchMask;

	public float dragThreshold;

	public float tapThreshold;

	private Match3Cell startTouchCell;

	private Vector2 startTouchPos;

	private float touchTimer;

	private void Update()
	{
	}
}
