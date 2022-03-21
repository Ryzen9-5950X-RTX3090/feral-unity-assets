using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal sealed class ControllerTemplateElementIdentifier_Editor : ControllerTemplateElementIdentifier, IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier, IControllerTemplateElementIdentifier_Editor
	{
		[SerializeField]
		[CustomObfuscation]
		private string _scriptingName;

		[SerializeField]
		[CustomObfuscation]
		private string _alternateScriptingName;

		[CustomObfuscation]
		[SerializeField]
		private bool _excludeFromExport;

		[SerializeField]
		[CustomObfuscation]
		private bool _useEditorElementTypeOverride;

		[SerializeField]
		[CustomObfuscation]
		private ControllerElementType _editorElementTypeOverride;

		internal string scriptingName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal string alternateScriptingName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal bool excludeFromExport
		{
			get
			{
				return default(bool);
			}
		}

		internal override bool useEditorElementTypeOverride
		{
			get
			{
				return default(bool);
			}
		}

		internal override ControllerElementType editorElementTypeOverride
		{
			get
			{
				return default(ControllerElementType);
			}
		}

		internal ControllerTemplateElementType effectiveElementType
		{
			get
			{
				return default(ControllerTemplateElementType);
			}
		}

		string IControllerTemplateElementIdentifier_Editor.scriptingName
		{
			get
			{
				return null;
			}
		}

		string IControllerTemplateElementIdentifier_Editor.alternateScriptingName
		{
			get
			{
				return null;
			}
		}

		public ControllerTemplateElementIdentifier_Editor()
		{
		}

		public ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source)
		{
		}

		internal ControllerTemplateElementIdentifier_Editor(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, string scriptingName, string alternateScriptingName, bool excludeFromExport, bool useEditorElementTypeOverride, ControllerElementType editorElementTypeOverride, bool isMappableOnPlatform)
		{
		}

		internal ControllerTemplateElementIdentifier_Editor(ControllerTemplateElementIdentifier_Editor source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform)
		{
		}

		public override ControllerTemplateElementIdentifier Clone()
		{
			return null;
		}
	}
}
