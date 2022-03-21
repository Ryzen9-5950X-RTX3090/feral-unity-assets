using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IControllerTemplateAxis3D : IControllerTemplateElement
	{
		Vector3 value { get; }

		Vector3 valuePrev { get; }

		IControllerTemplateAxis horizontal { get; }

		IControllerTemplateAxis vertical { get; }

		IControllerTemplateAxis depth { get; }
	}
}
