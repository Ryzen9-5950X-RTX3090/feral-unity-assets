using UnityEngine;

namespace Candlelight
{
	public abstract class IdentifiableBackingFieldCompatibleObjectWrapper : BackingFieldCompatibleObject
	{
		public enum InspectorDisplayMode
		{
			MultiLine,
			SingleLine,
			IdentifierOnly
		}

		protected virtual GUIContent DataLabel
		{
			get
			{
				return null;
			}
		}

		protected virtual PropertyAttribute DataPropertyAttribute
		{
			get
			{
				return null;
			}
		}

		protected virtual GUIContent IdentifierLabel
		{
			get
			{
				return null;
			}
		}

		protected virtual PropertyAttribute IdentifierPropertyAttribute
		{
			get
			{
				return null;
			}
		}

		protected virtual InspectorDisplayMode DisplayMode
		{
			get
			{
				return default(InspectorDisplayMode);
			}
		}
	}
}
