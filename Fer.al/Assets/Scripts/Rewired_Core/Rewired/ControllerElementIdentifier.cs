using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation]
	public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal
	{
		[CustomObfuscation]
		[SerializeField]
		private int _id;

		[SerializeField]
		[CustomObfuscation]
		private string _name;

		[CustomObfuscation]
		[SerializeField]
		private string _positiveName;

		[CustomObfuscation]
		[SerializeField]
		private string _negativeName;

		[CustomObfuscation]
		[SerializeField]
		private ControllerElementType _elementType;

		[SerializeField]
		[CustomObfuscation]
		private CompoundControllerElementType _compoundElementType;

		internal readonly bool isMappableOnPlatform;

		private bool wKnBnddjnLGpvWTmfpNbnnIJgPbb;

		private static ControllerElementIdentifier mBDxCiUDRMjvJkDBGqxtRRiEPdx;

		public int id
		{
			get
			{
				return default(int);
			}
		}

		public string name
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string positiveName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string negativeName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public ControllerElementType elementType
		{
			get
			{
				return default(ControllerElementType);
			}
		}

		public CompoundControllerElementType compoundElementType
		{
			get
			{
				return default(CompoundControllerElementType);
			}
		}

		internal bool isCompoundElement
		{
			get
			{
				return default(bool);
			}
		}

		object IControllerElementIdentifierCommon_Internal.elementType
		{
			get
			{
				return null;
			}
		}

		bool IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride
		{
			get
			{
				return default(bool);
			}
		}

		ControllerElementType IControllerElementIdentifierCommon_Internal.editorElementTypeOverride
		{
			get
			{
				return default(ControllerElementType);
			}
		}

		internal static ControllerElementIdentifier BlankReadOnly
		{
			get
			{
				return null;
			}
		}

		public ControllerElementIdentifier()
		{
		}

		public ControllerElementIdentifier(ControllerElementIdentifier source)
		{
		}

		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, CompoundControllerElementType compoundElementType, bool isMappableOnPlatform)
		{
		}

		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, bool isMappableOnPlatform)
		{
		}

		internal ControllerElementIdentifier(ControllerElementIdentifier source, bool isMappableOnPlatform, ControllerElementType changedElementType)
		{
		}

		public ControllerElementIdentifier Clone()
		{
			return null;
		}

		public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange)
		{
			return null;
		}

		public string GetDisplayName(AxisRange axisRange)
		{
			return null;
		}

		private void YZoTVTEKTyqqaeRvObnTHvRkCGZx()
		{
		}
	}
}
