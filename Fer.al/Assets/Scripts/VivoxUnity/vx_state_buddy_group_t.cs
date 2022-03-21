using System;
using System.Runtime.InteropServices;

public class vx_state_buddy_group_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	internal vx_state_buddy_group_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_buddy_group_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_buddy_group_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_buddy_group_t()
	{
	}
}
