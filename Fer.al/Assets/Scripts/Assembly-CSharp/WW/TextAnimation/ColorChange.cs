using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class ColorChange : CharacterAnimator
	{
		[SerializeField]
		private float _speedScale;

		[SerializeField]
		private Gradient _gradient;

		[SerializeField]
		private bool _offsetByVertPosition;

		[SerializeField]
		private float _offset;

		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
