using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.Components
{
	[Serializable]
	public class PlayerController : ComponentWrapper<Rewired.PlayerController>, IPlayerController
	{
		[Serializable]
		public class ButtonStateChangedHandler : UnityEvent<int, bool>
		{
		}

		[Serializable]
		public class AxisValueChangedHandler : UnityEvent<int, float>
		{
		}

		[Serializable]
		public class EnabledStateChangedHandler : UnityEvent<bool>
		{
		}

		[Serializable]
		[CustomObfuscation]
		[CustomClassObfuscation]
		internal sealed class ElementWithSourceInfo
		{
			[SerializeField]
			[Tooltip("The name of the element.")]
			private string _name;

			[SerializeField]
			[Tooltip("The element type.")]
			private Rewired.PlayerController.Element.TypeWithSource _elementType;

			[SerializeField]
			[Tooltip("Is this element enabled? Disabled elements return no value.")]
			private bool _enabled;

			[SerializeField]
			[Tooltip("The Action id of the Action which will be used as the input source for the Element.")]
			private int _actionId;

			[SerializeField]
			[Tooltip("The output coordinate mode of the axis. An Absolute axis will only return value for input received from Absolute sources. A Relative axis will return value for input received from both Relative and Absolute sources. When converting from an Absolute input source to a Relative output, absoluteToRelativeSensitivity will be multiplied by the Absolute value to yield a simulated Relative value.")]
			private AxisCoordinateMode _coordinateMode;

			[SerializeField]
			[Tooltip("The absolute to relative sensitivity multiplier. This is only applied when the axis coordinate mode is set to Relative and the axis receives Absolute coordinate mode input (joystick axes, keyboard keys, etc.).")]
			[FieldRange(0f, float.MaxValue)]
			private float _absoluteToRelativeSensitivity;

			[SerializeField]
			[FieldRange(0f, float.MaxValue)]
			[Tooltip("The number of times per second the wheel ticks when the value source is an absolute axis value.")]
			private float _repeatRate;

			public string name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Rewired.PlayerController.Element.TypeWithSource elementType
			{
				get
				{
					return default(Rewired.PlayerController.Element.TypeWithSource);
				}
				set
				{
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public int actionId
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public AxisCoordinateMode coordinateMode
			{
				get
				{
					return default(AxisCoordinateMode);
				}
				set
				{
				}
			}

			public float absoluteSourceSensitivity
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}

			public float repeatRate
			{
				get
				{
					return default(float);
				}
				set
				{
				}
			}

			public Rewired.PlayerController.Element.Definition ToDefinition()
			{
				return null;
			}
		}

		[Serializable]
		[CustomClassObfuscation]
		[CustomObfuscation]
		internal sealed class ElementInfo
		{
			[SerializeField]
			[Tooltip("The name of the element.")]
			private string _name;

			[SerializeField]
			[Tooltip("The element type.")]
			private Rewired.PlayerController.Element.Type _elementType;

			[SerializeField]
			[Tooltip("Is this element enabled? Disabled elements return no value.")]
			private bool _enabled;

			[SerializeField]
			private ElementWithSourceInfo[] _elements;

			public string name
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Rewired.PlayerController.Element.Type elementType
			{
				get
				{
					return default(Rewired.PlayerController.Element.Type);
				}
				set
				{
				}
			}

			public bool enabled
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public ElementWithSourceInfo[] elements
			{
				get
				{
					return null;
				}
				set
				{
				}
			}

			public Rewired.PlayerController.Element.Definition ToDefinition()
			{
				return null;
			}
		}

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Action ids, Player ids, etc.")]
		private InputManager_Base _rewiredInputManager;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The Player id of the Player used for the source of input.")]
		private int _playerId;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The elements that will be created in the controller.")]
		private List<ElementInfo> _elements;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Triggered the first frame the button is pressed or released.")]
		private ButtonStateChangedHandler _onButtonStateChanged;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Triggered when the axis value changes.")]
		private AxisValueChangedHandler _onAxisValueChanged;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("Triggered when the controller is enabled or disabled.")]
		private EnabledStateChangedHandler _onEnabledStateChanged;

		public int playerId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public IList<Rewired.PlayerController.Button> buttons
		{
			get
			{
				return null;
			}
		}

		public IList<Rewired.PlayerController.Axis> axes
		{
			get
			{
				return null;
			}
		}

		public IList<Rewired.PlayerController.Element> elements
		{
			get
			{
				return null;
			}
		}

		public int buttonCount
		{
			get
			{
				return default(int);
			}
		}

		public int axisCount
		{
			get
			{
				return default(int);
			}
		}

		public int elementCount
		{
			get
			{
				return default(int);
			}
		}

		public event Action<int, bool> ButtonStateChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<int, float> AxisValueChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<bool> EnabledStateChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public bool GetButton(int index)
		{
			return default(bool);
		}

		public bool GetButtonDown(int index)
		{
			return default(bool);
		}

		public bool GetButtonUp(int index)
		{
			return default(bool);
		}

		public float GetAxis(int index)
		{
			return default(float);
		}

		public float GetAxisRaw(int index)
		{
			return default(float);
		}

		public Rewired.PlayerController.Element GetElement(int index)
		{
			return null;
		}

		public T GetElement<T>(int index) where T : Rewired.PlayerController.Element
		{
			return null;
		}

		protected override void OnAwake()
		{
		}

		protected override void OnAwakeFinished()
		{
		}

		protected override void OnEnabled()
		{
		}

		protected override void OnDisabled()
		{
		}

		protected override void OnValidated()
		{
		}

		protected override void OnReset()
		{
		}

		protected override void Subscribe()
		{
		}

		protected override void Unsubscribe()
		{
		}

		protected override object GetCreateSourceArgs()
		{
			return null;
		}

		protected override Rewired.PlayerController CreateSource(object args)
		{
			return null;
		}

		internal virtual List<ElementInfo> CreateDefaultElementInfos()
		{
			return null;
		}

		private void sPpozJpKoWGGnOfmDhaoQvukzPV(int P_0, bool P_1)
		{
		}

		private void NwZAfFRzJtqbomIKNDDNEtFbGxU(int P_0, float P_1)
		{
		}

		private void gKJTsKbajFnGIJBaNwoxsdNrBPc(bool P_0)
		{
		}

		private void EJxVIulAFMaUhXXnieLQpmGoCsu()
		{
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
