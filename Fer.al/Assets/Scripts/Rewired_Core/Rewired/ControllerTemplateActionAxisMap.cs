using System.Collections.Generic;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	public sealed class ControllerTemplateActionAxisMap : ControllerTemplateActionElementMap
	{
		private AxisRange ExRGMQhhcszaUDJSZXmAQgaCQwR;

		private Pole VzTdNXQLdMKvOCewKuOOTAJpYPj;

		private bool xiGVcbeDngTNOAGsRyRJuOyHGQY;

		public AxisRange axisRange
		{
			get
			{
				return default(AxisRange);
			}
		}

		public Pole axisContribution
		{
			get
			{
				return default(Pole);
			}
		}

		public bool invert
		{
			get
			{
				return default(bool);
			}
		}

		internal ControllerTemplateActionAxisMap(SerializedObject serializedObject)
		{
		}

		internal ControllerTemplateActionAxisMap(int templateElementIdentifierId, AxisRange axisRange, ActionElementMap actionElementMap)
		{
		}

		internal ControllerTemplateActionAxisMap(int elementIdentifierId, int actionId, AxisRange axisRange, Pole axisContribution, bool invert, bool enabled)
		{
		}

		internal override void Export(SerializedObject P_0)
		{
		}

		internal override void Import(SerializedObject P_0)
		{
		}

		internal override void Clear()
		{
		}

		internal override int CreateAEMsFromSource(IControllerTemplateElementSource P_0, List<ActionElementMap> P_1, bool P_2)
		{
			return default(int);
		}

		private ActionElementMap waObOGILnxLHUQNmxEavMzNaVosg(IControllerElementTarget P_0, AxisRange P_1)
		{
			return null;
		}

		private ActionElementMap DLeWjLbhpciRFqAbNSLWiihFBMz(IControllerElementTarget P_0, Pole P_1, Pole P_2)
		{
			return null;
		}
	}
}
