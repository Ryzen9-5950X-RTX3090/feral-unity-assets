using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class PotionMixingBottleController : MonoBehaviour
	{
		public bool isTop;

		private string layerName;

		private Color color;

		private PotionMixingController parentController;

		private float elapsedTime;

		private float waitTime;

		public bool IsFull
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public void SetUp(string layer, Color color, PotionMixingController parentController)
		{
		}

		private void Update()
		{
		}
	}
}
