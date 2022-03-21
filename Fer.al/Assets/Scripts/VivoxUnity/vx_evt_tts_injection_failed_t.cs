using System;
using System.Runtime.InteropServices;

public class vx_evt_tts_injection_failed_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_evt_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_tts_status status
	{
		get
		{
			return default(vx_tts_status);
		}
		set
		{
		}
	}

	public uint utterance_id
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public vx_tts_destination tts_destination
	{
		get
		{
			return default(vx_tts_destination);
		}
		set
		{
		}
	}

	internal vx_evt_tts_injection_failed_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_tts_injection_failed_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_tts_injection_failed_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_tts_injection_failed_t()
	{
	}
}
