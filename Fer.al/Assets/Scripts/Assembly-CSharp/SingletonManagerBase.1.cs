public abstract class SingletonManagerBase<T> : ManagerBase where T : SingletonManagerBase<T>
{
	[SetInstance]
	public static T instance;
}
