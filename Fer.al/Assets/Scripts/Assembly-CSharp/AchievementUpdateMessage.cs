using System.Collections.Generic;
using System.Runtime.CompilerServices;
using LitJson;
using Server;

public class AchievementUpdateMessage : ServiceMessage
{
	public List<Achievement> ChangedAchievements
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

	public AchievementUpdateMessage(JsonData jsonData)
	{
	}
}
