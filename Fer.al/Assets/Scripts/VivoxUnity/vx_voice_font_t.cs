using System;
using System.Runtime.InteropServices;

public class vx_voice_font_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public int id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int parent_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_font_type type
	{
		get
		{
			return default(vx_font_type);
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

	public string description
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string expiration_date
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int expired
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string font_delta
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string font_rules
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_font_status status
	{
		get
		{
			return default(vx_font_status);
		}
		set
		{
		}
	}

	internal vx_voice_font_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_voice_font_t obj)
	{
		return default(HandleRef);
	}

	~vx_voice_font_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_voice_font_t()
	{
	}
}
