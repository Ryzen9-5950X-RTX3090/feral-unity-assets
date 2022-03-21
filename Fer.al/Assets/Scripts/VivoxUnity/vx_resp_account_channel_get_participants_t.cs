using System;
using System.Runtime.InteropServices;

public class vx_resp_account_channel_get_participants_t : IDisposable
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

	public int participant_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_participant participants
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

	public int total
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_account_channel_get_participants_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_channel_get_participants_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_channel_get_participants_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_channel_get_participants_t()
	{
	}
}
