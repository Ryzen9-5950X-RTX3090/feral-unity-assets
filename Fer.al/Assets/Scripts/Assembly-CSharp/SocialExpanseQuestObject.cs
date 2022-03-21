public class SocialExpanseQuestObject : MonoBehaviour
{
	public bool activeWhenQuestComplete;

	public bool activeWhenQuestIncomplete;

	private bool _expanseStarted;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnSocialExpanseStartup(SocialExpanseStartupMessage inMessage)
	{
	}
}
