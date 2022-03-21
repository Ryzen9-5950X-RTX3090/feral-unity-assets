using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation]
	public class CustomControllerElementTarget
	{
		[CustomObfuscation]
		internal enum ValueRange
		{
			[CustomObfuscation]
			Full,
			[CustomObfuscation]
			Positive,
			[CustomObfuscation]
			Negative
		}

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The Custom Controller element.")]
		private CustomControllerElementSelector _element;

		[SerializeField]
		[CustomObfuscation]
		private ValueRange _valueRange;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Should the final value be positive or negative?")]
		private Pole _valueContribution;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Should the final value be inverted?")]
		private bool _invert;

		public CustomControllerElementSelector element
		{
			get
			{
				return null;
			}
		}

		public Pole valueContribution
		{
			get
			{
				return default(Pole);
			}
			set
			{
			}
		}

		internal ValueRange valueRange
		{
			get
			{
				return default(ValueRange);
			}
			set
			{
			}
		}

		public bool invert
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal CustomControllerElementTarget()
		{
		}

		internal CustomControllerElementTarget(CustomControllerElementSelector selector)
		{
		}

		internal void ClearElementCaches()
		{
		}
	}
}
