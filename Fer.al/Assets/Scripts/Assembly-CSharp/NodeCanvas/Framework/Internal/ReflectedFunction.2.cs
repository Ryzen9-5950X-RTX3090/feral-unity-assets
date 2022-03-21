using System;
using ParadoxNotion;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class ReflectedFunction<TResult, T1> : ReflectedFunctionWrapper
	{
		private FunctionCall<T1, TResult> call;

		public BBParameter<T1> p1;

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
