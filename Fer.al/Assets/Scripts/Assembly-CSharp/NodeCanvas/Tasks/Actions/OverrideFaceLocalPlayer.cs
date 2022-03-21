using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Override Face Local Player")]
	public class OverrideFaceLocalPlayer : ActionTask<Transform>
	{
		public enum ELookAtType
		{
			Target,
			LocalPlayer,
			Disabled
		}

		public ELookAtType lookAtType;

		[ShowIf("lookAtType", 0)]
		public BBParameter<Transform> lookAt;

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
