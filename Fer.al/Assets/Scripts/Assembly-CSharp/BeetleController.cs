using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class BeetleController : MonoBehaviour
{
	public CodeBreakerGame game;

	public Beetle beetlePrefab;

	public Material evenBeetleMaterial;

	public Material oddBeetleMaterial;

	public Transform beetleSpawnOrigin;

	public Transform beetleCatchPos;

	public float beetleSpawnSpacing;

	public FeralButton mixButton;

	private List<Beetle> _beetles;

	private Beetle _selectedBeetle;

	private int _pausedCount;

	private bool Paused
	{
		get
		{
			return default(bool);
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	public void ClearBeetles()
	{
	}

	public void Setup(int inCount, bool isTutorial = false)
	{
	}

	public bool CanHandleDrop()
	{
		return default(bool);
	}

	private Beetle GetFirstAvailableBeetle()
	{
		return null;
	}

	private void OnBeetleSelected(BeetleSelectedMessage inMessage)
	{
	}

	private void OnIngredientDropped(IngredientDropMessage inMessage)
	{
	}

	public void OnMixIngredients()
	{
	}

	public void OnMixIngredientsTutorial()
	{
	}

	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage)
	{
	}

	private void OnLevelFinished(CodeBreakerLevelFinishedMessage inMessage)
	{
	}

	public Code GetCode()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MixIngredientsSequence>d__27))]
	private IEnumerator MixIngredientsSequence(Code inCode, bool isTutorial = false)
	{
		return null;
	}
}
