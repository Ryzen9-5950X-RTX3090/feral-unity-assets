using System.Collections.Generic;

namespace UnityEngine.UI
{
	public static class SelectableExtensions
	{
		private static Vector3 GetPointOnRectEdge(RectTransform inRect, Vector2 inDir)
		{
			return default(Vector3);
		}

		public static Selectable FindSelectableFromCandidates(this Selectable inSelectable, List<Selectable> inCandidates, Vector3 inDir, bool inIgnoreWrongDirection = false)
		{
			return null;
		}

		public static Selectable FindSelectableOnLeftFromCandidates(this Selectable inSelectable, List<Selectable> inCandidates)
		{
			return null;
		}

		public static Selectable FindSelectableOnRightFromCandidates(this Selectable inSelectable, List<Selectable> inCandidates)
		{
			return null;
		}

		public static Selectable FindSelectableOnUpFromCandidates(this Selectable inSelectable, List<Selectable> inCandidates)
		{
			return null;
		}

		public static Selectable FindSelectableOnDownFromCandidates(this Selectable inSelectable, List<Selectable> inCandidates)
		{
			return null;
		}

		public static void AssignNavigation(this Selectable inSelectable, Selectable inSelectOnUp, Selectable inSelectOnDown, Selectable inSelectOnLeft, Selectable inSelectOnRight)
		{
		}
	}
}
