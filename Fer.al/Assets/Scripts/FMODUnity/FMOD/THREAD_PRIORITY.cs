namespace FMOD
{
	public enum THREAD_PRIORITY
	{
		PLATFORM_MIN = -32768,
		PLATFORM_MAX = 32768,
		DEFAULT = -32769,
		LOW = -32770,
		MEDIUM = -32771,
		HIGH = -32772,
		VERY_HIGH = -32773,
		EXTREME = -32774,
		CRITICAL = -32775,
		MIXER = -32774,
		FEEDER = -32775,
		STREAM = -32773,
		FILE = -32772,
		NONBLOCKING = -32772,
		RECORD = -32772,
		GEOMETRY = -32770,
		PROFILER = -32771,
		STUDIO_UPDATE = -32771,
		STUDIO_LOAD_BANK = -32771,
		STUDIO_LOAD_SAMPLE = -32771,
		CONVOLUTION1 = -32773,
		CONVOLUTION2 = -32773
	}
}
