using System;
using System.Collections;

public struct StartQRoutineOptions
{
	public string name;

	public QRoutineAddPriority addPriority;

	public IEnumerator routine;

	public Action<QRoutine> action;

	public Action<QRoutine> finishedAction;

	public Action<QRoutine> canceledAction;
}
