using System;
using System.Runtime.InteropServices;

public class vx_auto_accept_rule_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	internal vx_auto_accept_rule_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_auto_accept_rule_t obj)
	{
		return default(HandleRef);
	}

	~vx_auto_accept_rule_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_auto_accept_rule_t()
	{
	}
}
