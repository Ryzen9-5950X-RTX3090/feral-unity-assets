namespace UnityAtoms
{
	[EditorIcon("atom-icon-teal")]
	public abstract class AtomBaseVariable : BaseAtom
	{
		public abstract object BaseValue { get; set; }

		public abstract void Reset(bool shouldTriggerEvents = false);
	}
}
