using UnityEngine;

namespace StrayTech.CustomAttributes
{
	public class UneditableAttribute : PropertyAttribute
	{
		public enum Effective
		{
			Always,
			OnlyWhilePlaying,
			OnlyWhileEditing
		}

		public readonly Effective EffectiveWhen;

		public UneditableAttribute()
		{
		}

		public UneditableAttribute(Effective effectiveWhen)
		{
		}
	}
}
