using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("System Events")]
	public class CheckMouse : ConditionTask<Collider>
	{
		public MouseInteractionTypes checkType;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void OnMouseEnter(EventData msg)
		{
		}

		private void OnMouseExit(EventData msg)
		{
		}

		private void OnMouseOver(EventData msg)
		{
		}
	}
}
