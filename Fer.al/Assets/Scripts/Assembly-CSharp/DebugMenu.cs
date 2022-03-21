using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class DebugMenu : MonoBehaviour
{
	private class TextPair
	{
		public Text text;

		public Func<string> getter;

		public void UpdateText()
		{
		}
	}

	private class InputPair
	{
		public InputField input;

		public Func<string> getter;

		public Action<string> setter;

		public void UpdateText()
		{
		}

		public void OnChange(string value)
		{
		}
	}

	private class TogglePair
	{
		public Toggle toggle;

		public Func<bool> getter;

		public Action<bool> setter;

		public void UpdateState()
		{
		}

		public void OnChange(bool value)
		{
		}
	}

	private class CollapsePair
	{
		public GameObject content;

		public Toggle toggle;

		public static CollapsePair Create(GameObject collapseGroup, [Optional] string title, bool open = false)
		{
			return null;
		}

		public void UpdateState()
		{
		}
	}

	private class InstructionPair
	{
		public DMInstruction instruction;

		public List<DMInstruction> parentList;
	}

	public GameObject canvasPrefab;

	public GameObject panelPrefab;

	public GameObject tabsHolderPrefab;

	public GameObject sectionPanelPrefab;

	public GameObject collapseGroupPrefab;

	public GameObject scrollViewPrefab;

	public GameObject buttonPrefab;

	public GameObject inputPrefab;

	public GameObject togglePrefab;

	public GameObject textPrefab;

	public GameObject tabBarPrefab;

	public GameObject tabButtonPrefab;

	private GameObject eventSystem;

	private GameObject panel;

	private GameObject scrollView;

	private GameObject content;

	private GameObject tabBar;

	private GameObject tabsHolder;

	private List<GameObject> tabButtons;

	private List<GameObject> tabPanels;

	private List<DMInstruction> instructions;

	private List<List<DMInstruction>> tabInstructionMap;

	private List<TextPair> textPairs;

	private List<TogglePair> togglePairs;

	private List<InputPair> inputPairs;

	private List<CollapsePair> collapsePairs;

	private List<InstructionPair> identifiables;

	private List<string> parentIDs;

	private int tabIndex;

	private bool invalidated;

	private bool initialized;

	private int idCount;

	private static DebugMenu debugMenu;

	public static DebugMenu Instance
	{
		get
		{
			return null;
		}
	}

	public static void Button([Optional] string text, [Optional] Action onClick, [Optional] string id)
	{
	}

	public static void Text([Optional] string text, [Optional] Func<string> getter, [Optional] string id)
	{
	}

	public static void Input([Optional] Func<string> getter, [Optional] Action<string> setter, [Optional] string id)
	{
	}

	public static void Toggle([Optional] string text, [Optional] Func<bool> getter, [Optional] Action<bool> setter, [Optional] string id)
	{
	}

	public static void BeginSection([Optional] string title, [Optional] string id)
	{
	}

	public static void EndSection()
	{
	}

	public static void BeginHorizontal([Optional] string id)
	{
	}

	public static void BeginVertical([Optional] string id)
	{
	}

	public static void EndHorizontal()
	{
	}

	public static void EndVertical()
	{
	}

	public static void BeginCollapse([Optional] string title, bool startOpen = false, [Optional] string id)
	{
	}

	public static void EndCollapse()
	{
	}

	public static void CreateTab(string tabName)
	{
	}

	public static void NavigateToTab(int tabIndex)
	{
	}

	public static void ChangeTab(int tabIndex)
	{
	}

	public static void Remove(string id)
	{
	}

	private void Update()
	{
	}

	public void Poke()
	{
	}

	public void Init()
	{
	}

	private void CreateTabPanel(string panelName)
	{
	}

	public void TabChange(int tab)
	{
	}

	[IteratorStateMachine(typeof(<FancyTabSwitch>d__56))]
	public IEnumerator FancyTabSwitch(int tab)
	{
		return null;
	}

	public void SwitchTab(int tab)
	{
	}

	public void Add(DMInstruction instruction)
	{
	}

	public void AddButton([Optional] string text, [Optional] Action onClick, [Optional] string id)
	{
	}

	public void AddText([Optional] string text, [Optional] Func<string> getter, [Optional] string id)
	{
	}

	public void AddInput([Optional] Func<string> getter, [Optional] Action<string> setter, [Optional] string id)
	{
	}

	public void AddToggle([Optional] string text, [Optional] Func<bool> getter, [Optional] Action<bool> setter, [Optional] string id)
	{
	}

	public void Section(bool start, [Optional] string title, [Optional] string id)
	{
	}

	public void Collapse(bool start, [Optional] string title, bool open = false, [Optional] string id)
	{
	}

	public void Group(bool start, int direction, [Optional] string id)
	{
	}

	public void Construct()
	{
	}

	[IteratorStateMachine(typeof(<FadeCanvasGroup>d__67))]
	private IEnumerator FadeCanvasGroup(CanvasGroup group, float targetAlpha, float duration)
	{
		return null;
	}

	public string GetNewID()
	{
		return null;
	}

	public void RemoveElement(string id)
	{
	}
}
