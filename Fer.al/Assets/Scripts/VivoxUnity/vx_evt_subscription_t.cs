using System;
using System.Runtime.InteropServices;

public class vx_evt_subscription_t : IDisposable
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

	public string buddy_uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string subscription_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_subscription_type subscription_type
	{
		get
		{
			return default(vx_subscription_type);
		}
		set
		{
		}
	}

	public string displayname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string application
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string message
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_subscription_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_subscription_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_subscription_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_subscription_t()
	{
	}
}
