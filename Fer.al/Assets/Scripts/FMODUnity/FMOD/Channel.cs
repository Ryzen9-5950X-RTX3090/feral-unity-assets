using System;

namespace FMOD
{
	public struct Channel : IChannelControl
	{
		public IntPtr handle;

		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		public RESULT stop()
		{
			return default(RESULT);
		}

		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		public Channel(IntPtr ptr)
		{
		}

		public bool hasHandle()
		{
			return default(bool);
		}

		public void clearHandle()
		{
		}
	}
}
