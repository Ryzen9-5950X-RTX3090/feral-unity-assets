using System.Collections.Generic;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.ComponentControls.Effects
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public sealed class TouchJoystickRadialIndicator : MonoBehaviour, IRegistrar<TouchJoystickAngleIndicator>
	{
		[Tooltip("If enabled, the indicators will be scaled based on the size of the RectTransform.")]
		public bool _scale;

		[Tooltip("If enabled, the aspect ratio will be determined from the Sprite's texture.")]
		public bool _preserveSpriteAspectRatio;

		[Tooltip("The scale ratio of the indicators to the current RectTransform's height. A ratio of 0.1 means the indicator will be 0.1 times the size of the RectTransform's height. This is useful if you need to be able to scale the transform and have the indicators also scale with it.")]
		[Range(0.01f, 1f)]
		public float _scaleRatio;

		[Tooltip("The horizontal component of the desired aspect ratio of the indicator.")]
		[Range(0.01f, 10f)]
		public float _aspectRatioX;

		[Tooltip("The vertical component of the desired aspect ratio of the indicator.")]
		[Range(0.01f, 10f)]
		public float _aspectRatioY;

		[Tooltip("Offsets the indicator position up by this proportion of its height. 1.0 = 1 unit high offset.")]
		public float _offset;

		private static readonly Vector2 vuqfEIdhGneUoobbMaOQeOJhzfVK;

		private RectTransform janXUTfEBbOtfVEXrBkDeQsUuJs;

		private List<TouchJoystickAngleIndicator> nkgGgWbemvNFIZKwdNkahUpHjymJ;

		public bool scale
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool preserveSpriteAspectRatio
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float scaleRatio
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float aspectRatioX
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float aspectRatioY
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public float offset
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		private RectTransform rectTransform
		{
			get
			{
				return null;
			}
		}

		void IRegistrar<TouchJoystickAngleIndicator>.Register(TouchJoystickAngleIndicator P_0)
		{
		}

		void IRegistrar<TouchJoystickAngleIndicator>.Deregister(TouchJoystickAngleIndicator P_0)
		{
		}

		[CustomObfuscation]
		private void Update()
		{
		}

		[CustomObfuscation]
		private void OnValidate()
		{
		}

		[CustomObfuscation]
		private void OnEnable()
		{
		}

		[CustomObfuscation]
		private void OnDestroy()
		{
		}

		private void AdSCOdhklchquRUjivKFFmxhnObU()
		{
		}

		private void AIGaSDbmzOWrHijmNvLMcctmyiGD(TouchJoystickAngleIndicator P_0)
		{
		}

		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ()
		{
		}

		private void hVKLcQTGLcFAhfcrfXDLktdTfuXX()
		{
		}
	}
}
