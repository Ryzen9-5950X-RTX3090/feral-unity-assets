using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoonPhasesTile : MonoBehaviour
{
	internal enum EMoveType
	{
		Deal,
		Collect,
		DealerPlay,
		FirstTile
	}

	internal enum ETileType
	{
		Zero,
		One,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven
	}

	public ParticleSystem tileHighlightFX;

	public Renderer tileRenderer;

	public Texture[] tileFaces;

	public Vector3 playerPositionsRotation;

	public Vector3 dealerPositionsRotation;

	public Vector3 dealerPlaysRotation;

	internal ETileType tileType;

	internal bool hasBeenDealt;

	internal bool hasBeenPlayed;

	internal int tileValue;

	internal bool canSelect;

	private MoonPhasesGame _game;

	private MoonPhasesTileManager _tileManager;

	private Vector3 _baseScale;

	internal void InitTile(ETileType inTileType)
	{
	}

	private void OnMouseUp()
	{
	}

	private void OnMouseEnter()
	{
	}

	private void OnMouseExit()
	{
	}

	[IteratorStateMachine(typeof(<MoveTile>d__20))]
	internal IEnumerator MoveTile(bool inPlayerTile, float inDelay, Transform inParent, EMoveType inMoveType)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DealerFlip>d__21))]
	internal IEnumerator DealerFlip()
	{
		return null;
	}

	internal void SetTileFace()
	{
	}

	internal void Return()
	{
	}
}
