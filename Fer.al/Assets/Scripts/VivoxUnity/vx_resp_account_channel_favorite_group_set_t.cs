using System;
using System.Runtime.InteropServices;

public class vx_resp_account_channel_favorite_group_set_t : IDisposable
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

	internal vx_resp_account_channel_favorite_group_set_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_channel_favorite_group_set_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_channel_favorite_group_set_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_channel_favorite_group_set_t()
	{
	}
}
