using System;
using System.Collections.Generic;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap, IHardwareControllerTemplateMap_Internal
	{
		[Serializable]
		public sealed class Entry
		{
			public int id;

			public string name;

			public string joystickGuid;

			public string fileGuid;

			public List<ElementIdentifierMap> elementIdentifierMappings;

			public Guid JoystickGuid
			{
				get
				{
					return default(Guid);
				}
			}

			public int GetJoystickElementId(int templateElementId)
			{
				return default(int);
			}

			public int GetTemplateElementId(int joystickElementId)
			{
				return default(int);
			}

			public ElementIdentifierMap GetElementIdentifierMap(int templateId)
			{
				return null;
			}

			public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results)
			{
			}
		}

		[Serializable]
		public sealed class ElementIdentifierMap
		{
			public int templateId;

			public int joystickId;

			public int joystickId2;

			public bool splitAxis;
		}

		[Serializable]
		public sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal
		{
			public int elementIdentifierId;

			public string data;

			T IControllerTemplateMapSpecialElement_Internal.GetMapping<T>()
			{
				return null;
			}
		}

		[SerializeField]
		[CustomObfuscation]
		private string controllerName;

		[CustomObfuscation]
		[SerializeField]
		private string description;

		[SerializeField]
		[CustomObfuscation]
		private string templateGuid;

		[CustomObfuscation]
		[SerializeField]
		private string className;

		[CustomObfuscation]
		[SerializeField]
		private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers;

		[CustomObfuscation]
		[SerializeField]
		private List<Entry> joysticks;

		[CustomObfuscation]
		[SerializeField]
		private SpecialElementEntry[] specialElements;

		[SerializeField]
		[CustomObfuscation]
		private int elementIdentifierIdCounter;

		[CustomObfuscation]
		[SerializeField]
		private int joystickIdCounter;

		public override Guid Guid
		{
			get
			{
				return default(Guid);
			}
		}

		public string ControllerName
		{
			get
			{
				return null;
			}
		}

		public string ClassName
		{
			get
			{
				return null;
			}
		}

		public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers
		{
			get
			{
				return null;
			}
		}

		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers
		{
			get
			{
				return null;
			}
		}

		string IHardwareControllerTemplateMap_Internal.name
		{
			get
			{
				return null;
			}
		}

		Guid IHardwareControllerTemplateMap_Internal.typeGuid
		{
			get
			{
				return default(Guid);
			}
		}

		[CustomObfuscation]
		public ControllerTemplateElementIdentifier GetElementIdentifier(int id)
		{
			return null;
		}

		[CustomObfuscation]
		public bool ContainsElementIdentifier(int id)
		{
			return default(bool);
		}

		[CustomObfuscation]
		public string[] GetElementIdentifierNames()
		{
			return null;
		}

		[CustomObfuscation]
		public int[] GetElementIdentifierIds()
		{
			return null;
		}

		[CustomObfuscation]
		internal string[] GetElementIdentifierScriptingNames(bool useAlternate)
		{
			return null;
		}

		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			return default(int);
		}

		public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			return default(int);
		}

		public string[] GetJoystickNames()
		{
			return null;
		}

		public int[] GetJoystickIds()
		{
			return null;
		}

		public Guid GetJoystickGuid(int joystickId)
		{
			return default(Guid);
		}

		public int GetJoystickId(Guid guid)
		{
			return default(int);
		}

		public string GetJoystickFileGuidString(int joystickId)
		{
			return null;
		}

		internal bool iXNzOHrDumSJyUklTiUZNlpYydh(ControllerMap_Editor P_0, HardwareJoystickMap P_1, Guid P_2, out string P_3)
		{
			return default(bool);
		}

		internal ControllerTemplateElementIdentifier mNzVFAiBNOihmCachBdGDRiTVUg(Guid P_0, int P_1)
		{
			return null;
		}

		[CustomObfuscation]
		internal SpecialElementEntry[] GetSpecialElementsOrig()
		{
			return null;
		}

		private Entry uDGNCWGQfmuhvDHBSxGtBouWbNb(Guid P_0)
		{
			return null;
		}

		private int BjoajNIhtXiBdWdIfIGbFKqwmvy(int P_0)
		{
			return default(int);
		}

		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int P_0)
		{
			return null;
		}

		int IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount()
		{
			return default(int);
		}

		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int P_0)
		{
			return null;
		}

		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int P_0)
		{
			return null;
		}

		IControllerTemplateMapSpecialElement_Internal IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int P_0)
		{
			return null;
		}

		oDhSVhqolYnpfNXmoDZvnEklacS IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller P_0, int P_1)
		{
			return null;
		}

		oDhSVhqolYnpfNXmoDZvnEklacS IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller P_0, int P_1)
		{
			return null;
		}
	}
}
