using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class UI_TabStop : ManagedBehaviour
{
	[Serializable]
	public enum NavigationMode
	{
		Vertical,
		Horizontal,
		Manual
	}

	private static bool _hasTabbed;

	public NavigationMode navigation;

	public Selectable manualPrevious;

	public List<Selectable> manualPreviousCandidates;

	public Selectable manualNext;

	public List<Selectable> manualNextCandidates;

	private Selectable _selectable;

	public override void MOnEnable()
	{
	}

	public override void MUpdate()
	{
	}

	private Selectable PickFromCandidates(List<Selectable> inCandidates)
	{
		return null;
	}

	private void LateUpdate()
	{
	}
}
