using System;
using System.Runtime.InteropServices;

public class vx_resp_account_get_session_fonts_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_resp_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_voice_font session_fonts
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int session_font_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_account_get_session_fonts_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_account_get_session_fonts_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_account_get_session_fonts_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_account_get_session_fonts_t()
	{
	}
}
