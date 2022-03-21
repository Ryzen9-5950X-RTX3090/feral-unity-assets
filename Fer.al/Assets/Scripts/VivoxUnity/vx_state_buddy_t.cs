using System;
using System.Runtime.InteropServices;

public class vx_state_buddy_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	public int parent_group_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string buddy_data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int state_buddy_contact_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_state_buddy_contact state_buddy_contacts
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_state_buddy_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_buddy_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_buddy_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_buddy_t()
	{
	}
}
