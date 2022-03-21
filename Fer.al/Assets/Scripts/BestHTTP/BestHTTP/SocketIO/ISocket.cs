namespace BestHTTP.SocketIO
{
	public interface ISocket
	{
		void Open();

		void Disconnect(bool remove);

		void OnPacket(Packet packet);

		void EmitEvent(SocketIOEventTypes type, object[] args);

		void EmitEvent(string eventName, object[] args);

		void EmitError(SocketIOErrors errCode, string msg);
	}
}
