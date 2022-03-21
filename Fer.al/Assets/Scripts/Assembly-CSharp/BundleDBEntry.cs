using System.Runtime.CompilerServices;
using SQLite4Unity3d;

public class BundleDBEntry
{
	[PrimaryKey]
	public string bundleName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public string unityHash
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}
}
