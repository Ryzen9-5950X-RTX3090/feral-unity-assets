using LitJson;
using UnityEngine;

namespace Server
{
	public interface INetMessageWriter
	{
		string Cmd { get; }

		bool Compress { get; set; }

		bool NoReset { get; set; }

		INetMessageWriter WriteString(string v);

		INetMessageWriter WriteInt(int v);

		INetMessageWriter WriteUInt(uint v);

		INetMessageWriter WriteLong(long v);

		INetMessageWriter WriteFloat(float v);

		INetMessageWriter WriteDouble(double v);

		INetMessageWriter WriteBytes(byte[] v);

		INetMessageWriter WriteBool(bool v);

		INetMessageWriter WriteDefId(string v);

		INetMessageWriter WriteVector3(Vector3 v);

		INetMessageWriter WriteQuaternion(Quaternion q);

		INetMessageWriter WriteJson(JsonData v);

		INetMessageWriter WriteJson(object o);

		INetMessageWriter WriteJson(IXtDataWriter o);

		INetMessageWriter WriteArray(IXtDataWriter[] o);

		INetMessageWriter WriteArray(string[] o);

		INetMessageWriter WriteArray(int[] o);
	}
}
