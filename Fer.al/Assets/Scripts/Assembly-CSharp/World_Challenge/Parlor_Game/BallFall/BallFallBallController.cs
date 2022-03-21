using System.Runtime.CompilerServices;
using UnityEngine;

namespace World_Challenge.Parlor_Game.BallFall
{
	public class BallFallBallController : MonoBehaviour
	{
		private bool hasEnteredTrigger;

		public BallFallController ParentController
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

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
