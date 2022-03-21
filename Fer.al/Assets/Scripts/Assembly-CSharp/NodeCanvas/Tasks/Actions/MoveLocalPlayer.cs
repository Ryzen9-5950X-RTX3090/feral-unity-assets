using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Player")]
	[Description("Snaps local player to a transforms position and rotation.")]
	public class MoveLocalPlayer : ActionTask<Transform>
	{
		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<Move>d__3))]
		private IEnumerator Move()
		{
			return null;
		}
	}
}
