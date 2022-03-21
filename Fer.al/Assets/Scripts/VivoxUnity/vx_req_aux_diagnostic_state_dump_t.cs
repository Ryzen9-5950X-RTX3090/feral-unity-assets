using System;
using System.Runtime.InteropServices;

public class vx_req_aux_diagnostic_state_dump_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_req_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_diagnostic_dump_level level
	{
		get
		{
			return default(vx_diagnostic_dump_level);
		}
		set
		{
		}
	}

	internal vx_req_aux_diagnostic_state_dump_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_aux_diagnostic_state_dump_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_aux_diagnostic_state_dump_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_aux_diagnostic_state_dump_t t)
	{
		return null;
	}

	public vx_req_aux_diagnostic_state_dump_t()
	{
	}
}
