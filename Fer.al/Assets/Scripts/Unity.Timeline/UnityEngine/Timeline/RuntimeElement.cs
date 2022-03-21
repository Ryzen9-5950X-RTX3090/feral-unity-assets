using System.Runtime.CompilerServices;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	internal abstract class RuntimeElement : IInterval
	{
		public abstract long intervalStart { get; }

		public abstract long intervalEnd { get; }

		public int intervalBit
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public abstract bool enable { set; }

		public abstract void EvaluateAt(double localTime, FrameData frameData);

		public virtual void Reset()
		{
		}
	}
}
