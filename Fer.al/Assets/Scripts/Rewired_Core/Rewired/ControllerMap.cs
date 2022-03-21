using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public abstract class ControllerMap
	{
		private class FxHeXoCttgoRDEovXylvLhGTHdg : IComparer<ActionElementMap>
		{
			public static FxHeXoCttgoRDEovXylvLhGTHdg DqYmGHECTlrDVQmfbrCSLOJGmsK;

			public static FxHeXoCttgoRDEovXylvLhGTHdg ABeAWOemtDNDbkuEcBndYTrwdsCb
			{
				get
				{
					return null;
				}
			}

			public int Compare(ActionElementMap x, ActionElementMap y)
			{
				return default(int);
			}
		}

		protected int _id;

		protected int _sourceMapId;

		protected int _categoryId;

		protected int _layoutId;

		protected string _name;

		protected Guid _hardwareGuid;

		protected bool _enabled;

		internal readonly int vSShldFHkaZKEuThltrSgFmPfc;

		private readonly AList<ActionElementMap> yWpPsagHSVgRPacxUoojGfqEKmda;

		private readonly ReadOnlyCollection<ActionElementMap> eFAVjhpIRHLgwmoNSEOSOpirTwI;

		private readonly AList<ActionElementMap> BohAGnsjjxuOYHfhKphUKbZxLNl;

		private readonly ReadOnlyCollection<ActionElementMap> JNrknNTAIwCCdJZGdAXTwuDNEET;

		protected int _playerId;

		protected int _controllerId;

		protected ControllerType _controllerType;

		private static int opOBHHseJkiuPTdqFxSPSFfBWwf;

		private static int nextUid
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

		public int sourceMapId
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public int categoryId
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public int layoutId
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

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

		public Guid hardwareGuid
		{
			get
			{
				return default(Guid);
			}
			internal set
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

		public int playerId
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public int controllerId
		{
			get
			{
				return default(int);
			}
			internal set
			{
			}
		}

		public Controller controller
		{
			get
			{
				return null;
			}
		}

		public ControllerType controllerType
		{
			get
			{
				return default(ControllerType);
			}
			internal set
			{
			}
		}

		public Player player
		{
			get
			{
				return null;
			}
		}

		public int elementMapCount
		{
			get
			{
				return default(int);
			}
		}

		public int buttonMapCount
		{
			get
			{
				return default(int);
			}
		}

		public IList<ActionElementMap> AllMaps
		{
			get
			{
				return null;
			}
		}

		public IList<ActionElementMap> ButtonMaps
		{
			get
			{
				return null;
			}
		}

		internal AList<ActionElementMap> ButtonMaps_orig
		{
			get
			{
				return null;
			}
		}

		public ControllerMap()
		{
		}

		public ControllerMap(ControllerMap source)
		{
		}

		public bool ContainsAction(string actionName)
		{
			return default(bool);
		}

		public virtual bool ContainsAction(int actionId)
		{
			return default(bool);
		}

		public bool ContainsElementIdentifier(int elementIdentifierId)
		{
			return default(bool);
		}

		public bool ContainsKeyboardKey(KeyCode keyCode, ModifierKeyFlags modifierKeys)
		{
			return default(bool);
		}

		public bool ContainsElementMap(ActionElementMap elementMap)
		{
			return default(bool);
		}

		public bool ContainsElementMap(int elementMapId)
		{
			return default(bool);
		}

		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment)
		{
			return default(bool);
		}

		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool CreateElementMap(ElementAssignment elementAssignment)
		{
			return default(bool);
		}

		public bool CreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
		{
			return default(bool);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			return default(bool);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert)
		{
			return default(bool);
		}

		public virtual bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool ReplaceElementMap(ElementAssignment elementAssignment)
		{
			return default(bool);
		}

		public bool ReplaceElementMap(ElementAssignment elementAssignment, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
		{
			return default(bool);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			return default(bool);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result)
		{
			return default(bool);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert)
		{
			return default(bool);
		}

		public virtual bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			return default(bool);
		}

		public virtual bool DeleteElementMap(int elementMapId)
		{
			return default(bool);
		}

		public virtual bool DeleteElementMapsWithAction(string actionName)
		{
			return default(bool);
		}

		public virtual bool DeleteElementMapsWithAction(int actionId)
		{
			return default(bool);
		}

		public virtual ActionElementMap GetElementMap(int elementMapId)
		{
			return null;
		}

		public ActionElementMap[] GetElementMaps()
		{
			return null;
		}

		public ActionElementMap[] GetElementMaps(bool skipDisabledMaps)
		{
			return null;
		}

		public int GetElementMaps(List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMaps(bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public ActionElementMap[] GetElementMapsWithAction(string actionName)
		{
			return null;
		}

		public ActionElementMap[] GetElementMapsWithAction(int actionId)
		{
			return null;
		}

		public ActionElementMap[] GetElementMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap[] GetElementMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public int GetElementMapsWithAction(string actionName, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithAction(int actionId, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId)
		{
			return null;
		}

		public virtual ActionElementMap GetFirstElementMapWithAction(string actionName)
		{
			return null;
		}

		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> predicate)
		{
			return null;
		}

		internal virtual ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> P_0, bool P_1)
		{
			return null;
		}

		public int GetElementMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results)
		{
			return default(int);
		}

		internal virtual int GetElementMapMatches(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		public void ForEachElementMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform)
		{
		}

		public virtual void ClearElementMaps()
		{
		}

		public int SetAllElementMapsEnabled(bool state)
		{
			return default(int);
		}

		public ActionElementMap GetButtonMap(int index)
		{
			return null;
		}

		public ActionElementMap[] GetButtonMaps()
		{
			return null;
		}

		public ActionElementMap[] GetButtonMaps(bool skipDisabledMaps)
		{
			return null;
		}

		public int GetButtonMaps(bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public ActionElementMap[] GetButtonMapsWithAction(string actionName)
		{
			return null;
		}

		public ActionElementMap[] GetButtonMapsWithAction(int actionId)
		{
			return null;
		}

		public ActionElementMap[] GetButtonMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap[] GetButtonMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public int GetButtonMapsWithAction(string actionName, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetButtonMapsWithAction(int actionId, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstButtonMapWithAction(int actionId)
		{
			return null;
		}

		public ActionElementMap GetFirstButtonMapWithAction(string actionName)
		{
			return null;
		}

		public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstButtonMapMatch(Predicate<ActionElementMap> predicate)
		{
			return null;
		}

		internal ActionElementMap sfrfjQHYwnzYMvBdMYFGgIuOxY(Predicate<ActionElementMap> P_0, bool P_1)
		{
			return null;
		}

		public int GetButtonMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results)
		{
			return default(int);
		}

		internal int EeNfZfiTCyIueEnVHfvFhlFcvuQA(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		public void ForEachButtonMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform)
		{
		}

		public bool DeleteButtonMapsWithAction(string actionName)
		{
			return default(bool);
		}

		public bool DeleteButtonMapsWithAction(int actionId)
		{
			return default(bool);
		}

		public int SetAllButtonMapsEnabled(bool state)
		{
			return default(int);
		}

		public bool DoesElementAssignmentConflict(ControllerMap controllerMap)
		{
			return default(bool);
		}

		public bool DoesElementAssignmentConflict(ActionElementMap actionElementMap)
		{
			return default(bool);
		}

		public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck)
		{
			return default(bool);
		}

		public virtual bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			return default(bool);
		}

		public virtual bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			return default(bool);
		}

		public virtual bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			return default(bool);
		}

		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap)
		{
			return null;
		}

		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap)
		{
			return null;
		}

		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
		{
			return null;
		}

		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			return null;
		}

		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			return null;
		}

		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			return null;
		}

		public int RemoveElementAssignmentConflicts(ControllerMap controllerMap)
		{
			return default(int);
		}

		public int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap)
		{
			return default(int);
		}

		public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
		{
			return default(int);
		}

		public virtual int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			return default(int);
		}

		public virtual int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			return default(int);
		}

		public virtual int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			return default(int);
		}

		public int DisableElementAssignmentConflicts(ControllerMap controllerMap)
		{
			return default(int);
		}

		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap)
		{
			return default(int);
		}

		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
		{
			return default(int);
		}

		public int DisableElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			return default(int);
		}

		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			return default(int);
		}

		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			return default(int);
		}

		internal virtual int DisableElementAssignmentConflicts(ControllerMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal virtual int DisableElementAssignmentConflicts(ActionElementMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal virtual int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform)
		{
			return default(int);
		}

		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform)
		{
			return default(int);
		}

		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform)
		{
			return default(int);
		}

		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps)
		{
			return default(int);
		}

		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps)
		{
			return default(int);
		}

		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps)
		{
			return default(int);
		}

		public string[] GetButtonNames()
		{
			return null;
		}

		public string ToXmlString()
		{
			return null;
		}

		public string ToJsonString()
		{
			return null;
		}

		public ControllerTemplateMap ToControllerTemplateMap(Guid templateTypeGuid)
		{
			return null;
		}

		public ControllerTemplateMap ToControllerTemplateMap<T>() where T : class
		{
			return null;
		}

		public ControllerTemplateMap ToControllerTemplateMap(Type templateInterfaceType)
		{
			return null;
		}

		private ControllerTemplateMap WVBGGcAShyAhuaoJOBlxFvkqAyeX(IControllerTemplate P_0)
		{
			return null;
		}

		internal virtual bool AddActionMapping_BeforeBake(ActionElementMap P_0)
		{
			return default(bool);
		}

		internal virtual int GetElementMaps_Append(List<ActionElementMap> P_0, bool P_1)
		{
			return default(int);
		}

		internal virtual ActionElementMap GetFirstElementMapWithMapping(int P_0, int P_1, ControllerElementType P_2)
		{
			return null;
		}

		internal virtual int GetElementMapsWithElementIdentifier(int P_0, List<ActionElementMap> P_1, bool P_2)
		{
			return default(int);
		}

		internal virtual bool ContainsElementMapping(int P_0, int P_1, ControllerElementType P_2)
		{
			return default(bool);
		}

		internal virtual int FirstIndexOfElementMapping(int P_0, int P_1, ControllerElementType P_2)
		{
			return default(int);
		}

		internal int WyfLcbhJdRIDggNTPQolKfmiqVXO(int P_0)
		{
			return default(int);
		}

		internal int yMnCZVQpkDyZSdKlBPSwBpBVlbp(bool P_0, List<ActionElementMap> P_1, bool P_2)
		{
			return default(int);
		}

		internal int iRpRMXtGPzaRzbxQcKhFNYOkpU(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal virtual int GetElementMapsWithAction(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal virtual ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, out bool P_4)
		{
			return null;
		}

		internal virtual int GetElementMapsWithElementTarget(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5, out bool P_6)
		{
			return default(int);
		}

		internal void wIiHdvPUJfaFsAkUPGzOpxxycfw(int P_0, ControllerElementType P_1)
		{
		}

		internal virtual bool AddElementMap(ActionElementMap P_0)
		{
			return default(bool);
		}

		internal bool RfhTtmeWkZcZFiLsfhGeVjiiHuoh(IControllerElementTarget P_0)
		{
			return default(bool);
		}

		internal bool eWiDVrOvsiJEhXKqKMxndRKHSFa(string P_0)
		{
			return default(bool);
		}

		internal bool gpseceKgdzPYGBlDHZYIuHnhQOU(string P_0)
		{
			return default(bool);
		}

		internal void BvQwmWjmkuaSrcNJOKWBWseKTqu(ActionElementMap P_0)
		{
		}

		internal void ZpLhQoroHCPJpgiSGIbBdtOZzpr(int P_0)
		{
		}

		internal void KiwuQAMxILWbeWMikexDAnMBYLCk(int P_0, ActionElementMap P_1)
		{
		}

		internal static void lbnVQxzGkEMKtnLmmXZpetnKhrY(ActionElementMap P_0, int P_1, Pole P_2, int P_3, ControllerElementType P_4, AxisRange P_5, bool P_6)
		{
		}

		protected void BakeElementMap(ActionElementMap map)
		{
		}

		internal virtual bool Import(SerializedObject P_0)
		{
			return default(bool);
		}

		internal virtual void ExportDataToSerializedObject(SerializedObject P_0)
		{
		}

		private bool JRmEBsonHRIHpxNzlhMFatswGgC(ControllerElementType P_0)
		{
			return default(bool);
		}

		private void QuqQnEgfPsIDZdqpymfnbctnFQy(int P_0, int P_1)
		{
		}

		private void zEuxlwThoAgQOAEzAYufSpxEQW(ActionElementMap P_0)
		{
		}

		private void rUugoLYJiHPgXpRoLNGOFQJlcUw(ActionElementMap P_0, int P_1)
		{
		}

		private int LzysDciQEwighcIlMAYdCPAjvoMh(int P_0)
		{
			return default(int);
		}

		private SerializedObject uJZpqEBLkJUYeZxXRkMWiNxeekH()
		{
			return null;
		}

		internal static ControllerMap AQMpZVIIXTyemnHtIDPtxhINdLN(ControllerType P_0)
		{
			return null;
		}

		internal static ControllerMap knpCzsAliOJCvESsOKEznoItAuz(Controller P_0, int P_1, int P_2)
		{
			return null;
		}

		public static ControllerMap CreateFromXml(ControllerType controllerType, string xmlString)
		{
			return null;
		}
	}
}
