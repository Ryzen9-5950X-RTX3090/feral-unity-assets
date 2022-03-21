using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CSVReaderItemBase
{
	private Dictionary<string, int> columnNameIndex;

	private string[] dataArray;

	[NonSerialized]
	public string sheetKey;

	public void Init(Dictionary<string, int> inColumnNameIndex, string[] inDataArray)
	{
	}

	public virtual void LoadEntry()
	{
	}

	public string LoadString(string inCategory, string defaultValue = "Missing")
	{
		return null;
	}

	public long LoadDate(string inCategory)
	{
		return default(long);
	}

	public List<string> LoadStringList(string inCategory, bool isDynamic = false)
	{
		return null;
	}

	public List<string> LoadStringList(string inCategory, char inSeperator, bool isDynamic = false)
	{
		return null;
	}

	public List<T> LoadGenericDefList<T>(string inChartName, string inCategory) where T : BaseDef
	{
		return null;
	}

	public List<T> LoadGenericDynamicDefList<T>(string inCategory) where T : BaseDef
	{
		return null;
	}

	public List<List<string>> LoadColorRefList(string inCategory)
	{
		return null;
	}

	public Color LoadColor(string inCategory)
	{
		return default(Color);
	}

	public Color LoadColorAsString(string inString)
	{
		return default(Color);
	}

	public Vector2 LoadVector2(string inCategory)
	{
		return default(Vector2);
	}

	public Vector3 LoadVector3(string inCategory)
	{
		return default(Vector3);
	}

	public float LoadFloat(string inCategory)
	{
		return default(float);
	}

	public int LoadInt(string inCategory)
	{
		return default(int);
	}

	public long LoadLong(string inCategory)
	{
		return default(long);
	}

	public bool LoadBool(string inCategory, bool inDefault = false)
	{
		return default(bool);
	}
}
