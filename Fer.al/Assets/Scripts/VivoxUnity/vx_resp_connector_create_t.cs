using System;
using System.Runtime.InteropServices;

public class vx_resp_connector_create_t : IDisposable
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

	public string connector_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string version_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int backend_type
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_connector_create_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_connector_create_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_connector_create_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_connector_create_t()
	{
	}
}
