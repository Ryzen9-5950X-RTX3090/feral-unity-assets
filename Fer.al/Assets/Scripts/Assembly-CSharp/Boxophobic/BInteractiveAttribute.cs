using UnityEngine;

namespace Boxophobic
{
	public class BInteractiveAttribute : PropertyAttribute
	{
		public int Value;

		public string Keyword;

		public int Type;

		public BInteractiveAttribute(int v)
		{
		}

		public BInteractiveAttribute(string k)
		{
		}
	}
}
