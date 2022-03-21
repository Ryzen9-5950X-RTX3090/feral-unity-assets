using System;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	[SpoofAOT]
	public class ReflectedFunction<TResult> : ReflectedFunctionWrapper
	{
		private FunctionCall<TResult> call;

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
