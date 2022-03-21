namespace Lean.Pool
{
	public interface IPoolable
	{
		void OnSpawn();

		void OnDespawn();
	}
}
