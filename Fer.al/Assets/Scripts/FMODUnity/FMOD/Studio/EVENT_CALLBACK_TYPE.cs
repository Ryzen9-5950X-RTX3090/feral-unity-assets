using System;

namespace FMOD.Studio
{
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		CREATED = 1u,
		DESTROYED = 2u,
		STARTING = 4u,
		STARTED = 8u,
		RESTARTED = 0x10u,
		STOPPED = 0x20u,
		START_FAILED = 0x40u,
		CREATE_PROGRAMMER_SOUND = 0x80u,
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		PLUGIN_CREATED = 0x200u,
		PLUGIN_DESTROYED = 0x400u,
		TIMELINE_MARKER = 0x800u,
		TIMELINE_BEAT = 0x1000u,
		SOUND_PLAYED = 0x2000u,
		SOUND_STOPPED = 0x4000u,
		REAL_TO_VIRTUAL = 0x8000u,
		VIRTUAL_TO_REAL = 0x10000u,
		START_EVENT_COMMAND = 0x20000u,
		ALL = uint.MaxValue
	}
}