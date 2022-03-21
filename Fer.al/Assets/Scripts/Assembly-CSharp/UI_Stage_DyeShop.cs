using UnityEngine;

public class UI_Stage_DyeShop : UI_Stage
{
	[SerializeField]
	private StageCameraSetting _cameraSetting_Default;

	[SerializeField]
	private MeshRenderer[] _cauldronLiquidRenderers;

	[SerializeField]
	private Light _cauldronLight;

	[SerializeField]
	private ParticleSystem[] _particleSystems;

	[SerializeField]
	private GameObject _particleSystemGroup;

	[SerializeField]
	private ActorNPCSpawner _shopkeep;

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

	public void SetCurrentDye(BaseDef inItem)
	{
	}

	public override void RemoveScene(string inLevelDefId)
	{
	}

	public void SetIsCrafting(bool inIsCrafting)
	{
	}

	protected override void Start()
	{
	}
}
