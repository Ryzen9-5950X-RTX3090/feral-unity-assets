public class CoreManagerBase<T> : ManagerBase where T : CoreManagerBase<T>
{
	[SetInstance]
	public static T coreInstance;
}
