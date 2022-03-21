using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	public interface ICharacterAnimator
	{
		string Id { get; }

		void UpdateAnimation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength);
	}
}
