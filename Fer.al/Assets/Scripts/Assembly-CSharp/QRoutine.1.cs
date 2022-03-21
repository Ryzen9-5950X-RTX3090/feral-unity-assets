public class QRoutine<T> : QRoutine
{
	private T _result;

	public new T Result
	{
		get
		{
			return (T)null;
		}
	}

	protected override bool IsResultYield(object inCurrent)
	{
		return default(bool);
	}

	protected override void OnResultYield(object inCurrent)
	{
	}
}
