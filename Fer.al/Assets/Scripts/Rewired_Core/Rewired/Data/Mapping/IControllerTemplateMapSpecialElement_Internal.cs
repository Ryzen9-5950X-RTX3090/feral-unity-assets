namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IControllerTemplateMapSpecialElement_Internal
	{
		T GetMapping<T>() where T : ControllerTemplateSpecialElementMapping;
	}
}
