using System;

namespace FMOD.Studio
{
	public struct Bank
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

		public RESULT unload()
		{
			return default(RESULT);
		}

		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		public Bank(IntPtr ptr)
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
