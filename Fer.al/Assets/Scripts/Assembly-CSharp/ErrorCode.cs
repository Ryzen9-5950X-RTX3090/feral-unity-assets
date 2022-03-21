using System.Collections.Generic;

public class ErrorCode
{
	private static readonly IDictionary<int, ErrorCode> _errorCodesLookup;

	private static bool _isErrorCodesLookupInitialized;

	private static bool _isInitializingErrorCodes;

	private int _code;

	private string _subcode;

	private string _internalErrorText;

	private bool _isShownAsError;

	private bool _isInitialized;

	[ErrorCodeDefinition]
	public static ErrorCode None
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode DeviceUnsupported
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode NoInternet
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode CurrentStoreVersionNull
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode StoreVersionMismatchOfflineMode
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode StoreVersionMismatchOnlineMode
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode UpdateInProgress
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode DisconnectPopupClosedReset
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode FailedBackgroundInternetCheck
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode LostServerConnection
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode BundleDownloadFailure
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode IncompatibleBundleFailure
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode FailedToFreeUpDiskSpace
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode LoadedEmptyAssetBundle
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode UnencryptedChartData
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode ChangingLanguages
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode DownloadManifestHashRetryExceeded
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode ServerManifestChanged
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode ChartDownloadProgressStalled
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode ChartDownloadFailure
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode DatabaseDoesNotExist
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode DatabaseFileDownloadRetryLimitExceeded
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode NoCachedDatabaseFileForcedOfflineMode
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode NoCachedHashForDatabaseFileOfflineMode
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode NoCachedDatabaseFileOfflineMode
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode LoadingTimeout
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode TarFailure
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode HangingLoadingScreen
	{
		get
		{
			return null;
		}
	}

	[ErrorCodeDefinition]
	public static ErrorCode IdleUserTimeout
	{
		get
		{
			return null;
		}
	}

	protected virtual int ErrorCodeLowerBound
	{
		get
		{
			return default(int);
		}
	}

	protected virtual int ErrorCodeUpperBound
	{
		get
		{
			return default(int);
		}
	}

	public int Code
	{
		get
		{
			return default(int);
		}
	}

	public string Subcode
	{
		get
		{
			return null;
		}
	}

	public string InternalErrorText
	{
		get
		{
			return null;
		}
	}

	public bool IsShownAsError
	{
		get
		{
			return default(bool);
		}
	}

	public static int[] GetAllCodes()
	{
		return null;
	}

	public static bool Contains(int code)
	{
		return default(bool);
	}

	public static ErrorCode Get(int code)
	{
		return null;
	}

	protected static T DefineErrorCode<T>(int code, string internalErrorText, bool isShownAsError) where T : ErrorCode, new()
	{
		return null;
	}

	private static void InitializeErrorCodes()
	{
	}

	public ErrorCode WithSubCode(string subCode)
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return default(bool);
	}

	public override int GetHashCode()
	{
		return default(int);
	}

	public override string ToString()
	{
		return null;
	}

	public string ToString(bool displayInternalErrorText)
	{
		return null;
	}

	private void InitializeErrorCode(int code, string internalErrorText, bool isShownAsError)
	{
	}

	private void CheckInitialization()
	{
	}
}
