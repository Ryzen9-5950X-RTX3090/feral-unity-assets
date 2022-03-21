using UnityEngine;

public class Inspiration : Interactable
{
	[SerializeField]
	private GameObject _groupFx;

	private InspirationDefComponent _inspirationDefComponent;

	private InspirationDefComponent inspirationDefComponent
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	private void GiveToPlayer()
	{
	}
}
