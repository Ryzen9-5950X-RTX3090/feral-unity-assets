using UnityEngine;
using UnityEngine.UI;

public class QuestIcon : UI_ScreenSpaceTransform
{
	public WWImage iconImage;

	public Vector3 localOffset;

	private Transform _localOffsetTransform;

	public override void MStart()
	{
	}

	private void LateUpdate()
	{
	}
}
