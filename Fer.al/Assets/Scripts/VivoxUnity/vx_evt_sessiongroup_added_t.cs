using System;
using System.Runtime.InteropServices;

public class vx_evt_sessiongroup_added_t : IDisposable
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

	public string sessiongroup_handle
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

	public vx_sessiongroup_type type
	{
		get
		{
			return default(vx_sessiongroup_type);
		}
		set
		{
		}
	}

	public string alias_username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_sessiongroup_added_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_sessiongroup_added_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_sessiongroup_added_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_sessiongroup_added_t()
	{
	}
}
