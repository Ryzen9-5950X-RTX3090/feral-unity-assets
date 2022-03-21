using System;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public sealed class TouchController : CustomController
	{
		[SerializeField]
		[CustomObfuscation]
		[Tooltip("If true, disables mouse input when the Touch Controller script is enabled or GameObject is activated and re-enables mouse input when the script is disabled or GameObject is deactivated. This is useful for disabling Mouse Look controls when using touch controls in an FPS for example.")]
		private bool _disableMouseInputWhenEnabled;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If true, a Custom Controller will be populated with the data from this controller.")]
		private bool _useCustomController;

		public bool disableMouseInputWhenEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool useCustomController
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[CustomObfuscation]
		private TouchController()
		{
		}

		[CustomObfuscation]
		internal override void OnDisable()
		{
		}

		internal override bool OnInitialize()
		{
			return default(bool);
		}

		[CustomObfuscation]
		internal override bool GetUseCustomController()
		{
			return default(bool);
		}

		[CustomObfuscation]
		internal override void SetUseCustomController(bool value)
		{
		}

		private void SetMouseState(bool state)
		{
		}

		private void OnSetProperty()
		{
		}

		private bool CheckIsRewiredReady()
		{
			return default(bool);
		}
	}
}
