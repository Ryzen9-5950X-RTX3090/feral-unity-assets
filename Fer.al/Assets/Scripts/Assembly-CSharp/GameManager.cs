using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
	public static GameManager s_Instance;

	public GameObject localTank;

	public Button BoostButton;

	public Button ShootButton;

	public bool IsGameInputEnabled;

	public int RedTeamScore;

	public int BlueTeamScore;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(<StartBuffer>d__10))]
	private IEnumerator StartBuffer()
	{
		return null;
	}

	public void RemoveTank(GameObject tank)
	{
	}
}
