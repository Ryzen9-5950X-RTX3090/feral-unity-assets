using System.Runtime.CompilerServices;
using UnityEngine;

public class Beetle : MonoBehaviour
{
	private enum BeetleState
	{
		Empty,
		Catching,
		Holding
	}

	public Transform holder;

	public Animator beetleAnimator;

	public Collider touchCollision;

	public Collider beetleBodyCollision;

	public Renderer beetleRenderer;

	public float pushScale;

	public bool canDiscard;

	private Rigidbody _rigidbody;

	private CodeBreakerIngredient _ingredient;

	private Vector3 _startingPosition;

	private BeetleState _state;

	public int CodeIndex
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

	public bool IsEmpty
	{
		get
		{
			return default(bool);
		}
	}

	public CodeColor Color
	{
		get
		{
			return default(CodeColor);
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private bool CheckIfClicked()
	{
		return default(bool);
	}

	public void CatchIngredient(CodeBreakerIngredient inIngredient, Vector3 inCatchPos)
	{
	}

	public void MoveTo(Vector3 inPosition, bool snap = false)
	{
	}

	public void ReturnBeetleToSpawnPosition(float delay = 0f)
	{
	}

	public void HoldIngredient(CodeBreakerIngredient inIngredient)
	{
	}

	public void DropIngredient(Vector3 dropDir, bool enableCollider = false)
	{
	}

	public void DiscardIngredient()
	{
	}

	public void SetMaterial(Material inMaterial)
	{
	}
}
