using System;
using UnityEngine;

public class DMInstruction
{
	public static int CREATE;

	public static int GROUP;

	public static int UNGROUP;

	public static int SECTION;

	public static int UNSECTION;

	public static int COLLAPSE;

	public static int UNCOLLAPSE;

	public static int HORIZONTAL;

	public static int VERTICAL;

	public static int TEXT;

	public static int INPUT;

	public static int BUTTON;

	public static int TOGGLE;

	public int action;

	public GameObject prefab;

	public int type;

	public int direction;

	public Action onClick;

	public Func<string> sGetter;

	public Action<string> sSetter;

	public Func<bool> bGetter;

	public Action<bool> bSetter;

	public string text;

	public string title;

	public bool open;

	public string id;

	public string parentId;

	public bool isParent;

	public bool isParentEnd;
}
