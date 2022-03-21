using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
[ChartComponent("Property Editor Test")]
public class PropertyEditorTestDefComponent : DefComponent
{
	[Serializable]
	public class ClassEntry
	{
		[ChartDef("Item", new string[] { })]
		public string itemDefID;

		[ChartInt]
		public int count;
	}

	[Serializable]
	public class ClassEntry2
	{
		[ChartDef("Item", new string[] { })]
		public string itemDefID;

		[ChartDef("Item", new string[] { })]
		public string item2DefID;

		[ChartInt]
		public int count;
	}

	[Serializable]
	public class ClassEntry3
	{
		[ChartDef("Item", new string[] { })]
		public string itemDefID;

		[ChartDef("Item", new string[] { })]
		public string item2DefID;

		[ChartList]
		[ChartFloat]
		public List<float> floatArrayTest;
	}

	[Serializable]
	public class LootList
	{
		[ChartList]
		[ChartDef("Loot", new string[] { })]
		public ChartDefList list;
	}

	[ChartDef("CraftableItem", new string[] { })]
	public string refTest;

	[ChartDate]
	public ChartDate chartDateTest;

	[ChartList]
	public List<ClassEntry> classArrayTest;

	[ChartList]
	public List<ClassEntry2> classArrayTest2;

	[ChartList]
	public List<ClassEntry3> classArrayTest3;

	[ChartList]
	[ChartBundle]
	public List<ChartBundle> bundles;

	[ChartList]
	public List<LootList> lootLists;

	[ChartList]
	[ChartDef("Def List", new string[] { })]
	public ChartDefList defList;

	[ChartList]
	[ChartInt]
	public List<int> intTest;

	[ChartList]
	[ChartDef("Localization", new string[] { })]
	public List<string> refArrayTest;

	[ChartList]
	[ChartDef("CraftableItem", new string[] { })]
	public List<string> refArrayTest2;

	[ChartList]
	[ChartColor]
	public List<Color> colorArrayTest;

	[ChartEnum]
	public ItemType enumTest;

	[ChartVector3]
	public Vector3 vector3Test;

	[NonSerialized]
	[ChartButton("ButtonTest", "ButtonTestMethod")]
	public bool buttonTest;

	public void ButtonTestMethod(PropertyEditor.DefEntry inDefEntry)
	{
	}

	protected override void LoadEntry()
	{
	}
}
