using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class PerlinShake : CharacterAnimator
	{
		[SerializeField]
		private float _speedScale;

		[SerializeField]
		private Vector2 _moveScale;

		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
