using UnityEngine;
using UnityEngine.Events;

public class BoneAttacher : ManagedBehaviour
{
	public enum EState
	{
		Attach,
		Instance
	}

	[SerializeField]
	private GameObject _objectReference;

	[SerializeField]
	private float _instanceDestroyTimer;

	public EState state;

	private string _lastBoneName;

	private Transform _lastBone;

	public UnityEvent OnSetup;

	public void Setup(string inBoneName)
	{
	}

	private void Setup()
	{
	}
}
