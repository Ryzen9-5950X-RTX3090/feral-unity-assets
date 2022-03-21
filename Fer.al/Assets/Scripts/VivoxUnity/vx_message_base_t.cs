using System;
using System.Runtime.InteropServices;

public class vx_message_base_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_message_type type
	{
		get
		{
			return default(vx_message_type);
		}
		set
		{
		}
	}

	public uint sdk_handle
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public ulong create_time_ms
	{
		get
		{
			return default(ulong);
		}
		set
		{
		}
	}

	public ulong last_step_ms
	{
		get
		{
			return default(ulong);
		}
		set
		{
		}
	}

	internal vx_message_base_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_message_base_t obj)
	{
		return default(HandleRef);
	}

	~vx_message_base_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_resp_base_t(vx_message_base_t t)
	{
		return null;
	}

	public static implicit operator vx_evt_base_t(vx_message_base_t t)
	{
		return null;
	}

	public vx_resp_base_t as_resp_base()
	{
		return null;
	}

	public vx_evt_base_t as_evt_base()
	{
		return null;
	}

	public vx_message_base_t()
	{
	}
}
