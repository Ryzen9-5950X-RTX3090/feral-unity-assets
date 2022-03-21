using System;
using System.Runtime.InteropServices;

public class vx_channel_favorite_group_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public int favorite_group_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string favorite_group_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string favorite_group_data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string favorite_group_modified
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_channel_favorite_group_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_channel_favorite_group_t obj)
	{
		return default(HandleRef);
	}

	~vx_channel_favorite_group_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_channel_favorite_group_t()
	{
	}
}
