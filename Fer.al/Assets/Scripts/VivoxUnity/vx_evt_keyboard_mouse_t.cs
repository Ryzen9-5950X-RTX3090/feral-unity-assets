using System;
using System.Runtime.InteropServices;

public class vx_evt_keyboard_mouse_t : IDisposable
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

	public int is_down
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_keyboard_mouse_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_keyboard_mouse_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_keyboard_mouse_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_keyboard_mouse_t()
	{
	}
}
