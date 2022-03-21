using System;
using System.Runtime.InteropServices;

public class vx_req_aux_connectivity_info_t : IDisposable
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

	public string well_known_ip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string stun_server
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string echo_server
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int echo_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int timeout
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string acct_mgmt_server
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_aux_connectivity_info_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_aux_connectivity_info_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_aux_connectivity_info_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_aux_connectivity_info_t t)
	{
		return null;
	}

	public vx_req_aux_connectivity_info_t()
	{
	}
}
