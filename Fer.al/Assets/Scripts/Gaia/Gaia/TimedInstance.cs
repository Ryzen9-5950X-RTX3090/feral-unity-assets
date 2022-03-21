using System.Diagnostics;

namespace Gaia
{
	public class TimedInstance : Stopwatch
	{
		public long nanosecPerTick;

		public string m_name;

		public int m_iterations;

		public TimedInstance(string name, bool start = true)
		{
		}

		public new void Start()
		{
		}

		public new void Reset()
		{
		}

		public void IncIterations()
		{
		}

		public float GetAvgMs()
		{
			return default(float);
		}

		public float GetAvgS()
		{
			return default(float);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
