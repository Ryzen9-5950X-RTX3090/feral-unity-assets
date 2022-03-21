namespace ParadoxNotion.Serialization.FullSerializer
{
	public interface IMigratable<T> : IMigratable
	{
		void Migrate(T model);
	}
}
