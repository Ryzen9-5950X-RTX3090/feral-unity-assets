using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetVector3VariableValue : SetVariableValue<Vector3, Vector3Variable, Vector3Constant, Vector3Reference, Vector3Event, Vector3Vector3Event>
	{
	}
}
