using System;
using System.Runtime.InteropServices;

public class vx_evt_buddy_group_changed_t : IDisposable
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

	public vx_change_type_t change_type
	{
		get
		{
			return default(vx_change_type_t);
		}
		set
		{
		}
	}

	public int group_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string group_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string group_data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_buddy_group_changed_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_buddy_group_changed_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_buddy_group_changed_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_buddy_group_changed_t()
	{
	}
}
