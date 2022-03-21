using System;
using System.Runtime.InteropServices;

public class vx_req_account_create_auto_accept_rule_t : IDisposable
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

	public string auto_accept_mask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int auto_add_as_buddy
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string auto_accept_nickname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_account_create_auto_accept_rule_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_account_create_auto_accept_rule_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_account_create_auto_accept_rule_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_account_create_auto_accept_rule_t t)
	{
		return null;
	}

	public vx_req_account_create_auto_accept_rule_t()
	{
	}
}
