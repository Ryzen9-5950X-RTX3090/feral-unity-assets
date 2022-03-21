using System.Collections;
using System.Runtime.CompilerServices;

public abstract class CoreLevelBase : MonoBehaviour
{
	public static CoreLevelBase instance;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(<InitFromManager>d__3))]
	public virtual IEnumerator InitFromManager()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitForThingsToFinish>d__4))]
	public virtual IEnumerator WaitForThingsToFinish()
	{
		return null;
	}
}
