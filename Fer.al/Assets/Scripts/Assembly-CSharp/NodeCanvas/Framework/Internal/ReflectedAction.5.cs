using System;
using ParadoxNotion;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class ReflectedAction<T1, T2, T3, T4, T5> : ReflectedActionWrapper
	{
		private ActionCall<T1, T2, T3, T4, T5> call;

		public BBParameter<T1> p1;

		public BBParameter<T2> p2;

		public BBParameter<T3> p3;

		public BBParameter<T4> p4;

		public BBParameter<T5> p5;

		public override BBParameter[] GetVariables()
		{
			return null;
		}

		public override void Init(object instance)
		{
		}

		public override void Call()
		{
		}
	}
}
