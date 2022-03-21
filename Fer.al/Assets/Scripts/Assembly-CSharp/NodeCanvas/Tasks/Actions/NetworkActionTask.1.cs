using System;

namespace NodeCanvas.Tasks.Actions
{
	public abstract class NetworkActionTask<T> : NetworkActionTask where T : class
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
