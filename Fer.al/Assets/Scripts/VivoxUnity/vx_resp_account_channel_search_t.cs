using System;
using System.Runtime.InteropServices;

public class vx_resp_account_channel_search_t : IDisposable
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

	public int page
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int from
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int to
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int channel_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_channel channels
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_resp_account_channel_search_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_channel_search_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_channel_search_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_channel_search_t()
	{
	}
}
