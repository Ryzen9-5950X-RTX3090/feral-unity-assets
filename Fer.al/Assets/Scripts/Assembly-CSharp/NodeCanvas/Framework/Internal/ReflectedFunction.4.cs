using System;
using ParadoxNotion;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class ReflectedFunction<TResult, T1, T2, T3> : ReflectedFunctionWrapper
	{
		private FunctionCall<T1, T2, T3, TResult> call;

		public BBParameter<T1> p1;

		public BBParameter<T2> p2;

		public BBParameter<T3> p3;

		[BlackboardOnly]
		public BBParameter<TResult> result;

		public override BBParameter[] GetVariables()
		{
			return null;
		}

		public override void Init(object instance)
		{
		}

		public override object Call()
		{
			return null;
		}
	}
}
