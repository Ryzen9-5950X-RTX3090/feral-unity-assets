using System;
using System.Runtime.InteropServices;

public class vx_tts_voice_list_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_tts_voice_t Voices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int Length
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_tts_voice_list_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_tts_voice_list_t obj)
	{
		return default(HandleRef);
	}

	~vx_tts_voice_list_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_tts_voice_t[](vx_tts_voice_list_t list)
	{
		return null;
	}

	public vx_tts_voice_t Get(int i)
	{
		return null;
	}

	public vx_tts_voice_list_t()
	{
	}
}
