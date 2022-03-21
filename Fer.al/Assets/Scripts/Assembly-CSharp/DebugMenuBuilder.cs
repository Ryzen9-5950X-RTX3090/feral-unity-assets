using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public class DebugMenuBuilder
{
	private enum DMC
	{
		BeginSection,
		EndSection,
		BeginVertical,
		EndVertical,
		BeginHorizontal,
		EndHorizontal,
		BeginCollapse,
		EndCollapse,
		CreateTab,
		NavigateToTab,
		Button,
		Text,
		Input,
		Toggle
	}

	private class DMI
	{
		public DMC command;

		public int iArg1;

		public string sArg1;

		public bool bArg1;

		public Action actionArg1;

		public Func<string> sGetterArg1;

		public Action<string> sSetterArg1;

		public Func<bool> bGetterArg1;

		public Action<bool> bSetterArg1;

		public string id;
	}

	private List<DMI> instructions;

	public DebugMenuBuilder Begin()
	{
		return null;
	}

	public void Complete()
	{
	}

	public DebugMenuBuilder Tab(string title)
	{
		return null;
	}

	public DebugMenuBuilder SwitchTab(int tabIndex)
	{
		return null;
	}

	public DebugMenuBuilder Section(string title, [Optional] string id)
	{
		return null;
	}

	public DebugMenuBuilder SectionEnd()
	{
		return null;
	}

	public DebugMenuBuilder HGroup([Optional] string id)
	{
		return null;
	}

	public DebugMenuBuilder HGroupEnd()
	{
		return null;
	}

	public DebugMenuBuilder VGroup([Optional] string id)
	{
		return null;
	}

	public DebugMenuBuilder VGroupEnd()
	{
		return null;
	}

	public DebugMenuBuilder Collapse(string title, bool startOpen = false, [Optional] string id)
	{
		return null;
	}

	public DebugMenuBuilder CollapseEnd()
	{
		return null;
	}

	public DebugMenuBuilder Text(string text, [Optional] Func<string> getter, [Optional] string id)
	{
		return null;
	}

	public DebugMenuBuilder Input([Optional] Func<string> getter, [Optional] Action<string> setter, [Optional] string id)
	{
		return null;
	}

	public DebugMenuBuilder Button([Optional] string text, [Optional] Action action, [Optional] string id)
	{
		return null;
	}

	public DebugMenuBuilder Toggle([Optional] string text, [Optional] Func<bool> getter, [Optional] Action<bool> setter, [Optional] string id)
	{
		return null;
	}
}
