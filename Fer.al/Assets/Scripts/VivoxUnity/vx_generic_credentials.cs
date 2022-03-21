using System;
using System.Runtime.InteropServices;

public class vx_generic_credentials : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public string admin_username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string admin_password
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string grant_document
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string server_url
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_generic_credentials(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_generic_credentials obj)
	{
		return default(HandleRef);
	}

	~vx_generic_credentials()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_generic_credentials()
	{
	}
}
