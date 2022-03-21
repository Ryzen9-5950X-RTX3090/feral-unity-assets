using System;
using System.Runtime.InteropServices;

public class vx_resp_connector_initiate_shutdown_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_resp_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string client_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_resp_connector_initiate_shutdown_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_connector_initiate_shutdown_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_connector_initiate_shutdown_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_connector_initiate_shutdown_t()
	{
	}
}
