using UnityEngine.Networking;

public class SslValidationOverride : CertificateHandler
{
	protected override bool ValidateCertificate(byte[] certificateData)
	{
		return default(bool);
	}
}
