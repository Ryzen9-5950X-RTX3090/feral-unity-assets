using UnityEngine;

namespace StrayTech.CustomAttributes
{
	public class Helpbox : PropertyAttribute, IValidates
	{
		public enum Type
		{
			Info,
			Warning,
			Error
		}

		public readonly Type MessageType;

		public readonly string Message;

		public Helpbox(string message, Type displayType = Type.Info)
		{
		}

		public bool IsValid()
		{
			return default(bool);
		}
	}
}
