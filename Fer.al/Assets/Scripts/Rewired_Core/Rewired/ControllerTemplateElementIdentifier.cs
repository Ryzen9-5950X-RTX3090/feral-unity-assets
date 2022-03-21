using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation]
	public class ControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier
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

		[SerializeField]
		[CustomObfuscation]
		private string _negativeName;

		[CustomObfuscation]
		[SerializeField]
		private ControllerTemplateElementType _elementType;

		internal readonly bool isMappableOnPlatform;

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

		public ControllerTemplateElementType elementType
		{
			get
			{
				return default(ControllerTemplateElementType);
			}
		}

		internal virtual bool useEditorElementTypeOverride
		{
			get
			{
				return default(bool);
			}
		}

		internal virtual ControllerElementType editorElementTypeOverride
		{
			get
			{
				return default(ControllerElementType);
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

		public ControllerTemplateElementIdentifier()
		{
		}

		public ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source)
		{
		}

		internal ControllerTemplateElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, bool isMappableOnPlatform)
		{
		}

		internal ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform)
		{
		}

		public virtual ControllerTemplateElementIdentifier Clone()
		{
			return null;
		}

		public string GetDisplayName(AxisRange axisRange)
		{
			return null;
		}

		internal ControllerElementIdentifier ToControllerElementIdentifier()
		{
			return null;
		}
	}
}
