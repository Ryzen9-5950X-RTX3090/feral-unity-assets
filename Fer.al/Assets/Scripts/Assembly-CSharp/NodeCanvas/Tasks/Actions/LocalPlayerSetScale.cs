using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Sets the local player's scale")]
	public class LocalPlayerSetScale : ActionTask<Transform>
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
