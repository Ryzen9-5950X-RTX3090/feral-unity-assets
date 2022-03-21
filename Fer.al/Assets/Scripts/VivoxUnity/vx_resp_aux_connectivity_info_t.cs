using System;
using System.Runtime.InteropServices;

public class vx_resp_aux_connectivity_info_t : IDisposable
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

	public int count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_connectivity_test_result test_results
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

	public int first_sip_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int second_sip_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int rtp_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int rtcp_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_aux_connectivity_info_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_aux_connectivity_info_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_aux_connectivity_info_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_aux_connectivity_info_t()
	{
	}
}
