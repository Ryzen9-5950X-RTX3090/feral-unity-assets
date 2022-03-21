using UnityEngine;

public class AnimTest_Movement : MonoBehaviour
{
	private Animator animator;

	public float walkSpeed;

	public float runSpeed;

	public float turnSpeed;

	[SerializeField]
	private GameObject harvestPoint;

	private GameObject harvestPointInstance;

	private Animator harvestPointAnimator;

	private CharacterController harvestPointCharacterController;

	private Vector3 moveDirection;

	private CharacterController controller;

	private float gravity;

	private float moveX;

	private float moveZ;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
