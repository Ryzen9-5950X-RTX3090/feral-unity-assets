using System;
using System.Collections.Generic;
using LitJson;
using UnityEngine;

namespace Server
{
	public interface INetMessageReader
	{
		string Cmd { get; }

		bool HasNext { get; }

		string ReadString();

		bool ReadSuccess();

		int ReadInt();

		uint ReadUInt();

		long ReadLong();

		float ReadFloat();

		double ReadDouble();

		bool ReadBool();

		Vector2 ReadVector2();

		Vector3 ReadVector3();

		Quaternion ReadQuaternion();

		string ReadDefId();

		DateTime ReadJamaaTimeSeconds();

		string PeekString();

		bool PeekSuccess();

		int PeekInt();

		uint PeekUInt();

		long PeekLong();

		float PeekFloat();

		double PeekDouble();

		bool PeekBool();

		Vector2 PeekVector2();

		Vector3 PeekVector3();

		string PeekDefId();

		string[] ReadStringArray();

		int[] ReadIntArray();

		void ReadStringArray(string[] into, int atIndex);

		Dictionary<string, string> ReadDictionaryStringArray();

		T ReadEnum<T>() where T : struct, IConvertible;

		T ReadJson<T>();

		JsonData ReadJson();

		T ReadJsonCompressed<T>();

		JsonData ReadJsonCompressed();
	}
}
