using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("System Events")]
	[Name("Check Mouse 2D", 0)]
	public class CheckMouse2D : ConditionTask<Collider2D>
	{
		public MouseInteractionTypes checkType;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override bool OnCheck()
		{
			return default(bool);
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
