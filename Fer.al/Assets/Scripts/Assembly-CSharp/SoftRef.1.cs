public abstract class SoftRef<T> where T : ISoftReferable
{
	private T _ref;

	public T Ref
	{
		get
		{
			return (T)null;
		}
		protected set
		{
		}
	}

	protected abstract void UpdateRef();
}
