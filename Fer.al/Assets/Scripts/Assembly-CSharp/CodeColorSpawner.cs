using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class CodeColorSpawner : MonoBehaviour
{
	public int totalActiveIngredients;

	public Transform spawnPoint;

	public Transform dropPoint;

	public GameObject hatch;

	public CodeBreakerIngredient ingredientPrefab;

	public float interval;

	public TextMeshPro spawnCountText;

	private List<CodeBreakerIngredient> _ingredients;

	private Rigidbody _wheelBody;

	private CodeBreakerIngredient readyIngredient;

	private FixedJoint readyIngredientPin;

	private Vector3 _startingHatchRotation;

	public int IngredientsLeft
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

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnSpawnerActivated()
	{
	}

	public void Setup(IngredientWheel inWheel, int inSpawnCount)
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(<SpawnIngredients>d__22))]
	private IEnumerator SpawnIngredients()
	{
		return null;
	}

	public void ReadyNextIngredient()
	{
	}

	public CodeBreakerIngredient Spawn()
	{
		return null;
	}

	public CodeBreakerIngredient GetNearestToPoint(Transform inPoint)
	{
		return null;
	}

	public CodeBreakerIngredient DropIngredient(Vector3 inDropToPos)
	{
		return null;
	}

	public bool RemoveIngredientFromSpawner(CodeBreakerIngredient inIngredient)
	{
		return default(bool);
	}
}
