using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.Components
{
	[Serializable]
	public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource
	{
		[Serializable]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2>
		{
		}

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If enabled, the screen position will default to the center of the allowed movement area. Otherwise, it will default to the lower-left corner of the allowed movement area.")]
		private bool _defaultToCenter;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The pointer speed. This does not affect the speed of input from the mouse x/y axes if useHardwarePointerPosition is enabled. It only affects the speed from input sources other than mouse x/y or if mouse x/y are mapped to Actions assigned to Axes. ")]
		private float _pointerSpeed;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("If enabled, the hardware pointer position will be used for mouse input. Otherwise, the position of the pointer will be calculated only from the Axis Action values. The Player that owns this Player Mouse must have the physical mouse assigned to it in order for the hardware position to be used, ex: player.controllers.hasMouse == true.")]
		private bool _useHardwarePointerPosition;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The allowed movement area for the mouse pointer. Set Movement Area Unit to determine the data format of this value. This rect is a screen-space rect with 0, 0 at the lower-left corner.")]
		private Rect _movementArea;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The unit format of the movement area. This is used to determine the data format of Movement Area.")]
		private Rewired.PlayerMouse.MovementAreaUnit _movementAreaUnit;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Triggered when the screen position changes. Link this to your pointer to drive its position.")]
		private ScreenPositionChangedHandler _onScreenPositionChanged;

		private new Rewired.PlayerMouse source
		{
			get
			{
				return null;
			}
		}

		public bool defaultToCenter
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ScreenRect movementArea
		{
			get
			{
				return default(ScreenRect);
			}
			set
			{
			}
		}

		public Rewired.PlayerMouse.MovementAreaUnit movementAreaUnit
		{
			get
			{
				return default(Rewired.PlayerMouse.MovementAreaUnit);
			}
			set
			{
			}
		}

		public Vector2 screenPosition
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 screenPositionPrev
		{
			get
			{
				return default(Vector2);
			}
		}

		public Vector2 screenPositionDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		public Rewired.PlayerController.MouseAxis xAxis
		{
			get
			{
				return null;
			}
		}

		public Rewired.PlayerController.MouseAxis yAxis
		{
			get
			{
				return null;
			}
		}

		public Rewired.PlayerController.MouseWheel wheel
		{
			get
			{
				return null;
			}
		}

		public Rewired.PlayerController.Button leftButton
		{
			get
			{
				return null;
			}
		}

		public Rewired.PlayerController.Button rightButton
		{
			get
			{
				return null;
			}
		}

		public Rewired.PlayerController.Button middleButton
		{
			get
			{
				return null;
			}
		}

		public float pointerSpeed
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public bool useHardwarePointerPosition
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		bool IMouseInputSource.enabled
		{
			get
			{
				return default(bool);
			}
		}

		Vector2 IMouseInputSource.screenPosition
		{
			get
			{
				return default(Vector2);
			}
		}

		Vector2 IMouseInputSource.screenPositionDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		Vector2 IMouseInputSource.wheelDelta
		{
			get
			{
				return default(Vector2);
			}
		}

		bool IMouseInputSource.locked
		{
			get
			{
				return default(bool);
			}
		}

		public event Action<Vector2> ScreenPositionChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		protected override void OnValidated()
		{
		}

		protected override void OnReset()
		{
		}

		protected override Rewired.PlayerController CreateSource(object args)
		{
			return null;
		}

		protected override void Deinitialize()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		internal override List<ElementInfo> CreateDefaultElementInfos()
		{
			return null;
		}

		private void npVtBgceAHVLlZaPfSMcUPDrKfH(Vector2 P_0)
		{
		}

		bool IMouseInputSource.GetButtonDown(int P_0)
		{
			return default(bool);
		}

		bool IMouseInputSource.GetButtonUp(int P_0)
		{
			return default(bool);
		}

		bool IMouseInputSource.GetButton(int P_0)
		{
			return default(bool);
		}

		[SpecialName]
		bool IPlayerController.get_enabled()
		{
			return default(bool);
		}

		[SpecialName]
		void IPlayerController.set_enabled(bool P_0)
		{
		}
	}
}
