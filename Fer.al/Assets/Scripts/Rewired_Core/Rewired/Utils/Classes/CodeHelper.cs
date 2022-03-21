using System.ComponentModel;

namespace Rewired.Utils.Classes
{
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public abstract class CodeHelper
	{
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return null;
		}
	}
}
