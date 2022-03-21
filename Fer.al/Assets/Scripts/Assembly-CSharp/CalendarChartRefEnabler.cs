using System;
using UnityEngine;

public class CalendarChartRefEnabler : ManagedBehaviour
{
	[Serializable]
	private struct SwappableMaterial
	{
		public MeshRenderer meshRenderer;

		public int materialIndex;

		public Material materialOn;

		public bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		internal void SwapMaterial()
		{
		}
	}

	[SerializeField]
	[Header("Chart")]
	private CalendarChartRef _calendarChartRef;

	[SerializeField]
	[Header("GameObjects to Enable")]
	private GameObject[] enabledOnAvailable;

	[SerializeField]
	private GameObject[] enabledOnUnAvailable;

	[SerializeField]
	[Header("Materials to Swap")]
	[Tooltip("Uses Material On at the Materials Index on the Mesh Renderer when Available")]
	private SwappableMaterial[] materialsOnAvailable;

	public override void MStart()
	{
	}
}
