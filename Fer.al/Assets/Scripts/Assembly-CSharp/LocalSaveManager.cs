using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class LocalSaveManager : CoreLocalSaveManager
{
	private static class SaveKey
	{
		public static string SAVED_ACCOUNTS
		{
			get
			{
				return null;
			}
		}
	}

	[Serializable]
	public class SavedAccountDataList
	{
		public List<SavedAccountData> Accounts
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public SavedAccountDataList(List<SavedAccountData> accounts)
		{
		}
	}

	public new static CoreLocalSaveManager instance
	{
		get
		{
			return null;
		}
	}

	public static List<SavedAccountData> GetSavedAccounts(SavedAccountData.SortOrder sorting = SavedAccountData.SortOrder.LastPlayed)
	{
		return null;
	}

	public static void SaveAccountData(List<SavedAccountData> accounts)
	{
	}

	public static SavedAccountData GetLastPlayedSavedAccount()
	{
		return null;
	}
}
