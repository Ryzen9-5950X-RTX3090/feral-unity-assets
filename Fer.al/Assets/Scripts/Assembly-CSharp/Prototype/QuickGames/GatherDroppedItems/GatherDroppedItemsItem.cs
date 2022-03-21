using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames.GatherDroppedItems
{
	public class GatherDroppedItemsItem : UnityEngine.MonoBehaviour
	{
		internal enum EItemType
		{
			ITEM,
			EMBER,
			RARE
		}

		public RawImage rawImage;

		internal bool gathered;

		internal GatherDroppedItems game;

		internal float lifeSpan;

		internal float fadeOutTime;

		internal EItemType itemType;

		private Transform _trans;

		private float _currentLifeSpan;

		private float _fadeOutTime;

		private Color _transWhite;

		private void Awake()
		{
		}

		internal void ItemUpdate()
		{
		}
	}
}
