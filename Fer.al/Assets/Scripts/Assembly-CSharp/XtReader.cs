using System;
using System.Collections.Generic;
using LitJson;
using Server;
using UnityEngine;

public class XtReader : INetMessageReader
{
	private int cursor;

	public readonly string[] Data;

	public string Cmd
	{
		get
		{
			return null;
		}
	}

	public bool HasNext
	{
		get
		{
			return default(bool);
		}
	}

	public XtReader(string[] data, int cursorIndex = 2)
	{
	}

	public XtReader(XtReader copy)
	{
	}

	public XtReader SetCursor(int index)
	{
		return null;
	}

	public string At(int index)
	{
		return null;
	}

	public string ReadString()
	{
		return null;
	}

	public bool ReadSuccess()
	{
		return default(bool);
	}

	public int ReadInt()
	{
		return default(int);
	}

	public uint ReadUInt()
	{
		return default(uint);
	}

	public long ReadLong()
	{
		return default(long);
	}

	public float ReadFloat()
	{
		return default(float);
	}

	public double ReadDouble()
	{
		return default(double);
	}

	public bool ReadBool()
	{
		return default(bool);
	}

	public Vector2 ReadVector2()
	{
		return default(Vector2);
	}

	public Vector3 ReadVector3()
	{
		return default(Vector3);
	}

	public Quaternion ReadQuaternion()
	{
		return default(Quaternion);
	}

	public string ReadDefId()
	{
		return null;
	}

	public DateTime ReadJamaaTimeSeconds()
	{
		return default(DateTime);
	}

	public string PeekString()
	{
		return null;
	}

	public bool PeekSuccess()
	{
		return default(bool);
	}

	public int PeekInt()
	{
		return default(int);
	}

	public uint PeekUInt()
	{
		return default(uint);
	}

	public long PeekLong()
	{
		return default(long);
	}

	public float PeekFloat()
	{
		return default(float);
	}

	public double PeekDouble()
	{
		return default(double);
	}

	public bool PeekBool()
	{
		return default(bool);
	}

	public Vector2 PeekVector2()
	{
		return default(Vector2);
	}

	public Vector3 PeekVector3()
	{
		return default(Vector3);
	}

	public string PeekDefId()
	{
		return null;
	}

	public void Skip(int amount = 1)
	{
	}

	public Dictionary<string, string> ReadDictionaryStringArray()
	{
		return null;
	}

	public string[] ReadStringArray()
	{
		return null;
	}

	public void ReadStringArray(string[] into, int atIndex)
	{
	}

	public int[] ReadIntArray()
	{
		return null;
	}

	public T ReadEnum<T>() where T : struct, IConvertible
	{
		return (T)null;
	}

	public override string ToString()
	{
		return null;
	}

	public T ReadJson<T>()
	{
		return (T)null;
	}

	public JsonData ReadJson()
	{
		return null;
	}

	public T ReadJsonCompressed<T>()
	{
		return (T)null;
	}

	public JsonData ReadJsonCompressed()
	{
		return null;
	}
}
