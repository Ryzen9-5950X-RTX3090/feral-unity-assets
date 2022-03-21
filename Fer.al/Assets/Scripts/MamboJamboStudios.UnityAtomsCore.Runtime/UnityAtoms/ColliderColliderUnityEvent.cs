using System;
using UnityEngine;
using UnityEngine.Events;

namespace UnityAtoms
{
	[Serializable]
	public sealed class ColliderColliderUnityEvent : UnityEvent<Collider, Collider>
	{
	}
}
