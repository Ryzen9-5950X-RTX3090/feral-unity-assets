using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype
{
	public class CraftInspiration : Interactable
	{
		[SerializeField]
		private MeshRenderer _meshRenderer;

		private string _inspirationDefId;

		private InspirationDefComponent _inspirationDef;

		[HideInInspector]
		public string texturePath;

		private static CraftInspiration _craftInspiration;

		public InspirationDefComponent inspirationDef
		{
			get
			{
				return null;
			}
		}

		public static CraftInspiration Get()
		{
			return null;
		}

		public void Setup(string inInspirationDefId)
		{
		}

		public override void MStart()
		{
		}

		[IteratorStateMachine(typeof(<SetInteractionAllow>d__10))]
		private IEnumerator SetInteractionAllow()
		{
			return null;
		}

		public void Collect()
		{
		}

		[IteratorStateMachine(typeof(<GetTextureRoutine>d__12))]
		private IEnumerator GetTextureRoutine()
		{
			return null;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
