using System;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework
{
	[SpoofAOT]
	public abstract class ExposedParameter
	{
		public abstract string targetVariableID { get; }

		public abstract Type type { get; }

		public abstract object valueBoxed { get; set; }

		public abstract Variable varRefBoxed { get; }

		public abstract void Bind(IBlackboard blackboard);

		public abstract void UnBind(IBlackboard blackboard);

		public static ExposedParameter CreateInstance(Variable target)
		{
			return null;
		}
	}
}
