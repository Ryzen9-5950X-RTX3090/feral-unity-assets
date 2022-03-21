using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FCCrowIdle : MonoBehaviour
{
	public Animator animator;

	[SerializeField]
	private string[] parameterNames;

	[SerializeField]
	private float blendSpeed;

	[SerializeField]
	private float minChangeTime;

	[SerializeField]
	private float maxChangeTime;

	[SerializeField]
	private GameObject wings;

	[SerializeField]
	private GameObject branchParent;

	private float timer;

	private float randomWait;

	private float[] previousValues;

	private float[] destinationValues;

	private bool lostGame;

	private bool _crowShown;

	private void Start()
	{
	}

	private void ResetIdleTimes()
	{
	}

	private void Update()
	{
	}

	private void UpdateIdle()
	{
	}

	[IteratorStateMachine(typeof(<LoseGame>d__16))]
	public IEnumerator LoseGame()
	{
		return null;
	}

	public void ResetCrow()
	{
	}

	private void PickNewIdle()
	{
	}

	internal void ShowCrow(bool inShow)
	{
	}
}
