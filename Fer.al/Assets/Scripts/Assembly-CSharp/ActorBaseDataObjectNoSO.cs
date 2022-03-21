using System.Collections.Generic;
using UnityEngine;

public class ActorBaseDataObjectNoSO : MonoBehaviour
{
	public RuntimeAnimatorController animatorController;

	public List<RuntimeAnimatorController> stanceOverrides;

	[SerializeField]
	private AudioActorNoSO _audioActor;

	[SerializeField]
	private bool _flyingActor;

	public AudioActorNoSO audioActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool flyingActor
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}
}
