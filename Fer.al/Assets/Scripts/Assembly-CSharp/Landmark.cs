using UnityEngine;

public class Landmark : MonoBehaviour
{
	[RootSelector("Landmark Def", "CraftableItemChartData", false, false)]
	public string landmarkDefId;

	public Collider inViewCollider;

	private SphereCollider _inRangeCollider;

	private LandmarkDefComponent _landmarkDef;

	public LandmarkDefComponent LandmarkDef
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void SetupRangeCollider()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
