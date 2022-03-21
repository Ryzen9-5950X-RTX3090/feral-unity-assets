using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Interactable")]
	[Description("Sets or clears an interactables continuous harvest flag")]
	public class SetInteractableContinuousHarvest : ActionTask
	{
		public Interactable[] interactables;

		public bool enable;

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
