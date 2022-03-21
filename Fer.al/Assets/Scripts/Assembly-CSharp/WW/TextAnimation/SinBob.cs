using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class SinBob : CharacterAnimator
	{
		[SerializeField]
		private float _speedScale;

		[SerializeField]
		private float _amplitude;

		[SerializeField]
		private float _frequency;

		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
