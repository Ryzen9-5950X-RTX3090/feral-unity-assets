using System;
using System.Runtime.InteropServices;

public class vx_req_channel_mute_all_users_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_req_base_t base_
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

	public string channel_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string channel_uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int set_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_mute_scope scope
	{
		get
		{
			return default(vx_mute_scope);
		}
		set
		{
		}
	}

	public string access_token
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_channel_mute_all_users_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_channel_mute_all_users_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_channel_mute_all_users_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_channel_mute_all_users_t t)
	{
		return null;
	}

	public vx_req_channel_mute_all_users_t()
	{
	}
}
