using System;
using System.Collections.Generic;
using Rewired.Utils.Attributes;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation]
	public sealed class CustomControllerElementSelector
	{
		[CustomObfuscation]
		public enum ElementType
		{
			Axis,
			Button
		}

		[CustomObfuscation]
		public enum SelectorType
		{
			Name,
			Index,
			Id
		}

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The target Custom Controller element type.")]
		private ElementType _elementType;

		[SerializeField]
		[CustomObfuscation]
		[Tooltip("The method to use to look up the target Custom Controller element.")]
		private SelectorType _selectorType;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The target Custom Controller element name.")]
		private string _elementName;

		[CustomObfuscation]
		[SerializeField]
		[Tooltip("The target Custom Controller element index.")]
		[FieldRange(-1, int.MaxValue)]
		private int _elementIndex;

		[CustomObfuscation]
		[SerializeField]
		[FieldRange(-1, int.MaxValue)]
		[Tooltip("The target Custom Controller element id.")]
		private int _elementId;

		[HideInInspector]
		private int IiqJkCxIiWfCtapWlzauQkrlOjpo;

		[HideInInspector]
		private int AmbMBiIfojcLTIXgvVqpPfJzIDqU;

		public ElementType elementType
		{
			get
			{
				return default(ElementType);
			}
			set
			{
			}
		}

		public SelectorType selectorType
		{
			get
			{
				return default(SelectorType);
			}
			set
			{
			}
		}

		public string elementName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int elementIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int elementId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool isAssigned
		{
			get
			{
				return default(bool);
			}
		}

		public int GetElementIndex(Rewired.CustomController customController)
		{
			return default(int);
		}

		public string GetSelectorFormattedString()
		{
			return null;
		}

		private IList<ControllerElementIdentifier> ZMiPycAGpOQhySHUZaTcPLozIgK(Rewired.CustomController P_0, ElementType P_1)
		{
			return null;
		}

		public void ClearCache()
		{
		}
	}
}
