using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Grasshoppers : ManagedBehaviour
{
	public class AgentInfo
	{
		public NavMeshAgent agent;

		public Vector3 position;

		public Quaternion rotation;
	}

	[SerializeField]
	private GameObject _model;

	[SerializeField]
	private float _scale;

	[SerializeField]
	private int _amount;

	[SerializeField]
	private NavMeshAgent _agent;

	[SerializeField]
	private float _spawnRadius;

	[SerializeField]
	private float _runAwayRadius;

	[SerializeField]
	private float _runAwayDistance;

	private List<AgentInfo> _agentInfos;

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	private void SetDestination(AgentInfo inAgentInfo)
	{
	}

	private void OnDrawGizmos()
	{
	}

	private bool GetValidSpawn(AgentInfo inAgentInfo)
	{
		return default(bool);
	}
}
