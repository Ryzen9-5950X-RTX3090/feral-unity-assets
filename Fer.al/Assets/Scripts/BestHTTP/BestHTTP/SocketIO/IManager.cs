using BestHTTP.SocketIO.Transports;

namespace BestHTTP.SocketIO
{
	public interface IManager
	{
		void Remove(Socket socket);

		void Close(bool removeSockets = true);

		void TryToReconnect();

		bool OnTransportConnected(ITransport transport);

		void OnTransportError(ITransport trans, string err);

		void OnTransportProbed(ITransport trans);

		void SendPacket(Packet packet);

		void OnPacket(Packet packet);

		void EmitEvent(string eventName, object[] args);

		void EmitEvent(SocketIOEventTypes type, object[] args);

		void EmitError(SocketIOErrors errCode, string msg);

		void EmitAll(string eventName, object[] args);
	}
}
