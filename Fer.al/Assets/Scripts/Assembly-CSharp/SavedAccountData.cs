using System;
using System.Runtime.CompilerServices;

[Serializable]
public class SavedAccountData
{
	public enum SortOrder
	{
		None,
		LastPlayed,
		DateCreated
	}

	public string Email
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

	public string Token
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

	public bool IsGuest
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DateTime LastSeen
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public DateTime Created
	{
		[CompilerGenerated]
		get
		{
			return default(DateTime);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public SavedAccountData(string email, string token, bool isGuest)
	{
	}

	public void ClearToken()
	{
	}

	public static int SortByLastPlayed(SavedAccountData left, SavedAccountData right)
	{
		return default(int);
	}

	public static int SortByDateCreated(SavedAccountData left, SavedAccountData right)
	{
		return default(int);
	}
}
