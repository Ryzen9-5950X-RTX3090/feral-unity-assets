using System;

namespace BestHTTP.SocketIO3
{
	public struct EmitBuilder
	{
		private Socket socket;

		internal bool isVolatile;

		internal int id;

		internal EmitBuilder(Socket s)
		{
		}

		public EmitBuilder ExpectAcknowledgement(Action callback)
		{
			return default(EmitBuilder);
		}

		public EmitBuilder ExpectAcknowledgement<T>(Action<T> callback)
		{
			return default(EmitBuilder);
		}

		public EmitBuilder Volatile()
		{
			return default(EmitBuilder);
		}

		public Socket Emit(string eventName, object[] args)
		{
			return null;
		}
	}
}
