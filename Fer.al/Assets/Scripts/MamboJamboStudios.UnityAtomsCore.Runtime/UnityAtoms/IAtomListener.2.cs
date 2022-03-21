namespace UnityAtoms
{
	public interface IAtomListener<T1, T2>
	{
		void OnEventRaised(T1 first, T2 second);
	}
}
