using DG.DeInspektor.Attributes;
using UnityEngine;

public class TransformDistanceContraint : MonoBehaviour
{
	public Transform target;

	public float distance;

	private void Update()
	{
	}

	[DeMethodButton(null, 0, new object[] { })]
	private void LogCurrentDistance()
	{
	}
}
