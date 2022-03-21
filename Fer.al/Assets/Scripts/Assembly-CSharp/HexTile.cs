using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class HexTile : MonoBehaviour
{
	public HexCoord pos;

	public RuneType runeType;

	public Renderer runeRenderer;

	public SpriteRenderer iconRenderer;

	[EnumList(typeof(RuneType), 0.35f)]
	public List<Sprite> icons;

	public TextMeshPro textRenderer;

	public GameObject aoeHighlight;

	public DOTweenAnimator aoeTween;

	public GameObject placementHighlight;

	public GameObject placementOutline;

	public DOTweenAnimator placementTween;

	public Material sharedRuneMaterial;

	private Material _runeMaterial;

	private RuneType _prevRuneType;

	private Vector3 _originalScale;

	private ObscuredInt _score;

	private List<GameObject> _scoreIcons;

	private List<Sequence> _sequences;

	public bool IsEmpty
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCyclone
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsStandardRune
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsPowerUp
	{
		get
		{
			return default(bool);
		}
	}

	public int Score
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	public void SetPowerupAOEHighlight(bool inHighlighted)
	{
	}

	public void SetPlacementHighlight(bool inHighlighted)
	{
	}

	public void SetPlacementOutline(bool inOutlined)
	{
	}

	public void SetTileType(RuneType inRuneType)
	{
	}

	public void RestorePreviousRuneType()
	{
	}

	public void UpdateFaceMaterial()
	{
	}

	public void DoTileScoredEffect(int inCombo, Transform inAnimateTo, float delay, Action<HexTile> onEffectFinished)
	{
	}

	public void DoRuneIconRestoreEffect()
	{
	}

	[DeMethodButton("Update Value by 10", 0, new object[] { })]
	public void DebugUpdateScoreBy10()
	{
	}
}
