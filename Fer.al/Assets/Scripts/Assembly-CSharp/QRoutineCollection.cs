using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class QRoutineCollection
{
	public bool verbose;

	private bool _useProgressScreen;

	private string _progressLabel;

	protected List<QRoutine> _qroutines;

	public bool UseProgressScreen
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public string ProgressLabel
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool HasQRoutines
	{
		get
		{
			return default(bool);
		}
	}

	public QRoutine Add(QRoutine inQRoutine)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<WaitForQRoutines>d__13))]
	public IEnumerator WaitForQRoutines()
	{
		return null;
	}
}
