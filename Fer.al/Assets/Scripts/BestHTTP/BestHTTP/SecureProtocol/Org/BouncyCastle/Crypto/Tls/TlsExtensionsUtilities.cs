using System.Collections;
using System.Collections.Generic;

namespace BestHTTP.SecureProtocol.Org.BouncyCastle.Crypto.Tls
{
	public abstract class TlsExtensionsUtilities
	{
		public static IDictionary EnsureExtensionsInitialised(IDictionary extensions)
		{
			return null;
		}

		public static void AddClientCertificateTypeExtensionClient(IDictionary extensions, byte[] certificateTypes)
		{
		}

		public static void AddClientCertificateTypeExtensionServer(IDictionary extensions, byte certificateType)
		{
		}

		public static void AddEncryptThenMacExtension(IDictionary extensions)
		{
		}

		public static void AddExtendedMasterSecretExtension(IDictionary extensions)
		{
		}

		public static void AddHeartbeatExtension(IDictionary extensions, HeartbeatExtension heartbeatExtension)
		{
		}

		public static void AddMaxFragmentLengthExtension(IDictionary extensions, byte maxFragmentLength)
		{
		}

		public static void AddPaddingExtension(IDictionary extensions, int dataLength)
		{
		}

		public static void AddServerCertificateTypeExtensionClient(IDictionary extensions, byte[] certificateTypes)
		{
		}

		public static void AddServerCertificateTypeExtensionServer(IDictionary extensions, byte certificateType)
		{
		}

		public static void AddServerNameExtension(IDictionary extensions, ServerNameList serverNameList)
		{
		}

		public static void AddALPNExtension(IDictionary extensions, List<string> protocols)
		{
		}

		public static void AddStatusRequestExtension(IDictionary extensions, CertificateStatusRequest statusRequest)
		{
		}

		public static void AddTruncatedHMacExtension(IDictionary extensions)
		{
		}

		public static byte[] GetClientCertificateTypeExtensionClient(IDictionary extensions)
		{
			return null;
		}

		public static short GetClientCertificateTypeExtensionServer(IDictionary extensions)
		{
			return default(short);
		}

		public static HeartbeatExtension GetHeartbeatExtension(IDictionary extensions)
		{
			return null;
		}

		public static short GetMaxFragmentLengthExtension(IDictionary extensions)
		{
			return default(short);
		}

		public static int GetPaddingExtension(IDictionary extensions)
		{
			return default(int);
		}

		public static byte[] GetServerCertificateTypeExtensionClient(IDictionary extensions)
		{
			return null;
		}

		public static short GetServerCertificateTypeExtensionServer(IDictionary extensions)
		{
			return default(short);
		}

		public static ServerNameList GetServerNameExtension(IDictionary extensions)
		{
			return null;
		}

		public static CertificateStatusRequest GetStatusRequestExtension(IDictionary extensions)
		{
			return null;
		}

		public static bool HasEncryptThenMacExtension(IDictionary extensions)
		{
			return default(bool);
		}

		public static bool HasExtendedMasterSecretExtension(IDictionary extensions)
		{
			return default(bool);
		}

		public static bool HasTruncatedHMacExtension(IDictionary extensions)
		{
			return default(bool);
		}

		public static byte[] CreateCertificateTypeExtensionClient(byte[] certificateTypes)
		{
			return null;
		}

		public static byte[] CreateCertificateTypeExtensionServer(byte certificateType)
		{
			return null;
		}

		public static byte[] CreateEmptyExtensionData()
		{
			return null;
		}

		public static byte[] CreateEncryptThenMacExtension()
		{
			return null;
		}

		public static byte[] CreateExtendedMasterSecretExtension()
		{
			return null;
		}

		public static byte[] CreateHeartbeatExtension(HeartbeatExtension heartbeatExtension)
		{
			return null;
		}

		public static byte[] CreateMaxFragmentLengthExtension(byte maxFragmentLength)
		{
			return null;
		}

		public static byte[] CreatePaddingExtension(int dataLength)
		{
			return null;
		}

		public static byte[] CreateServerNameExtension(ServerNameList serverNameList)
		{
			return null;
		}

		public static byte[] CreateALPNExtension(List<string> protocols)
		{
			return null;
		}

		public static byte[] CreateStatusRequestExtension(CertificateStatusRequest statusRequest)
		{
			return null;
		}

		public static byte[] CreateTruncatedHMacExtension()
		{
			return null;
		}

		private static bool ReadEmptyExtensionData(byte[] extensionData)
		{
			return default(bool);
		}

		public static byte[] ReadCertificateTypeExtensionClient(byte[] extensionData)
		{
			return null;
		}

		public static byte ReadCertificateTypeExtensionServer(byte[] extensionData)
		{
			return default(byte);
		}

		public static bool ReadEncryptThenMacExtension(byte[] extensionData)
		{
			return default(bool);
		}

		public static bool ReadExtendedMasterSecretExtension(byte[] extensionData)
		{
			return default(bool);
		}

		public static HeartbeatExtension ReadHeartbeatExtension(byte[] extensionData)
		{
			return null;
		}

		public static byte ReadMaxFragmentLengthExtension(byte[] extensionData)
		{
			return default(byte);
		}

		public static int ReadPaddingExtension(byte[] extensionData)
		{
			return default(int);
		}

		public static ServerNameList ReadServerNameExtension(byte[] extensionData)
		{
			return null;
		}

		public static CertificateStatusRequest ReadStatusRequestExtension(byte[] extensionData)
		{
			return null;
		}

		public static bool ReadTruncatedHMacExtension(byte[] extensionData)
		{
			return default(bool);
		}
	}
}
