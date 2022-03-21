using System;
using System.Runtime.InteropServices;

public class vx_req_account_channel_create_t : IDisposable
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

	public string channel_desc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_channel_type channel_type
	{
		get
		{
			return default(vx_channel_type);
		}
		set
		{
		}
	}

	public int set_persistent
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int set_protected
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string protected_password
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int capacity
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int max_participants
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_channel_mode channel_mode
	{
		get
		{
			return default(vx_channel_mode);
		}
		set
		{
		}
	}

	public int max_range
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int clamping_dist
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double roll_off
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public double max_gain
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public int dist_model
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int encrypt_audio
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_req_account_channel_create_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_account_channel_create_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_account_channel_create_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_account_channel_create_t t)
	{
		return null;
	}

	public vx_req_account_channel_create_t()
	{
	}
}
