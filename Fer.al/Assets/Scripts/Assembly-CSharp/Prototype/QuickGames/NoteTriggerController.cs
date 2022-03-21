using System.Runtime.CompilerServices;
using UnityEngine;

namespace Prototype.QuickGames
{
	public class NoteTriggerController : MonoBehaviour
	{
		public int level;

		public PianoKeyboardController ParentController
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

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}
	}
}
