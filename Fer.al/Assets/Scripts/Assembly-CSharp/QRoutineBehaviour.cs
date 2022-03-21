using System;
using System.Collections;
using System.Runtime.InteropServices;

public abstract class QRoutineBehaviour : ManagedBehaviour
{
	private static QRoutineGroup _defaultParentGroup;

	private QRoutineGroup _parentGroup;

	private QRoutineGroup _behaviourGroup;

	private static QRoutineGroup DefaultParentGroup
	{
		get
		{
			return null;
		}
	}

	protected QRoutineGroup ParentGroup
	{
		get
		{
			return null;
		}
	}

	protected QRoutineGroup BehaviourGroup
	{
		get
		{
			return null;
		}
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	private void InitBehaviourGroup()
	{
	}

	private void DeinitBehaviourGroup()
	{
	}

	public QRoutine StartQRoutine(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction)
	{
		return null;
	}

	public virtual QRoutineGroup OverrideParentGroup()
	{
		return null;
	}
}
