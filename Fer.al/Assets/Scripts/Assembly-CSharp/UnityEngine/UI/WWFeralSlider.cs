namespace UnityEngine.UI
{
	public class WWFeralSlider : Slider
	{
		[SerializeField]
		private UI_ToggleButtonGraphic.ToggleGraphic[] _toggleGraphics;

		[SerializeField]
		private UI_ToggleButtonGraphic.ToggleCanvasGroup[] _toggleGroups;

		[SerializeField]
		private UI_ToggleButtonGraphic.ToggleUIEffect[] _toggleEffects;

		protected override void OnEnable()
		{
		}

		protected override void DoStateTransition(SelectionState state, bool instant)
		{
		}

		protected virtual void Refresh(SelectionState inState)
		{
		}
	}
}
