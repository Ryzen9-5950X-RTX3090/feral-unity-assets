using System.Collections.Generic;
using UnityEngine;

namespace WW.TextAnimation
{
	[CreateAssetMenu]
	public class CharacterAnimatorCollection : ScriptableObject
	{
		public List<CharacterAnimator> characterAnimators;
	}
}
