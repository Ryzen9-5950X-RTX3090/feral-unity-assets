using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LitJson;
using Server;
using UnityEngine;

public class XtWriter : INetMessageWriter
{
	private List<string> _buffer;

	public string Cmd
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool Compress
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool NoReset
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public string[] Data
	{
		get
		{
			return null;
		}
	}

	public XtWriter(XtCmd cmd)
	{
	}

	public INetMessageWriter WriteString(string v)
	{
		return null;
	}

	public INetMessageWriter WriteInt(int v)
	{
		return null;
	}

	public INetMessageWriter WriteUInt(uint v)
	{
		return null;
	}

	public INetMessageWriter WriteLong(long v)
	{
		return null;
	}

	public INetMessageWriter WriteFloat(float v)
	{
		return null;
	}

	public INetMessageWriter WriteDouble(double v)
	{
		return null;
	}

	public INetMessageWriter WriteBytes(byte[] v)
	{
		return null;
	}

	public INetMessageWriter WriteBool(bool v)
	{
		return null;
	}

	public INetMessageWriter WriteDefId(string v)
	{
		return null;
	}

	public INetMessageWriter WriteVector3(Vector3 v)
	{
		return null;
	}

	public INetMessageWriter WriteQuaternion(Quaternion q)
	{
		return null;
	}

	public INetMessageWriter WriteJson(JsonData v)
	{
		return null;
	}

	public INetMessageWriter WriteJson(object v)
	{
		return null;
	}

	public INetMessageWriter WriteJson(IXtDataWriter dataWriter)
	{
		return null;
	}

	public INetMessageWriter WriteArray(IXtDataWriter[] array)
	{
		return null;
	}

	public INetMessageWriter WriteArray(string[] array)
	{
		return null;
	}

	public INetMessageWriter WriteArray(int[] array)
	{
		return null;
	}
}
