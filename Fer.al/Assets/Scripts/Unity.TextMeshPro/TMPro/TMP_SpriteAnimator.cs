using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace TMPro
{
	[DisallowMultipleComponent]
	public class TMP_SpriteAnimator : MonoBehaviour
	{
		private Dictionary<int, bool> m_animations;

		private TMP_Text m_TextComponent;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void StopAllAnimations()
		{
		}

		public void DoSpriteAnimation(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
		}

		[IteratorStateMachine(typeof(<DoSpriteAnimationInternal>d__7))]
		private IEnumerator DoSpriteAnimationInternal(int currentCharacter, TMP_SpriteAsset spriteAsset, int start, int end, int framerate)
		{
			return null;
		}
	}
}
