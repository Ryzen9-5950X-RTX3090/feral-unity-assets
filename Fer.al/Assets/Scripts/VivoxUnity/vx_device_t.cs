using System;
using System.Runtime.InteropServices;

public class vx_device_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public string device
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string display_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_device_type_t device_type
	{
		get
		{
			return default(vx_device_type_t);
		}
		set
		{
		}
	}

	internal vx_device_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_device_t obj)
	{
		return default(HandleRef);
	}

	~vx_device_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_device_t()
	{
	}
}
