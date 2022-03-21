using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Audio/Volumes/VA Path")]
public class VA_Path : VA_Shape
{
	[Tooltip("The local space points for the path")]
	public List<Vector3> Points;

	protected override void LateUpdate()
	{
	}
}
