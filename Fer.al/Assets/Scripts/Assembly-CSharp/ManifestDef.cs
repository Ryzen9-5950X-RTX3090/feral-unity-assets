using System;
using UnityEngine;

[Serializable]
public class ManifestDef : BaseDef
{
	public string hash;

	public string fileName;

	public int size;

	public static string _baseURL;

	private string _downloadURL;

	private static string BaseDownloadURL
	{
		get
		{
			return null;
		}
	}

	public string DownloadURL
	{
		get
		{
			return null;
		}
	}

	public bool IsIncluded
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsDownloaderCached
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCached
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsCachedInAnyWay
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsImportant
	{
		get
		{
			return default(bool);
		}
	}

	public string HashedFileName
	{
		get
		{
			return null;
		}
	}

	public string TempHashedFileName
	{
		get
		{
			return null;
		}
	}

	public string BundleIncludedFilePath
	{
		get
		{
			return null;
		}
	}

	public string BundleTarCacheFilePath
	{
		get
		{
			return null;
		}
	}

	public string BundleDownloaderCacheTempFilePath
	{
		get
		{
			return null;
		}
	}

	public string BundleCacheTempFilePath
	{
		get
		{
			return null;
		}
	}

	public string BundleCacheFilePath
	{
		get
		{
			return null;
		}
	}

	public string BundleLocalFilePath
	{
		get
		{
			return null;
		}
	}

	[RuntimeInitializeOnLoadMethod]
	public static void FastPlayModeReset()
	{
	}

	public override void LoadEntry()
	{
	}

	public void DeleteFromCache()
	{
	}
}
