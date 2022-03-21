using System;
using System.Runtime.InteropServices;

public class vx_connectivity_test_result_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public ND_TEST_TYPE test_type
	{
		get
		{
			return default(ND_TEST_TYPE);
		}
		set
		{
		}
	}

	public ND_ERROR test_error_code
	{
		get
		{
			return default(ND_ERROR);
		}
		set
		{
		}
	}

	public string test_additional_info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_connectivity_test_result_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_connectivity_test_result_t obj)
	{
		return default(HandleRef);
	}

	~vx_connectivity_test_result_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_connectivity_test_result_t()
	{
	}
}
