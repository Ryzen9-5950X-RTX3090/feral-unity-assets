using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	public class RotateTransform : ActionTask<Transform>
	{
		public BBParameter<Vector3> minRotation;

		public BBParameter<Vector3> maxRotation;

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
