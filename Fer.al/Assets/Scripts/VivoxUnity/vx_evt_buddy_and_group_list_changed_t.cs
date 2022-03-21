using System;
using System.Runtime.InteropServices;

public class vx_evt_buddy_and_group_list_changed_t : IDisposable
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

	public int buddy_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_buddy buddies
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int group_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_group groups
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_buddy_and_group_list_changed_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_buddy_and_group_list_changed_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_buddy_and_group_list_changed_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_buddy_and_group_list_changed_t()
	{
	}
}
