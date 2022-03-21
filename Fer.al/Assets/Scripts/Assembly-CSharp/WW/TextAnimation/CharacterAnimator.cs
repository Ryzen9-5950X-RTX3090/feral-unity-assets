using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	public abstract class CharacterAnimator : ScriptableObject, ICharacterAnimator
	{
		[SerializeField]
		private string _id;

		public string Id
		{
			get
			{
				return null;
			}
		}

		protected abstract void UpdateAnimationImplementation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength);

		public void UpdateAnimation(TMP_TextInfo inTextInfo, TMP_CharacterInfo inCharInfo, Vector3[] inOriginalPositions, int inVisibleCharacterIndex, float inStrength)
		{
		}
	}
}
