namespace UnityEngine.Timeline
{
	internal abstract class RuntimeClipBase : RuntimeElement
	{
		public abstract double start { get; }

		public abstract double duration { get; }

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
	}
}
