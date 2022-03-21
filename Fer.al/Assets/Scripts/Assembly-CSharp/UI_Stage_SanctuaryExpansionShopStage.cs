using UnityEngine;

public class UI_Stage_SanctuaryExpansionShopStage : UI_Stage
{
	[SerializeField]
	private StageCameraSetting _cameraSetting_Default;

	public override Transform SpinTarget
	{
		get
		{
			return null;
		}
	}

	public override StageCameraSetting ActiveCameraSetting
	{
		get
		{
			return null;
		}
	}

	protected override void Start()
	{
	}

	public override void RemoveScene(string inLevelDefId)
	{
	}
}
