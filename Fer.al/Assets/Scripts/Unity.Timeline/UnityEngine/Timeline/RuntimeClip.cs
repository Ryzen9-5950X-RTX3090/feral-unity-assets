using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	internal class RuntimeClip : RuntimeClipBase
	{
		private TimelineClip m_Clip;

		private Playable m_Playable;

		private Playable m_ParentMixer;

		public override double start
		{
			get
			{
				return default(double);
			}
		}

		public override double duration
		{
			get
			{
				return default(double);
			}
		}

		public TimelineClip clip
		{
			get
			{
				return null;
			}
		}

		public Playable mixer
		{
			get
			{
				return default(Playable);
			}
		}

		public Playable playable
		{
			get
			{
				return default(Playable);
			}
		}

		public override bool enable
		{
			set
			{
			}
		}

		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
		}

		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
		}

		public void SetTime(double time)
		{
		}

		public void SetDuration(double duration)
		{
		}

		public override void EvaluateAt(double localTime, FrameData frameData)
		{
		}

		public override void Reset()
		{
		}
	}
}
