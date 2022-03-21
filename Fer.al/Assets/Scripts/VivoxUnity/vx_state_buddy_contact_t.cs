using System;
using System.Runtime.InteropServices;

public class vx_state_buddy_contact_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	public string display_name
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

	internal vx_state_buddy_contact_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_buddy_contact_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_buddy_contact_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_buddy_contact_t()
	{
	}
}
