using System;
using System.Runtime.InteropServices;

public class vx_name_value_pair_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_name_value_pair_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_name_value_pair_t obj)
	{
		return default(HandleRef);
	}

	~vx_name_value_pair_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_name_value_pair_t()
	{
	}
}
