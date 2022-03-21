using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class CatchTargetController : MonoBehaviour
	{
		public int value;

		private CoinCatch parentController;

		public bool IsAlive
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

		public void SetUp(CoinCatch parent, float xPos, float yPos, Vector2 force)
		{
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		public void Kill()
		{
		}
	}
}
