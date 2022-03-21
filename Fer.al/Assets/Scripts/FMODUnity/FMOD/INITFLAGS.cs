using System;

namespace FMOD
{
	[Flags]
	public enum INITFLAGS : uint
	{
		NORMAL = 0u,
		STREAM_FROM_UPDATE = 1u,
		MIX_FROM_UPDATE = 2u,
		_3D_RIGHTHANDED = 4u,
		CHANNEL_LOWPASS = 0x100u,
		CHANNEL_DISTANCEFILTER = 0x200u,
		PROFILE_ENABLE = 0x10000u,
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		GEOMETRY_USECLOSEST = 0x40000u,
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		THREAD_UNSAFE = 0x100000u,
		PROFILE_METER_ALL = 0x200000u,
		MEMORY_TRACKING = 0x400000u
	}
}
