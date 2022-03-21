using Rewired.UI;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(Image))]
	public sealed class TouchJoystickAngleIndicator : MonoBehaviour, IVisibilityChangedHandler, TouchJoystick.IStickPositionChangedHandler
	{
		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Toggles visibility.")]
		private bool _visible;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If enabled, the target angle will be determined by the transform's Local Rotation Z. Otherwise, the activation angle must be manually set.")]
		private bool _targetAngleFromRotation;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The joystick angle at which this object should be considered fully active.\n0 = up with negative values increase rotating clockwise. Example: -45 degrees = up-right.")]
		[Range(0f, -360f)]
		private float _targetAngle;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If enabled, the color will fade in and out based on the current joystick value.")]
		private bool _fadeWithValue;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If enabled, the color will fade in and out based on the current joystick angle. As the angle approaches the Target Angle, the color will become more intense.")]
		private bool _fadeWithAngle;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The angle of rotation away from the Target Angle where the color fully fades out. If Fade with Angle is enabled, this is used to determine when the color will fully fade out when the joystick angle rotates away from the the Target Angle. This should be set to 1/2 of the complete rotation arc. Example: A value of 45 degrees would make the color fully fade out when the joystick angle is 45 degrees away from the Target Angle on either side, giving a complete arc of 90 degrees.")]
		[Range(0f, 360f)]
		private float _fadeRange;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The color when fully active.")]
		private Color _activeColor;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The color when not active.")]
		private Color _normalColor;

		private Image MOnzScNGMahVsBwRiTKJfENaPkWK;

		private RectTransform janXUTfEBbOtfVEXrBkDeQsUuJs;

		private Vector2 PIlMIZoBefVCXhAtsFBXAwIVCuP;

		private bool dqRDuLqtLVFLDdtJiDwKDVlcZyx;

		private IRegistrar<TouchJoystickAngleIndicator> QBLgWjrWdUafnBNnIsAvJHdsCHAQ;

		public bool visible
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool targetAngleFromRotation
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float targetAngle
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool fadeWithValue
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool fadeWithAngle
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float fadeRange
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public Color activeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color normalColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		internal Image image
		{
			get
			{
				return null;
			}
		}

		internal Sprite currentSprite
		{
			get
			{
				return null;
			}
		}

		internal RectTransform rectTransform
		{
			get
			{
				return null;
			}
		}

		[CustomObfuscation]
		private TouchJoystickAngleIndicator()
		{
		}

		internal bool VyvsGUCvHlsGSuXsSdCadpjceAY(out Vector2 P_0)
		{
			return default(bool);
		}

		[CustomObfuscation]
		private void Awake()
		{
		}

		[CustomObfuscation]
		private void OnEnable()
		{
		}

		[CustomObfuscation]
		private void OnDisable()
		{
		}

		[CustomObfuscation]
		private void OnValidate()
		{
		}

		[CustomObfuscation]
		private void OnTransformParentChanged()
		{
		}

		private void GyytlVmiBRgVIBlxHTTMcNlOiTAt(bool P_0, bool P_1)
		{
		}

		private void AIGaSDbmzOWrHijmNvLMcctmyiGD(Vector2 P_0)
		{
		}

		private void mqiaGywLlRymbsGGeFSVkHQPXjn()
		{
		}

		private void ixjtpheoJlhcHpvQksvNDhgeKCH()
		{
		}

		private void cmtbuFqVYbwoFNiprYsdGZCxOJZ()
		{
		}

		private void iVXfGQBKzGTKsBObZnbsqtAcvNp()
		{
		}

		private void HwCTaCdGhAcPRVMVfQOqLnRcdEb()
		{
		}

		public void OnVisibilityChanged(bool state)
		{
		}

		public void OnTouchJoystickStickPositionChanged(Vector2 value)
		{
		}

		void TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 P_0)
		{
		}
	}
}
