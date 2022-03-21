using UnityEngine.Events;

public class PickupsController
{
	public static UnityAction<string, string, float> NotifyHud;

	public static void Collect(string inDefId, bool inShowNotification = true, int inCount = 1)
	{
	}

	private static void SendHudNotification(string inDefId, bool inShowNotification = true, int inCount = 1)
	{
	}

	public static string StyleItemName(ERarity inRarity, string inNameString)
	{
		return null;
	}
}
