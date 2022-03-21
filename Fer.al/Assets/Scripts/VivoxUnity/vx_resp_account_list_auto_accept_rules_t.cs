using System;
using System.Runtime.InteropServices;

public class vx_resp_account_list_auto_accept_rules_t : IDisposable
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

	public int rule_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_auto_accept_rule auto_accept_rules
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_resp_account_list_auto_accept_rules_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_list_auto_accept_rules_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_list_auto_accept_rules_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_list_auto_accept_rules_t()
	{
	}
}
