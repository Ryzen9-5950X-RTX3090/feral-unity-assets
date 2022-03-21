using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class IngredientWheel : MonoBehaviour
{
	public BeetleController beetleController;

	public Transform dropPoint;

	public TouchDrag dragWheel;

	[EnumList(typeof(CodeColor), 0.35f)]
	public List<CodeBreakerIngredient> _ingredients;

	public List<GameObject> ingredientCountOptions;

	public List<GameObject> ingredientBins;

	private List<CodeColorSpawner> _activeSpawners;

	private int _ingredientsPerSpawner;

	private int _pausedCount;

	private bool Paused
	{
		get
		{
			return default(bool);
		}
	}

	public bool CanSpinWheel
	{
		get
		{
			return default(bool);
		}
	}

	public int IngredientTypeCount
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Setup(CodeColor colorFlags, int inIngredientsPerSpawner)
	{
	}

	public int GetTotalIngredients()
	{
		return default(int);
	}

	public bool HasEnoughIngredients(Dictionary<CodeColor, int> inIngrdientCounts)
	{
		return default(bool);
	}

	private void OnCodeColorSpawnerActive(CodeColorSpawnerActiveMessage inMessage)
	{
	}

	private void OnCodeColorSpawnerDeactive(CodeColorSpawnerDeactiveMessage inMessage)
	{
	}

	private void OnIngredientDiscarded(IngredientDiscardedMessage inMessage)
	{
	}

	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage)
	{
	}

	public void OnIngredientDrop()
	{
	}

	public CodeColorSpawner FindNearestSpawner(Vector3 inPosition)
	{
		return null;
	}

	private void EnableIngredientCountOption(List<CodeColor> inColors)
	{
	}

	public bool CheckForLastIngredient(Code inCode)
	{
		return default(bool);
	}

	public void ClearIngredients()
	{
	}
}
