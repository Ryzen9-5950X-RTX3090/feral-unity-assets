using System;
using System.Runtime.InteropServices;

public class vx_block_rule_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public string block_mask
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int presence_only
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_block_rule_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_block_rule_t obj)
	{
		return default(HandleRef);
	}

	~vx_block_rule_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_block_rule_t()
	{
	}
}
