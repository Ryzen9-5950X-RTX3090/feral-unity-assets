using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public sealed class CustomController_Editor
	{
		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public abstract class Element
		{
			public int elementIdentifierId;

			public string name;

			public Element()
			{
			}

			public Element(string name, int elementIdentifierId)
			{
			}

			public abstract Element Clone();
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class Button : Element
		{
			public Button()
			{
			}

			public Button(string name)
			{
			}

			public Button(string name, int elementIdentifierId)
			{
			}

			public Button(Button source)
			{
			}

			public override Element Clone()
			{
				return null;
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class Axis : Element
		{
			public AxisRange range;

			public bool invert;

			public float deadZone;

			public float zero;

			public float min;

			public float max;

			public bool doNotCalibrateRange;

			public AxisSensitivityType sensitivityType;

			public float sensitivity;

			public AnimationCurve sensitivityCurve;

			public HardwareAxisInfo axisInfo;

			public Axis()
			{
			}

			public Axis(string name)
			{
			}

			[Obsolete]
			public Axis(string name, string positiveName, string negativeName, int elementIdentifierId, AxisRange range, bool invert, float deadZone, float zero, float min, float max, bool doNotCalibrateRange, HardwareAxisInfo axisInfo)
			{
			}

			public Axis(Axis source)
			{
			}

			public override Element Clone()
			{
				return null;
			}
		}

		[SerializeField]
		[CustomObfuscation]
		private string _name;

		[SerializeField]
		[CustomObfuscation]
		private string _descriptiveName;

		[CustomObfuscation]
		[SerializeField]
		private int _id;

		[SerializeField]
		[CustomObfuscation]
		private string _typeGuidString;

		[CustomObfuscation]
		[SerializeField]
		private List<ControllerElementIdentifier> _elementIdentifiers;

		[CustomObfuscation]
		[SerializeField]
		private List<Axis> _axes;

		[CustomObfuscation]
		[SerializeField]
		private List<Button> _buttons;

		[CustomObfuscation]
		[SerializeField]
		private int _elementIdentifierIdCounter;

		public string name
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string descriptiveName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public int id
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public Guid typeGuid
		{
			get
			{
				return default(Guid);
			}
			internal set
			{
			}
		}

		internal string typeGuidString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<ControllerElementIdentifier> elementIdentifiers
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public List<Axis> axes
		{
			get
			{
				return null;
			}
		}

		public List<Button> buttons
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

		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers
		{
			get
			{
				return null;
			}
		}

		public CustomController_Editor()
		{
		}

		public CustomController_Editor(CustomController_Editor source)
		{
		}

		public CustomController_Editor Clone()
		{
			return null;
		}

		public string[] GetElementIdentifierNames()
		{
			return null;
		}

		public int[] GetElementIdentifierIds()
		{
			return null;
		}

		public string[] GetElementIdentifierNamesTypeSorted()
		{
			return null;
		}

		public int[] GetElementIdentifierIdsTypeSorted()
		{
			return null;
		}

		public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted()
		{
			return null;
		}

		public bool ContainsElementIdentifier(int id)
		{
			return default(bool);
		}

		public int IndexOfElementIdentifier(int id)
		{
			return default(int);
		}

		public ControllerElementIdentifier GetElementIdentifier(int id)
		{
			return null;
		}

		internal ControllerElementType hGhgQvKnDTIVWxqxMxhXqbRHHudm(int P_0)
		{
			return default(ControllerElementType);
		}

		internal bool lSbrgXrclydwTcojyhHBHcbAQBdD(int P_0, out AxisRange P_1)
		{
			return default(bool);
		}

		public string[] GetButtonNames()
		{
			return null;
		}

		public int[] GetButtonElementIdentifierIds()
		{
			return null;
		}

		public string[] GetAxisNames()
		{
			return null;
		}

		public int[] GetAxisElementIdentifierIds()
		{
			return null;
		}

		public string[] GetElementNames<T>() where T : Element
		{
			return null;
		}

		public string[] GetElementNames(ControllerElementType type)
		{
			return null;
		}

		public int[] GetElementElementIdentifierIds(ControllerElementType type)
		{
			return null;
		}

		public T GetElement<T>(int index) where T : Element
		{
			return null;
		}

		public void AddElement(ControllerElementType type)
		{
		}

		public void AddAxis()
		{
		}

		public void AddButton()
		{
		}

		public void InsertElement(ControllerElementType type, int index)
		{
		}

		public void InsertAxis(int index)
		{
		}

		public void InsertButton(int index)
		{
		}

		public void DeleteElement(ControllerElementType type, int index)
		{
		}

		public void DeleteElement<T>(int index) where T : Element
		{
		}

		public bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow)
		{
			return default(bool);
		}

		public void DuplicateElement(ControllerElementType type, int index)
		{
		}

		private void IBkhfPGXuQCObTKLeuxECeGTUYdg<T>(int P_0, List<T> P_1) where T : Element
		{
		}

		private ControllerElementIdentifier VlKfKUdoYlcpTLYqPXVpNksMeoWC(int P_0, string P_1)
		{
			return null;
		}

		private Element NydclpceECiebAbzIHPdaAGYsynp(ControllerElementType P_0)
		{
			return null;
		}

		private ControllerElementIdentifier QjDFEfWTsnDshMbqLGuaWVpfnbC(ControllerElementType P_0, string P_1, string P_2, string P_3)
		{
			return null;
		}

		internal HardwareControllerMap_Game MFnHAHAIawNTxLntEWHpOpiXEWk()
		{
			return null;
		}
	}
}
