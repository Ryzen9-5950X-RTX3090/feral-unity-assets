using System;

namespace NodeCanvas.Framework
{
	public abstract class NetworkConditionTask<T> : NetworkConditionTask where T : class
	{
		public sealed override Type agentType
		{
			get
			{
				return null;
			}
		}

		public new T agent
		{
			get
			{
				return null;
			}
		}
	}
}
