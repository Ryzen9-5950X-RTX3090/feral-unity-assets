using System;
using System.Runtime.InteropServices;

public class vx_channel_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	public string host
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int channel_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int limit
	{
		get
		{
			return default(int);
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

	public string modified
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string owner
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string owner_user_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int is_persistent
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_protected
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int size
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int type
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_channel_mode mode
	{
		get
		{
			return default(vx_channel_mode);
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

	public string owner_display_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int active_participants
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_channel_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_channel_t obj)
	{
		return default(HandleRef);
	}

	~vx_channel_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_channel_t()
	{
	}
}
