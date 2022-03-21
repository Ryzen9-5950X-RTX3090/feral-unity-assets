using System;
using System.Runtime.InteropServices;

public class vx_evt_audio_device_hot_swap_t : IDisposable
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

	public vx_audio_device_hot_swap_event_type_t event_type
	{
		get
		{
			return default(vx_audio_device_hot_swap_event_type_t);
		}
		set
		{
		}
	}

	public vx_device_t relevant_device
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string account_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_audio_device_hot_swap_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_audio_device_hot_swap_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_audio_device_hot_swap_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_audio_device_hot_swap_t()
	{
	}
}
