using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("System Events")]
	public class CheckMouseClick : ConditionTask<Collider>
	{
		public MouseClickEvent checkType;

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

		private void OnMouseDown(EventData msg)
		{
		}

		private void OnMouseUp(EventData msg)
		{
		}
	}
}
