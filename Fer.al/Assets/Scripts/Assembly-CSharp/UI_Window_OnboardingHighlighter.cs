using UnityEngine;

public class UI_Window_OnboardingHighlighter : UI_Window
{
	private OnboardingHighlightTargetId _currentTarget;

	private Transform _previousTargetParent;

	private int _previousSiblingIndex;

	public static void Highlight(OnboardingHighlightTargetId inTarget)
	{
	}

	private void DoHighlight(OnboardingHighlightTargetId inTarget)
	{
	}

	private void ReleaseCurrentHighlight()
	{
	}

	private void CaptureCurrentHighlight()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}
}
