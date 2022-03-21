using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class TRSByCurve : CharacterAnimator
	{
		[SerializeField]
		[Header("Move")]
		private AnimationCurve _moveXCurve;

		[SerializeField]
		private AnimationCurve _moveYCurve;

		[SerializeField]
		private Vector2 _moveSpeed;

		[SerializeField]
		private Vector2 _moveCurveScale;

		[SerializeField]
		[Header("Rotate")]
		private AnimationCurve _rotateCurve;

		[SerializeField]
		private float _rotationSpeed;

		[SerializeField]
		[Header("Scale")]
		private AnimationCurve _scaleCurve;

		[SerializeField]
		private float _scaleSpeed;

		[SerializeField]
		private float _scaleCurveScale;

		[SerializeField]
		[Header("All")]
		private float _curveOffsetPerCharacter;

		private Matrix4x4 matrix;

		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
