using System;
using System.Runtime.InteropServices;

public class vx_req_account_list_auto_accept_rules_t : IDisposable
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

	internal vx_req_account_list_auto_accept_rules_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_account_list_auto_accept_rules_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_account_list_auto_accept_rules_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_account_list_auto_accept_rules_t t)
	{
		return null;
	}

	public vx_req_account_list_auto_accept_rules_t()
	{
	}
}
