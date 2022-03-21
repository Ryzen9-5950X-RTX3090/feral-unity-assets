namespace Rewired.Interfaces
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal
	{
		new ControllerTemplateElementType elementType { get; }
	}
}
