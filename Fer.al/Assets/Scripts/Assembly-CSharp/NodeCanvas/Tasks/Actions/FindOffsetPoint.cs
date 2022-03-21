using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Player")]
	[Description("Finds a point at the specified offset of the local player, and snaps the specified transform to it.")]
	public class FindOffsetPoint : ActionTask<Transform>
	{
		public BBParameter<Vector3> offsetPoint;

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
	}
}
