using System;

namespace FMOD.Studio
{
	public struct VCA
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

		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		public VCA(IntPtr ptr)
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
