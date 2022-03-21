using UnityEngine;

public class UI_Stage_DyeShop_SkyMerchant : UI_Stage
{
	[SerializeField]
	private StageCameraSetting _cameraSetting_Default;

	public override StageCameraSetting ActiveCameraSetting
	{
		get
		{
			return null;
		}
	}

	public override Transform SpinTarget
	{
		get
		{
			return null;
		}
	}

	public override void RemoveScene(string inLevelDefId)
	{
	}

	protected override void Start()
	{
	}
}
