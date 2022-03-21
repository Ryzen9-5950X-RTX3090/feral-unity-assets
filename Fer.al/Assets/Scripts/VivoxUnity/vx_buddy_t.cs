using System;
using System.Runtime.InteropServices;

public class vx_buddy_t : IDisposable
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

	public int account_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string account_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_buddy_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_buddy_t obj)
	{
		return default(HandleRef);
	}

	~vx_buddy_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_buddy_t()
	{
	}
}
