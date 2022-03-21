using DG.DeInspektor.Attributes;
using UnityEngine;

public class FaceCamera : ManagedBehaviour
{
	[SerializeField]
	private bool _reverse;

	[SerializeField]
	[DeComment("Optional: leave blank to use Camera.main", 3)]
	private Camera _mainCamera;

	private Camera MainCamera
	{
		get
		{
			return null;
		}
	}

	public override void MOnEnable()
	{
	}

	public override void MUpdate()
	{
	}
}
