using System;
using Rewired.Interfaces;

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IHardwareControllerTemplateMap_Internal
	{
		string name { get; }

		Guid typeGuid { get; }

		int GetElementIdentifierCount();

		IControllerTemplateElementIdentifier GetTemplateElementIdentifier(int index);

		IControllerTemplateElementIdentifier GetTemplateElementIdentifierById(int elementIdentifierId);

		IControllerTemplateMapSpecialElement_Internal GetSpecialTemplateElementByElementIdentifierId(int id);

		oDhSVhqolYnpfNXmoDZvnEklacS GetAxisTarget(Controller controller, int elementIdentifierId);

		oDhSVhqolYnpfNXmoDZvnEklacS GetButtonTarget(Controller controller, int elementIdentifierId);
	}
}
