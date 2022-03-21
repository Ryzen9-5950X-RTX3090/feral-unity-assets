using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ActorBaseDataObject : ScriptableObject
{
	public RuntimeAnimatorController animatorController;

	public List<RuntimeAnimatorController> stanceOverrides;

	[SerializeField]
	private AudioActor _audioActor;

	[SerializeField]
	private bool _flyingActor;

	public AudioActor audioActor
	{
		get
		{
			return null;
		}
	}

	public bool flyingActor
	{
		get
		{
			return default(bool);
		}
	}
}
