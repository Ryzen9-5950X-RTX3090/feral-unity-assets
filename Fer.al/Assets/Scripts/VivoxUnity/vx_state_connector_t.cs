using System;
using System.Runtime.InteropServices;

public class vx_state_connector_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public string connector_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int state_accounts_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_state_account state_accounts
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int mic_vol
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int mic_mute
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int speaker_vol
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int speaker_mute
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_state_connector_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_connector_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_connector_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_connector_t()
	{
	}
}
