using System;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	[SpoofAOT]
	public class ReflectedAction<T1> : ReflectedActionWrapper
	{
		private ActionCall<T1> call;

		public BBParameter<T1> p1;

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
