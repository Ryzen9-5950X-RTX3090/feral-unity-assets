using System;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public abstract class TouchControl : CustomControllerControl
	{
		private Canvas _canvas;

		private RectTransform __rectTransform;

		internal TouchController touchController
		{
			get
			{
				return null;
			}
		}

		internal Canvas canvas
		{
			get
			{
				return null;
			}
		}

		internal RectTransform canvasTransform
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

		internal override bool hasController
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		internal TouchControl()
		{
		}

		[CustomObfuscation]
		internal override void OnValidate()
		{
		}

		[CustomObfuscation]
		internal override void OnCanvasGroupChanged()
		{
		}

		[CustomObfuscation]
		internal override void OnTransformParentChanged()
		{
		}

		internal override bool OnInitialize()
		{
			return default(bool);
		}

		internal override void OnSetProperty()
		{
		}

		[CustomObfuscation]
		internal override IComponentController FindController()
		{
			return null;
		}

		[CustomObfuscation]
		internal override Type GetRequiredControllerType()
		{
			return null;
		}

		private bool GEgOhDhFWzlyUDjyMHeIcciCspI(bool P_0, bool P_1)
		{
			return default(bool);
		}
	}
}
