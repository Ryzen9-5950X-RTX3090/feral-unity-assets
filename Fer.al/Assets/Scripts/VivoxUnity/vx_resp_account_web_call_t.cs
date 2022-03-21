using System;
using System.Runtime.InteropServices;

public class vx_resp_account_web_call_t : IDisposable
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

	public string content_type
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int content_length
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string content
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_resp_account_web_call_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_web_call_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_web_call_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_web_call_t()
	{
	}
}
