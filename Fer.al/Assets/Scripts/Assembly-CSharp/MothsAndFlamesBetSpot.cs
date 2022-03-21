using UnityEngine;

public class MothsAndFlamesBetSpot : MonoBehaviour
{
	public Transform selectedPositionLocator;

	public GameObject LocationIndicator;

	public GameObject circleGlowBlueFX;

	public GameObject circleGlowOrangeFX;

	internal Vector3 selectedPosition;

	internal MothsAndFlamesGame.EBetTypes betType;

	private MothsAndFlamesToken _token;

	private MothsAndFlamesGame _game;

	private MothsAndFlamesBetSpotManager _betSpotManager;

	internal void Init(int inIndex)
	{
	}

	private void OnMouseDown()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
