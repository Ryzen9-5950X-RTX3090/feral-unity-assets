using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IControllerTemplateAxis6D : IControllerTemplateElement
	{
		Vector3 position { get; }

		Vector3 positionPrev { get; }

		Vector3 rotation { get; }

		Vector3 rotationPrev { get; }

		IControllerTemplateAxis positionX { get; }

		IControllerTemplateAxis positionY { get; }

		IControllerTemplateAxis positionZ { get; }

		IControllerTemplateAxis rotationX { get; }

		IControllerTemplateAxis rotationY { get; }

		IControllerTemplateAxis rotationZ { get; }
	}
}
