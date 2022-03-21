using System;
using System.Runtime.InteropServices;

public class vx_vxd_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public uint version
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public string participant_uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string data
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint data_size
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal vx_vxd_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_vxd_t obj)
	{
		return default(HandleRef);
	}

	~vx_vxd_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_vxd_t()
	{
	}
}
