using System;
using System.Text;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class ActionElementMap
	{
		[SerializeField]
		[CustomObfuscation]
		internal int _actionCategoryId;

		[CustomObfuscation]
		[SerializeField]
		internal int _actionId;

		[CustomObfuscation]
		[SerializeField]
		internal ControllerElementType _elementType;

		[SerializeField]
		[CustomObfuscation]
		internal int _elementIdentifierId;

		[SerializeField]
		[CustomObfuscation]
		internal AxisRange _axisRange;

		[SerializeField]
		[CustomObfuscation]
		internal bool _invert;

		[SerializeField]
		[CustomObfuscation]
		internal Pole _axisContribution;

		[CustomObfuscation]
		[SerializeField]
		internal KeyboardKeyCode _keyboardKeyCode;

		[CustomObfuscation]
		[SerializeField]
		internal ModifierKey _modifierKey1;

		[CustomObfuscation]
		[SerializeField]
		internal ModifierKey _modifierKey2;

		[CustomObfuscation]
		[SerializeField]
		internal ModifierKey _modifierKey3;

		[NonSerialized]
		internal ControllerMap RNrniZeIkGmMkeqZsCLNgsdrTfDu;

		[NonSerialized]
		internal bool RYgMGyqWnNNUOzFUBDIFjvchsBxb;

		[NonSerialized]
		internal string oOMORlOrxgmdGBHNEgbnhrIAoCGC;

		[NonSerialized]
		internal string vzzdNsgcHfbLIdBbrldYLZwQPWL;

		[NonSerialized]
		internal int cIpzjPbNKhTxYBMDvNEwhaGcpst;

		[NonSerialized]
		internal readonly int jotfbgeLQZTIFstijorJbghJlvHQ;

		private static int uidCounter;

		private static StringBuilder s_toStringSB;

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

		public ControllerElementType elementType
		{
			get
			{
				return default(ControllerElementType);
			}
			internal set
			{
			}
		}

		public int elementIdentifierId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public AxisRange axisRange
		{
			get
			{
				return default(AxisRange);
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

		public Pole axisContribution
		{
			get
			{
				return default(Pole);
			}
			set
			{
			}
		}

		public KeyboardKeyCode keyboardKeyCode
		{
			get
			{
				return default(KeyboardKeyCode);
			}
			set
			{
			}
		}

		public ModifierKey modifierKey1
		{
			get
			{
				return default(ModifierKey);
			}
			set
			{
			}
		}

		public ModifierKey modifierKey2
		{
			get
			{
				return default(ModifierKey);
			}
			set
			{
			}
		}

		public ModifierKey modifierKey3
		{
			get
			{
				return default(ModifierKey);
			}
			set
			{
			}
		}

		public AxisType axisType
		{
			get
			{
				return default(AxisType);
			}
		}

		public ModifierKeyFlags modifierKeyFlags
		{
			get
			{
				return default(ModifierKeyFlags);
			}
		}

		public KeyCode keyCode
		{
			get
			{
				return default(KeyCode);
			}
			set
			{
			}
		}

		public bool hasModifiers
		{
			get
			{
				return default(bool);
			}
		}

		public ControllerMap controllerMap
		{
			get
			{
				return null;
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

		public string elementIdentifierName
		{
			get
			{
				return null;
			}
		}

		public string actionDescriptiveName
		{
			get
			{
				return null;
			}
		}

		public int elementIndex
		{
			get
			{
				return default(int);
			}
		}

		public int id
		{
			get
			{
				return default(int);
			}
		}

		private bool isKeyboardMap
		{
			get
			{
				return default(bool);
			}
		}

		private static int nextUid
		{
			get
			{
				return default(int);
			}
		}

		internal static bool dIylxglaohlpiULnXEveptnMtjP(ActionElementMap P_0)
		{
			return default(bool);
		}

		internal static void iWlerSFfasVeRFAYFQtrYHXwKkra(ActionElementMap P_0, ActionElementMap P_1)
		{
		}

		public ActionElementMap()
		{
		}

		public ActionElementMap(ActionElementMap map)
		{
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId)
		{
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange)
		{
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange, bool invert)
		{
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, Pole axisContribution, KeyboardKeyCode keyboardKeyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
		{
		}

		public bool CheckForAssignmentConflict(ElementAssignment elementAssignment)
		{
			return default(bool);
		}

		public bool CheckForAssignmentConflict(ActionElementMap elementMap)
		{
			return default(bool);
		}

		public bool ShowInField(AxisRange fieldActionRange)
		{
			return default(bool);
		}

		public bool IsTarget(ControllerElementTarget elementTarget)
		{
			return default(bool);
		}

		public bool IsTarget(IControllerElementTarget elementTarget)
		{
			return default(bool);
		}

		internal void AanbyFPIGYaXTAFkKafEiGtuHuY(ControllerMap P_0)
		{
		}

		internal void elzVAiQyWkzuCtGheqcKGERyJJZ(ControllerMap P_0, HardwareControllerMap_Game P_1)
		{
		}

		private void AanbyFPIGYaXTAFkKafEiGtuHuY(bool P_0)
		{
		}

		private void AanbyFPIGYaXTAFkKafEiGtuHuY(ControllerType P_0, HardwareControllerMap_Game P_1, bool P_2)
		{
		}

		private void rHmegILsxjODifpRAbGWlRanCcv()
		{
		}

		internal void vMfAexzdpfzhXKkyGdAHmJVnQEr()
		{
		}

		private bool UphtGWDUkoGvmsHdAlawJPgoxoo(KeyboardKeyCode P_0, ModifierKeyFlags P_1)
		{
			return default(bool);
		}

		private bool ytINqBOGeYmPBMCXpvVsQMIGfsb(int P_0, AxisRange P_1)
		{
			return default(bool);
		}

		private bool qkdMUWVbdqgUrHevksmWKyDtmum(ElementAssignmentType P_0)
		{
			return default(bool);
		}

		private void jbjvQNVJEVXuZkNSBpQEpvieKDj()
		{
		}

		private void GGaCJWAfENtANvBAQKAkFmIfEuq()
		{
		}

		private void twqwlDxSSSSAFvKnCKBfIDjRHdT()
		{
		}

		internal SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH()
		{
			return null;
		}

		internal void BxoFMvWmvalDyQMZPpCVmdbosOa(SerializedObject P_0)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
