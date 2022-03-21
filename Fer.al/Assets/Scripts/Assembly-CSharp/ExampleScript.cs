using System.Collections;
using System.Runtime.CompilerServices;
using CielaSpike;

public class ExampleScript : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(<StartExamples>d__2))]
	private IEnumerator StartExamples()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Blocking>d__3))]
	private IEnumerator Blocking()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<Cancellation>d__4))]
	private IEnumerator Cancellation()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ErrorHandling>d__5))]
	private IEnumerator ErrorHandling()
	{
		return null;
	}

	private void LogAsync(string msg)
	{
	}

	private void LogState(Task task)
	{
	}

	private void LogSync(string msg)
	{
	}

	private void LogExample(string msg)
	{
	}
}
