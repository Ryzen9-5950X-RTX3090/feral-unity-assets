using UnityEngine;
using UnityEngine.UI;

[ExecuteAlways]
public class Match3UI_PuzzleMaskController : MonoBehaviour
{
	[SerializeField]
	private Graphic _puzzleGraphic;

	[SerializeField]
	private float[] _pieceState;

	private Material _puzzleMat;

	private void Update()
	{
	}
}
