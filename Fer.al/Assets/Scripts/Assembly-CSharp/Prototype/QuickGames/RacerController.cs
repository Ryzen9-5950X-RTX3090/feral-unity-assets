using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Prototype.QuickGames
{
	public class RacerController : MonoBehaviour
	{
		public List<Sprite> sprites;

		public bool manualControl;

		public int updateCount;

		private int spriteIndex;

		private int uC;

		private Image image;

		private RectTransform rectTransform;

		private bool leftPressed;

		private bool rightPressed;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
