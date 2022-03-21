using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class MatchThreeCursorController : MonoBehaviour
	{
		public int direction;

		private float offsetX;

		private float offsetY;

		private float cellWidth;

		private float cellHeight;

		private int xMax;

		private int yMax;

		private GameObject horizontal;

		private GameObject vertical;

		private RectTransform rectTransform;

		private Image hImage;

		private Image vImage;

		public int X
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int Y
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void Initialize(int startX, int startY, int xMax, int yMax, float offsetX, float offsetY, float cellWidth, float cellHeight)
		{
		}

		private void UpdateDirection(int dir)
		{
		}

		private void UpdateGraphic(bool move, bool rotate)
		{
		}

		public void FlipCursor()
		{
		}

		public void TryMove(int dx, int dy)
		{
		}

		public int[] GetSelectedIndices()
		{
			return null;
		}
	}
}
