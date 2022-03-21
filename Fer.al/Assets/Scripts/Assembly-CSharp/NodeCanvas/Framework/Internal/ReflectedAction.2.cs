using System;
using ParadoxNotion;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class ReflectedAction<T1, T2> : ReflectedActionWrapper
	{
		private ActionCall<T1, T2> call;

		public BBParameter<T1> p1;

		public BBParameter<T2> p2;

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
