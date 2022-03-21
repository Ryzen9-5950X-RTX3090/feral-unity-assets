using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Sets a transforms scale")]
	public class TransformSetScale : ActionTask<Transform>
	{
		public BBParameter<Vector3> scale;

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
