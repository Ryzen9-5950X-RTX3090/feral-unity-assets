using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace WW.TextAnimation
{
	[ExecuteAlways]
	public class UI_TextAnimator : MonoBehaviour
	{
		[SerializeField]
		private WWTextMeshProUGUI _text;

		[SerializeField]
		[Range(0f, 1f)]
		private float _animationStrength;

		[SerializeField]
		private CharacterAnimatorCollection _animatorCollection;

		[SerializeField]
		[Tooltip("These animators will apply to the whole text")]
		private List<CharacterAnimator> _globalAnimators;

		private Vector3[] _originalPositions;

		private Dictionary<string, ICharacterAnimator> _animatorById;

		private List<ICharacterAnimator>[] _animatorByCharacterIndex;

		private string _textLastFrame;

		private UI_Window_Dialog _dialogWindow;

		public float AnimationStrength
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private float VisibleCharacters
		{
			get
			{
				return default(float);
			}
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
