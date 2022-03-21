using System;
using System.Runtime.InteropServices;

public class vx_evt_idle_state_changed_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_evt_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int is_idle
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_idle_state_changed_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_idle_state_changed_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_idle_state_changed_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_idle_state_changed_t()
	{
	}
}
