using System;
using System.Runtime.InteropServices;

public class vx_tts_voice_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public uint voice_id
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_tts_voice_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_tts_voice_t obj)
	{
		return default(HandleRef);
	}

	~vx_tts_voice_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_tts_voice_t()
	{
	}
}
