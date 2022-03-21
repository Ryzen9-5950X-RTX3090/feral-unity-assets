using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Snaps a tansform to a specified Vector")]
	public class MoveTransform : ActionTask<Transform>
	{
		public BBParameter<Vector3> position;

		public BBParameter<bool> local;

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
