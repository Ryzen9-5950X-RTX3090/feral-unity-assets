using System;
using System.Collections.Generic;
using Rewired.ComponentControls.Data;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	[CustomClassObfuscation]
	public class CustomController : ComponentController
	{
		[Serializable]
		public class CreateCustomControllerSettings
		{
			[CustomObfuscation]
			[SerializeField]
			[Tooltip("If true, a new Custom Controller will be created. Otherwise, an existing Custom Controller will be found using the selector properties.")]
			private bool _createCustomController;

			[SerializeField]
			[CustomObfuscation]
			[Tooltip("The source id of the Custom Controller to create. Get this from the Rewired Input Manager.")]
			private int _customControllerSourceId;

			[SerializeField]
			[CustomObfuscation]
			[Tooltip("The Player that will be assigned this Custom Controller when it is created.")]
			private int _assignToPlayerId;

			[SerializeField]
			[CustomObfuscation]
			[Tooltip("If true, the Custom Controller created by this component will be destroyed when this component is destroyed.")]
			private bool _destroyCustomController;

			public bool createCustomController
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}

			public int customControllerSourceId
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public int assignToPlayerId
			{
				get
				{
					return default(int);
				}
				set
				{
				}
			}

			public bool destroyCustomController
			{
				get
				{
					return default(bool);
				}
				set
				{
				}
			}
		}

		private struct InputEvent
		{
			public CustomControllerElementSelector.ElementType elementType;

			public int elementIndex;

			public float value;

			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, float value)
			{
			}

			public InputEvent(CustomControllerElementSelector.ElementType elementType, int elementIndex, bool value)
			{
			}

			public bool TargetMatches(CustomControllerElementSelector.ElementType elementType, int elementIndex)
			{
				return default(bool);
			}

			public void Merge(float value)
			{
			}

			public void Merge(bool value)
			{
			}
		}

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Custom Controller elements, etc.")]
		private InputManager_Base _rewiredInputManager;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Contains search parameters to find a particular Custom Controller.")]
		private CustomControllerSelector _customControllerSelector;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("Settings for creating a Custom Controller on start.")]
		private CreateCustomControllerSettings _createCustomControllerSettings;

		private List<InputEvent> _inputEvents;

		[NonSerialized]
		private int _createdCustomControllerId;

		private Action _InputSourceUpdateEvent;

		public InputManager_Base rewiredInputManager
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CustomControllerSelector customControllerSelector
		{
			get
			{
				return null;
			}
		}

		public CreateCustomControllerSettings createCustomControllerSettings
		{
			get
			{
				return null;
			}
		}

		internal event Action InputSourceUpdateEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		[CustomObfuscation]
		internal CustomController()
		{
		}

		public Rewired.CustomController GetCustomController()
		{
			return null;
		}

		[CustomObfuscation]
		internal override void OnEnable()
		{
		}

		[CustomObfuscation]
		internal override void OnDisable()
		{
		}

		[CustomObfuscation]
		internal override void OnValidate()
		{
		}

		[CustomObfuscation]
		internal override void OnDestroy()
		{
		}

		internal override bool OnInitialize()
		{
			return default(bool);
		}

		internal override void OnSubscribeEvents()
		{
		}

		internal override void OnUnsubscribeEvents()
		{
		}

		public override void ClearControlValues()
		{
		}

		[CustomObfuscation]
		internal virtual bool GetUseCustomController()
		{
			return default(bool);
		}

		[CustomObfuscation]
		internal virtual void SetUseCustomController(bool value)
		{
		}

		internal void SetAxisValue(CustomControllerElementSelector element, float value)
		{
		}

		internal void SetButtonValue(CustomControllerElementSelector element, bool value)
		{
		}

		internal void ClearElementValue(CustomControllerElementTargetSet targetSet)
		{
		}

		internal void ClearElementValue(CustomControllerElementTarget target)
		{
		}

		internal void ClearElementValue(CustomControllerElementSelector element)
		{
		}

		internal int ElementExists_Editor(CustomControllerElementSelector element)
		{
			return default(int);
		}

		internal bool ElementExists(CustomControllerElementSelector element)
		{
			return default(bool);
		}

		internal bool ValidateElements(CustomControllerElementTargetSet targetSet)
		{
			return default(bool);
		}

		internal bool ValidateElement(CustomControllerElementTarget target)
		{
			return default(bool);
		}

		internal bool ValidateElement(CustomControllerElementSelector element)
		{
			return default(bool);
		}

		private void OnSetProperty()
		{
		}

		private bool CheckIsRewiredReady()
		{
			return default(bool);
		}

		private void ProcessInputEvents()
		{
		}

		private Rewired.CustomController GetCustomController(bool warn)
		{
			return null;
		}

		private void TryAssignCustomControllerToPlayer(Rewired.CustomController customController)
		{
		}

		private void TryDestroyCustomController()
		{
		}

		private void OnInputSourceUpdate()
		{
		}
	}
}
