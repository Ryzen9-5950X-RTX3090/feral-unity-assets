public class SingletonManagedBehaviour<T> : ManagedBehaviour where T : SingletonManagedBehaviour<T>
{
	protected static T _instance;

	public static T instance
	{
		get
		{
			return null;
		}
	}

	public override void SetInstanceInternal()
	{
	}

	public override void UnsetInstanceInternal()
	{
	}
}
