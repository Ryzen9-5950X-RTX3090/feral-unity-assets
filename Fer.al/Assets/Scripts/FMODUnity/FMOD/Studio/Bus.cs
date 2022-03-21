using System;

namespace FMOD.Studio
{
	public struct Bus
	{
		public IntPtr handle;

		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		public RESULT getMemoryUsage(out MEMORY_USAGE memoryusage)
		{
			return default(RESULT);
		}

		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		private static extern RESULT FMOD_Studio_Bus_GetCPUUsage(IntPtr bus, out uint exclusive, out uint inclusive);

		private static extern RESULT FMOD_Studio_Bus_GetMemoryUsage(IntPtr bus, out MEMORY_USAGE memoryusage);

		public Bus(IntPtr ptr)
		{
		}

		public bool hasHandle()
		{
			return default(bool);
		}

		public void clearHandle()
		{
		}

		public bool isValid()
		{
			return default(bool);
		}
	}
}
