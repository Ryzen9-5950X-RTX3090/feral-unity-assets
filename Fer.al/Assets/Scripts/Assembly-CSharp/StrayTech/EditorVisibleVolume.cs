using UnityEngine;

namespace StrayTech
{
	[RequireComponent(typeof(BoxCollider))]
	public class EditorVisibleVolume : MonoBehaviour
	{
		[SerializeField]
		private Color _volumeColor;

		[SerializeField]
		private bool _shouldRender;

		[SerializeField]
		private bool _shouldRenderOnlyWhenSelected;

		private BoxCollider _collider;

		public Color VolumeColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}
	}
}
