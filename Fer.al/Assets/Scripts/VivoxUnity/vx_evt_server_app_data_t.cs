using System;
using System.Runtime.InteropServices;

public class vx_evt_server_app_data_t : IDisposable
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

	public string content_type
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string content
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_server_app_data_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_server_app_data_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_server_app_data_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_server_app_data_t()
	{
	}
}
