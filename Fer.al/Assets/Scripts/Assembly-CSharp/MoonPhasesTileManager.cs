using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoonPhasesTileManager : MonoBehaviour
{
	public float dealMoveTime;

	[Tooltip("The time between each tile being dealt out")]
	public float dealDelay;

	public float dealerPlayTime;

	public float dealerFlipTime;

	public float tileCompareTime;

	public MoonPhasesTile tilePrefab;

	public Transform dealPosition;

	public Transform[] playerTilePositions;

	public Transform[] dealerTilePositions;

	public Transform[] playerPlayPositions;

	public Transform[] dealerPlayPositions;

	public float validSpotDistance;

	public float tileDropTime;

	public float rotateTime;

	public float dealerFlipRiseHeight;

	internal MoonPhasesTile[] allTiles;

	private int _numTilesInMotion;

	private int[] _initialDealIndexes;

	private List<int> _tileIndexes;

	private MoonPhasesGame _game;

	internal void Init()
	{
	}

	internal string[] NotServerReadyRequestDeal()
	{
		return null;
	}

	internal void RequestDrawCard(bool inDraw)
	{
	}

	internal void DrawCardResponse(int inPlayerHit, int inDealerHit)
	{
	}

	internal string[] NotServerReadyGetTieTiles()
	{
		return null;
	}

	internal void DealTilesResponse(ParlorGameCommand inParlorGameCommand)
	{
	}

	private string GetDealerFirstPlay(int[] inTileIndexes)
	{
		return null;
	}

	internal void DealHandCards()
	{
	}

	private bool DealerShouldHit()
	{
		return default(bool);
	}

	private void UpdateHandType(MoonPhasesGame.Player inPlayer)
	{
	}

	internal void DealTie(int playerValue, int opponentValue)
	{
	}

	[IteratorStateMachine(typeof(<MoveTile>d__31))]
	private IEnumerator MoveTile(Transform inTrans, Vector3 inEndPosition, bool inUseLocal)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RotateTile>d__32))]
	private IEnumerator RotateTile(Transform inTrans, Vector3 inEndRotation)
	{
		return null;
	}

	internal void DropTile(MoonPhasesTile inTile)
	{
	}

	internal void PlayerPlayed(int inIndex)
	{
	}

	private void SetPlayerHandType()
	{
	}

	internal void TileMoved()
	{
	}

	private MoonPhasesTile DealTile(bool inPlayerTile, int inDeckIndex, int inHandIndex, float inDelay)
	{
		return null;
	}

	internal void ReturnTile(MoonPhasesTile inTile)
	{
	}

	[IteratorStateMachine(typeof(<CollectAllTiles>d__39))]
	internal IEnumerator CollectAllTiles()
	{
		return null;
	}

	private void TieUpdateHandChq(MoonPhasesGame.Player inPlayer, int inTileValue)
	{
	}

	private List<MoonPhasesTile> InitSuit(MoonPhasesTile.ETileType inTileType)
	{
		return null;
	}

	internal void Cleanup()
	{
	}
}
