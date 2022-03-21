using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	[ExecuteInEditMode]
	[RenderHierarchyIcon("Assets/StrayTech/Camera System/Graphics/Trigger.png")]
	public abstract class CameraSystemTriggerBase : MonoBehaviour
	{
		public enum TriggerColliderType
		{
			Box,
			Sphere,
			ConvexMesh
		}

		[SerializeField]
		[Tooltip("The type of collider to use.")]
		private TriggerColliderType _triggerColliderType;

		[SerializeField]
		[Tooltip("Mesh for Convex Mesh collider trigger.")]
		private Mesh _mesh;

		[SerializeField]
		[Tooltip("The color of the volume in the editor.")]
		private Color _volumeColor;

		[SerializeField]
		[Tooltip("Should this volume render as a solid in editor?")]
		private bool _renderSolidVolume;

		[SerializeField]
		[Tooltip("Render volume only when selected?")]
		private bool _renderOnlyWhenSelected;

		[SerializeField]
		[Tooltip("Filter collision by tag? (Blank means no tag filter)")]
		protected string _tagFilter;

		[SerializeField]
		[Tooltip("The layers that will trigger the volume.")]
		protected LayerMask _layerMask;

		[SerializeField]
		[Tooltip("Use once then disable.")]
		protected bool _singleUseTrigger;

		private bool _triggerEnabled;

		private Collider _collider;

		private List<ITriggerGate> _triggerGates;

		private bool _didTrigger;

		private void Start()
		{
		}

		protected abstract void TriggerEntered();

		protected abstract void TriggerExited();

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		[IteratorStateMachine(typeof(<SpinOnGatedEnter>d__18))]
		private IEnumerator SpinOnGatedEnter()
		{
			return null;
		}

		private bool IsTriggerGated()
		{
			return default(bool);
		}

		private bool IsTriggerBlocked()
		{
			return default(bool);
		}

		private void OnDestroy()
		{
		}
	}
}
