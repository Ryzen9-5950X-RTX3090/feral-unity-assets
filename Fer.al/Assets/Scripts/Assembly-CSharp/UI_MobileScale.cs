using UnityEngine;

public class UI_MobileScale : MonoBehaviour
{
	[SerializeField]
	private Transform _targetTransform;

	[SerializeField]
	private Vector3 _mobileScale;

	private Transform TargetTransform
	{
		get
		{
			return null;
		}
	}

	private void OnEnable()
	{
	}
}
