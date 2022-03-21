using System;
using System.Runtime.InteropServices;

public class vx_user_channel_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	internal vx_user_channel_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_user_channel_t obj)
	{
		return default(HandleRef);
	}

	~vx_user_channel_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_user_channel_t()
	{
	}
}
