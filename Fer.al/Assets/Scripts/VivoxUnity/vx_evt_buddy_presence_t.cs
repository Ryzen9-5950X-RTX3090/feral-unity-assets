using System;
using System.Runtime.InteropServices;

public class vx_evt_buddy_presence_t : IDisposable
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

	public vx_buddy_presence_state state
	{
		get
		{
			return default(vx_buddy_presence_state);
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

	public vx_buddy_presence_state presence
	{
		get
		{
			return default(vx_buddy_presence_state);
		}
		set
		{
		}
	}

	public string custom_message
	{
		get
		{
			return null;
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

	public string contact
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string priority
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string encoded_uri_with_tag
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_buddy_presence_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_buddy_presence_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_buddy_presence_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_buddy_presence_t()
	{
	}
}
