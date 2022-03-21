using BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Prng;
using BestHTTP.SecureProtocol.Org.BouncyCastle.Security;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public interface TlsContext
	{
		IRandomGenerator NonceRandomGenerator { get; }

		SecureRandom SecureRandom { get; }

		SecurityParameters SecurityParameters { get; }

		bool IsServer { get; }

		ProtocolVersion ClientVersion { get; }

		ProtocolVersion ServerVersion { get; }

		TlsSession ResumableSession { get; }

		object UserObject { get; set; }

		byte[] ExportKeyingMaterial(string asciiLabel, byte[] context_value, int length);
	}
}
