using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	public abstract class ControllerMapWithAxes : ControllerMap
	{
		private readonly IList<ActionElementMap> uBcXysnncpecrluUJnlkFJCtcyGA;

		private readonly ReadOnlyCollection<ActionElementMap> FndgSjFQVoSrYFdqrqCVLgaVGhn;

		public int axisMapCount
		{
			get
			{
				return default(int);
			}
		}

		public IList<ActionElementMap> AxisMaps
		{
			get
			{
				return null;
			}
		}

		internal AList<ActionElementMap> AxisMaps_orig
		{
			get
			{
				return null;
			}
		}

		public ControllerMapWithAxes()
		{
		}

		public ControllerMapWithAxes(ControllerMapWithAxes controllerMap)
		{
		}

		public override bool ContainsAction(int actionId)
		{
			return default(bool);
		}

		public override bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			return default(bool);
		}

		public override bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			return default(bool);
		}

		public override bool DeleteElementMap(int elementMapId)
		{
			return default(bool);
		}

		public override bool DeleteElementMapsWithAction(string actionName)
		{
			return default(bool);
		}

		public override bool DeleteElementMapsWithAction(int actionId)
		{
			return default(bool);
		}

		public override ActionElementMap GetElementMap(int elementMapId)
		{
			return null;
		}

		public override ActionElementMap GetFirstElementMapWithAction(int actionId)
		{
			return null;
		}

		public override ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		internal override ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> P_0, bool P_1)
		{
			return null;
		}

		internal override int GetElementMapMatches(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		public override void ClearElementMaps()
		{
		}

		public ActionElementMap GetAxisMap(int index)
		{
			return null;
		}

		public ActionElementMap[] GetAxisMaps()
		{
			return null;
		}

		public ActionElementMap[] GetAxisMaps(bool skipDisabledMaps)
		{
			return null;
		}

		public int GetAxisMaps(bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public ActionElementMap[] GetAxisMapsWithAction(string actionName)
		{
			return null;
		}

		public ActionElementMap[] GetAxisMapsWithAction(int actionId)
		{
			return null;
		}

		public ActionElementMap[] GetAxisMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap[] GetAxisMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public int GetAxisMapsWithAction(string actionName, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetAxisMapsWithAction(int actionId, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return default(int);
		}

		public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstAxisMapWithAction(int actionId)
		{
			return null;
		}

		public ActionElementMap GetFirstAxisMapWithAction(string actionName)
		{
			return null;
		}

		public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps)
		{
			return null;
		}

		public ActionElementMap GetFirstAxisMapMatch(Predicate<ActionElementMap> predicate)
		{
			return null;
		}

		internal ActionElementMap PWlCiVcNhlfPUxFomkmHebmdQOOc(Predicate<ActionElementMap> P_0, bool P_1)
		{
			return null;
		}

		public int GetAxisMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results)
		{
			return default(int);
		}

		internal int FvbUTjFQiCTBbzqnwhizLawYBxx(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		public void ForEachAxisMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform)
		{
		}

		public bool DeleteAxisMapsWithAction(string actionName)
		{
			return default(bool);
		}

		public bool DeleteAxisMapsWithAction(int actionId)
		{
			return default(bool);
		}

		public int SetAllAxisMapsEnabled(bool state)
		{
			return default(int);
		}

		public override bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			return default(bool);
		}

		public override bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			return default(bool);
		}

		public override bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			return default(bool);
		}

		public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			return null;
		}

		public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			return null;
		}

		public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			return null;
		}

		public override int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			return default(int);
		}

		public override int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			return default(int);
		}

		public override int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			return default(int);
		}

		internal override int DisableElementAssignmentConflicts(ControllerMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal override int DisableElementAssignmentConflicts(ActionElementMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal override int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		public string[] GetAxisNames()
		{
			return null;
		}

		internal override bool AddActionMapping_BeforeBake(ActionElementMap P_0)
		{
			return default(bool);
		}

		internal override int GetElementMaps_Append(List<ActionElementMap> P_0, bool P_1)
		{
			return default(int);
		}

		internal override ActionElementMap GetFirstElementMapWithMapping(int P_0, int P_1, ControllerElementType P_2)
		{
			return null;
		}

		internal override int GetElementMapsWithElementIdentifier(int P_0, List<ActionElementMap> P_1, bool P_2)
		{
			return default(int);
		}

		internal override bool ContainsElementMapping(int P_0, int P_1, ControllerElementType P_2)
		{
			return default(bool);
		}

		internal override int FirstIndexOfElementMapping(int P_0, int P_1, ControllerElementType P_2)
		{
			return default(int);
		}

		internal int mJhEuGZqjhAxEDpGbvHkQFTuwIEi(int P_0)
		{
			return default(int);
		}

		internal int fFpqxaKDDIyYQbALOiNvbxfFUsx(bool P_0, List<ActionElementMap> P_1, bool P_2)
		{
			return default(int);
		}

		internal int aJrBTCaTOYGxSpVpmfRGkxuxFcsp(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal override int GetElementMapsWithAction(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return default(int);
		}

		internal override ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, out bool P_4)
		{
			return null;
		}

		internal override int GetElementMapsWithElementTarget(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5, out bool P_6)
		{
			return default(int);
		}

		internal override bool AddElementMap(ActionElementMap P_0)
		{
			return default(bool);
		}

		private bool JRmEBsonHRIHpxNzlhMFatswGgC(ControllerElementType P_0)
		{
			return default(bool);
		}

		private void EeVHGofsRRRZRKeHQaqiJgWJpyKG(int P_0, int P_1)
		{
		}

		private void iOkNqRWOvNjvtOHwpiAWpacQZWi(ActionElementMap P_0)
		{
		}

		private void fIoUSQGhNfewjyjHuEULBYjuotO(ActionElementMap P_0, int P_1)
		{
		}

		internal override void ExportDataToSerializedObject(SerializedObject P_0)
		{
		}

		internal override bool Import(SerializedObject P_0)
		{
			return default(bool);
		}

		[CompilerGenerated]
		private IEnumerable<ElementAssignmentConflictInfo> mUZbNIaWJplRJrsbIEGGxbMeJSw(ControllerMap P_0, bool P_1)
		{
			return null;
		}

		[CompilerGenerated]
		private IEnumerable<ElementAssignmentConflictInfo> JuZLQmDczkUIVfIDJcmIbReEMfSY(ActionElementMap P_0, bool P_1)
		{
			return null;
		}

		[CompilerGenerated]
		private IEnumerable<ElementAssignmentConflictInfo> HsuoMnKqpXmKdvEHandYVXJuxpu(ElementAssignmentConflictCheck P_0, bool P_1)
		{
			return null;
		}
	}
}
