using System;
using System.Runtime.InteropServices;

public class vx_channel_favorite_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public int favorite_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

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

	public string favorite_display_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string favorite_data
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

	public string channel_description
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int channel_limit
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int channel_capacity
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string channel_modified
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string channel_owner_user_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int channel_is_persistent
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int channel_is_protected
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int channel_size
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string channel_owner
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string channel_owner_display_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int channel_active_participants
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_channel_favorite_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_channel_favorite_t obj)
	{
		return default(HandleRef);
	}

	~vx_channel_favorite_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_channel_favorite_t()
	{
	}
}
