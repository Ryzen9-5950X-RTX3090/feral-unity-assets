using System;
using System.Runtime.InteropServices;

public class vx_resp_account_list_buddies_and_groups_t : IDisposable
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

	internal vx_resp_account_list_buddies_and_groups_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_list_buddies_and_groups_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_list_buddies_and_groups_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_list_buddies_and_groups_t()
	{
	}
}
