using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class MazeCellController : MonoBehaviour
	{
		public Color startColor;

		public Color destinationColor;

		private GameObject signHolder;

		private Image image;

		private GameObject top_closed;

		private GameObject top_open;

		private GameObject bottom_closed;

		private GameObject bottom_open;

		private GameObject left_closed;

		private GameObject left_open;

		private GameObject right_closed;

		private GameObject right_open;

		private bool topState;

		private bool bottomState;

		private bool leftState;

		private bool rightState;

		public MazeController.MazeChunk Chunk
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetUp(bool top, bool bottom, bool left, bool right)
		{
		}

		public bool CanEnter(int fromDirection)
		{
			return default(bool);
		}

		public bool CanExit(int toDirection)
		{
			return default(bool);
		}

		public void SetConnection(int direction, bool value)
		{
		}

		public void MakeStart()
		{
		}

		public void MakeDestination()
		{
		}

		private void UpdateVisual()
		{
		}
	}
}
