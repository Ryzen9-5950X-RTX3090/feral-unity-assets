using UnityEngine;

public class CutsceneTriggerDirectional : CutsceneTrigger
{
	[SerializeField]
	private Vector3 _velocityDirection;

	[SerializeField]
	private float _angularThresholdEpsilonDegrees;

	protected override bool IsTriggerConditionMet(Collider other)
	{
		return default(bool);
	}
}
