using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation]
	public class CustomControllerElementTargetSetForBoolean : CustomControllerElementTargetSet
	{
		private const int gAnvtLVbWGYxtOwlauGXwInwxxc = 1;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The target element.")]
		private CustomControllerElementTarget _target;

		public CustomControllerElementTarget target
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

		internal CustomControllerElementTargetSetForBoolean()
		{
		}

		internal CustomControllerElementTargetSetForBoolean(CustomControllerElementTarget target)
		{
		}

		internal override void ClearElementCaches()
		{
		}
	}
}
