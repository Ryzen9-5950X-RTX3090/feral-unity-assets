using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class FadeInCharacters : CharacterAnimator
	{
		[SerializeField]
		private Vector3 _startOffset;

		[SerializeField]
		private AnimationCurve _fadeCurve;

		[SerializeField]
		private float _defaultFadeSpeed;

		private UI_Window_Dialog _dialogWindow;

		private float _startTime;

		private float VisibleCharacters
		{
			get
			{
				return default(float);
			}
		}

		protected override void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
