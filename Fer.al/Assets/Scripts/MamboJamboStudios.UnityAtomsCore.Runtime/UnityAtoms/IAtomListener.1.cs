namespace UnityAtoms
{
	public interface IAtomListener<T>
	{
		void OnEventRaised(T item);
	}
}
