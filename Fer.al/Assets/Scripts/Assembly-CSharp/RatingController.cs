using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RatingController
{
	private static string _androidRatingURI;

	private static string _iOSRatingURI;

	private static string _url;

	private static string _iOSAppID;

	private static string _storeRatingSave;

	private static string _timeSave;

	private static Coroutine _increasePlayTimeCoroutine;

	private static float _totalPlayTime;

	private static float _saveTimeIncrement;

	private static bool _enabled
	{
		get
		{
			return default(bool);
		}
	}

	private static float _ratingAfterPlayTime
	{
		get
		{
			return default(float);
		}
	}

	private static int _levelForReview
	{
		get
		{
			return default(int);
		}
	}

	private static bool _hasRated
	{
		get
		{
			return default(bool);
		}
	}

	[RuntimeInitializeOnLoadMethod]
	public static void Init()
	{
	}

	[IteratorStateMachine(typeof(<AddXPUpdateMessage>d__18))]
	private static IEnumerator AddXPUpdateMessage()
	{
		return null;
	}

	private static void OnAstralShopPurchaseMessage(AstralShopPurchaseMessage inMessage)
	{
	}

	private static void OnXPGained(XPUpdateMessage inMessage)
	{
	}

	private static void OnLevelLoaded(Message inMessage)
	{
	}

	[IteratorStateMachine(typeof(<IncreasePlayTime>d__22))]
	private static IEnumerator IncreasePlayTime()
	{
		return null;
	}

	private static void TriggerReview()
	{
	}

	private static void RequestStoreReview()
	{
	}

	private static bool LoadRated()
	{
		return default(bool);
	}

	private static void SaveRated()
	{
	}

	private static void OpenURL()
	{
	}
}
