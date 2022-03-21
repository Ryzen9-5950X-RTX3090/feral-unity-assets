using System;
using System.Runtime.InteropServices;

public class vx_resp_account_anonymous_login_t : IDisposable
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

	public int account_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string displayname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string encoded_uri_with_tag
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_resp_account_anonymous_login_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_anonymous_login_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_anonymous_login_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_anonymous_login_t()
	{
	}
}
