public class PersistentService<T> : SingletonManagedBehaviour<T> where T : PersistentService<T>
{
	private bool _dirty;

	public bool Dirty
	{
		get
		{
			return default(bool);
		}
	}

	public override void SetInstanceInternal()
	{
	}

	public override void UnsetInstanceInternal()
	{
	}

	public bool SetClean()
	{
		return default(bool);
	}

	public bool SetDirty()
	{
		return default(bool);
	}

	private void OnConnectionLost(PersistentServiceConnectionLostMessage msg)
	{
	}
}
