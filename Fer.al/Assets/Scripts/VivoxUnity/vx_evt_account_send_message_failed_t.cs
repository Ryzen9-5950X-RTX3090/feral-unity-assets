using System;
using System.Runtime.InteropServices;

public class vx_evt_account_send_message_failed_t : IDisposable
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

	public string request_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int status_code
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_account_send_message_failed_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_account_send_message_failed_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_account_send_message_failed_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_account_send_message_failed_t()
	{
	}
}
