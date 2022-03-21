using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class ScaleAndSkew : CharacterAnimator
	{
		[SerializeField]
		private float _duration;

		[SerializeField]
		private AnimationCurve _scaleXCurve;

		[SerializeField]
		private AnimationCurve _scaleYCurve;

		[SerializeField]
		private AnimationCurve _skewCurve;

		private Matrix4x4 matrix;

		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
