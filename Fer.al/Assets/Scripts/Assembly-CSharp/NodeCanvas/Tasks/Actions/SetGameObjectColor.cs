using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/GameObject")]
	[Description("Set color on referenced gameObject material")]
	public class SetGameObjectColor : ActionTask
	{
		public BBParameter<GameObject> reference;

		public BBParameter<string> colorProperty;

		public BBParameter<Color> color;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override string OnInit()
		{
			return null;
		}

		protected override void OnExecute()
		{
		}
	}
}
