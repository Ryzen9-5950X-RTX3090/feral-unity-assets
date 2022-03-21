public class GCR : MonoBehaviour
{
	private bool _quitting;

	private static GCR _instance;

	public static GCR instance
	{
		get
		{
			return null;
		}
	}

	private void OnApplicationQuit()
	{
	}
}
