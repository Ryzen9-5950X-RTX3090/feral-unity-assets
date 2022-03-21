using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

[SelectionBase]
public class Match3Tile : MonoBehaviour
{
	[SerializeField]
	private Match3TileType tileType;

	public Animator tileAnimator;

	public SpriteRenderer tileSprite;

	private AnimatorOverrideController _overrideAnimatorController;

	private GameObject _eggShineFx;

	private int _tileHealth;

	private bool _boosterTileReadyForRemoval;

	public int TileHealth
	{
		get
		{
			return default(int);
		}
	}

	public bool Moving
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float LastMoveTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool CanMatch
	{
		get
		{
			return default(bool);
		}
	}

	public BoosterType Booster
	{
		[CompilerGenerated]
		get
		{
			return default(BoosterType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsBoosted
	{
		get
		{
			return default(bool);
		}
	}

	public bool BoosterActivatedByUserOnly
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsBoosterAnyColorBomb
	{
		get
		{
			return default(bool);
		}
	}

	public Match3TileType TileType
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Match3TileType BoosterUnderlyingTileType
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void OnDestroy()
	{
	}

	private void SetSprite(Sprite inSprite)
	{
	}

	private void SetAnimation(AnimationClip inAnimClip)
	{
	}

	public void UpdateTileType()
	{
	}

	public void SetBoosterType(BoosterType inType, Match3TileType inUnderlyingType)
	{
	}

	public void DropToCell(Match3Cell inCell, float inDuration, float delay = 0f, [Optional] Action<Match3Cell, bool> onMoveFinished)
	{
	}

	public void MoveToCell(Match3Cell inCell, float inDuration, [Optional] Action<Match3Cell, bool> onMoveFinished)
	{
	}

	public void MoveBlocked(Vector3 inDirection, float inDuration)
	{
	}

	public bool OnTileMatched(bool clearedByPeacock = false)
	{
		return default(bool);
	}

	public void ActivateBoosterTile()
	{
	}

	public void RemoveBoosterTile()
	{
	}

	[IteratorStateMachine(typeof(<RemoveBoosterWhenReady>d__47))]
	private IEnumerator RemoveBoosterWhenReady()
	{
		return null;
	}

	public void DoBoosterUpgradeInPlace(BoosterType inBoosterType, Match3TileType inBaseBoosterType)
	{
	}

	public void AddHealth(int inAmount)
	{
	}

	public void ChangeToSpecialOrderTileType(Match3TileType inSpecialOrderType)
	{
	}

	private void PlayStandardRemovalFx()
	{
	}

	private void PlayClearedByPeacockFx()
	{
	}

	private void PlayTwinTroubleRemovalFx()
	{
	}

	private void PlayDoubleTwinTroubleRemovalFx()
	{
	}

	private void PlayFlyerHorizontalRemovalFx()
	{
	}

	private void PlayerFlyerVerticalRemovalFx()
	{
	}

	public void PlayBoosterFx()
	{
	}

	public void PlayBoosterSpawnInFx()
	{
	}

	public void PlayBoosterActivatedFx()
	{
	}

	private void RemoveEggShineFx()
	{
	}

	public void PlayEggShineFx()
	{
	}

	public void PlayEggHatchFx()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void EditorUpdateTileType()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void MakeTilePeacock()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void MakeTileBomb()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void MakeTileFlyerHorizontal()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void MakeTileFlyerVertical()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void MakeTileEgg()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void MakeTileNotEgg()
	{
	}
}
