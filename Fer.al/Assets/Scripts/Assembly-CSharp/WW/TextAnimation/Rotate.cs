using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class Rotate : CharacterAnimator
	{
		[SerializeField]
		private float _speedScale;

		private Matrix4x4 matrix;

		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
