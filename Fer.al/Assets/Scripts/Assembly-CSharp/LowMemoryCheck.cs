using System.Collections;
using System.Runtime.CompilerServices;

public class LowMemoryCheck : MonoBehaviour
{
	public static LowMemoryCheck instance
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

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnLowMemory()
	{
	}

	[IteratorStateMachine(typeof(<OnLowMemoryCoroutine>d__7))]
	private IEnumerator OnLowMemoryCoroutine()
	{
		return null;
	}
}
