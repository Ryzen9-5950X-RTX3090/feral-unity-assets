using System.Collections.Generic;
using System.Runtime.InteropServices;

public class TwiggleController : ManagedBehaviour
{
	public enum ETwiggleState
	{
		None,
		WorkingSanctuary,
		WorkingOtherSanctuary,
		FinishedSanctuary,
		FinishedOtherSanctuary
	}

	private static TwiggleController _instance;

	private ETwiggleState _desiredTwiggleState;

	private ETwiggleState _currentTwiggleState;

	public static TwiggleController instance
	{
		get
		{
			return null;
		}
	}

	public ETwiggleState currentTwiggleState
	{
		get
		{
			return default(ETwiggleState);
		}
	}

	public override void MUpdate()
	{
	}

	private double GetSecondsRemaining(TwiggleItemComponent inComponent)
	{
		return default(double);
	}

	private bool ValidTwiggleInfo(TwiggleItemComponent inTwiggleItemComponent, string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return default(bool);
	}

	public int GetTwiggleCount()
	{
		return default(int);
	}

	private bool GetTwiggleWorking(TwiggleItemComponent inComponent)
	{
		return default(bool);
	}

	private bool GetTwiggleJobDone(TwiggleItemComponent inComponent)
	{
		return default(bool);
	}

	public string GetTwiggleJobDoneId(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return null;
	}

	public TwiggleItemComponent GetTwiggleItemComponent(string inId)
	{
		return null;
	}

	public TwiggleItemComponent GetTwiggleComponentJobDone(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return null;
	}

	public bool GetTwiggleJobDone([Optional] string inId, string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return default(bool);
	}

	public TwiggleItemComponent GetFirstTwiggleComponentFinished()
	{
		return null;
	}

	public TwiggleItemComponent GetFirstTwiggleComponentWorking()
	{
		return null;
	}

	public string GetFirstTwiggleWorkingId(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return null;
	}

	public List<string> GetAllTwiggleWorkingIds(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return null;
	}

	public bool GetTwiggleWorking([Optional] string inId, string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return default(bool);
	}

	public int GetTwigglesWorking(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return default(int);
	}

	public int GetAllTwigglesWorking()
	{
		return default(int);
	}

	public int GetAllTwigglesFinished()
	{
		return default(int);
	}

	public int GetAllTwigglesAvailable()
	{
		return default(int);
	}

	public int GetTwigglesAvailable(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return default(int);
	}

	public int GetTwigglesJobsDone(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return default(int);
	}

	public bool TwigglesFinished(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return default(bool);
	}

	public double GetTwiggleTimeSeconds(string inId)
	{
		return default(double);
	}

	public string GetAvailableTwiggleId(string inSanctuaryClassItemId = "", int inWorkerType = -1)
	{
		return null;
	}

	public string GetSanctuaryWorkingOnName(TwiggleItemComponent inTwiggleItemComponent)
	{
		return null;
	}
}
