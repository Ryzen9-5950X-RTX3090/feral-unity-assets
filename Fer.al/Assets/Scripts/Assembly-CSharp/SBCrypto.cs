using System.Security.Cryptography;

public static class SBCrypto
{
	public static byte[] CreateEncryptionKeyBytesFromHashKey(string hashKey)
	{
		return null;
	}

	public static string EncryptText(string plainText, string encryptionKey)
	{
		return null;
	}

	public static string EncryptPassword(string inPassword, string inKey)
	{
		return null;
	}

	private static byte[] EncryptStringToBytes(string plainText, RijndaelManaged rijAlg)
	{
		return null;
	}

	private static string DecryptStringFromBytes(byte[] cipherText, byte[] Key, byte[] IV)
	{
		return null;
	}

	public static string StringToHexString(string inInput)
	{
		return null;
	}

	public static byte[] HexStringToByte(string hexString)
	{
		return null;
	}

	public static string ByteArrayToHexString(byte[] ba)
	{
		return null;
	}
}
