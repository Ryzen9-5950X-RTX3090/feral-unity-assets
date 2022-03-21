using TMPro;

public class UI_ActorNamebar : UI_ScreenSpaceTransform
{
	public WWTextMeshProUGUI namebarText;

	private ActorBase _targetActor;

	public ActorBase TargetActor
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void MOnDestroy()
	{
	}

	public override void MStart()
	{
	}

	public void UpdateNamebarText()
	{
	}
}
