using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	internal class InfiniteRuntimeClip : RuntimeElement
	{
		private Playable m_Playable;

		private static readonly long kIntervalEnd;

		public override long intervalStart
		{
			get
			{
				return default(long);
			}
		}

		public override long intervalEnd
		{
			get
			{
				return default(long);
			}
		}

		public override bool enable
		{
			set
			{
			}
		}

		public InfiniteRuntimeClip(Playable playable)
		{
		}

		public override void EvaluateAt(double localTime, FrameData frameData)
		{
		}
	}
}
