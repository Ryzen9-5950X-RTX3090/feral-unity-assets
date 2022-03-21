using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation]
	public class CustomControllerElementTargetSetForFloat : CustomControllerElementTargetSet
	{
		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Splits the value into positive and negative sides which can be assigned to different Custom Controller elements.")]
		private bool _splitValue;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The target element. This is unused if Split Value is enabled.")]
		private CustomControllerElementTarget _target;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The positive target element. This is unused if Split Value is not enabled.")]
		private CustomControllerElementTarget _positiveTarget;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The negative target element. This is unused if Split Value is not enabled.")]
		private CustomControllerElementTarget _negativeTarget;

		public bool splitValue
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public CustomControllerElementTarget target
		{
			get
			{
				return null;
			}
		}

		public CustomControllerElementTarget positiveTarget
		{
			get
			{
				return null;
			}
		}

		public CustomControllerElementTarget negativeTarget
		{
			get
			{
				return null;
			}
		}

		internal override int targetCount
		{
			get
			{
				return default(int);
			}
		}

		internal override CustomControllerElementTarget this[int index]
		{
			get
			{
				return null;
			}
		}

		internal CustomControllerElementTargetSetForFloat()
		{
		}

		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget target)
		{
		}

		internal CustomControllerElementTargetSetForFloat(CustomControllerElementTarget positiveTarget, CustomControllerElementTarget negativeTarget)
		{
		}

		internal override void ClearElementCaches()
		{
		}
	}
}
