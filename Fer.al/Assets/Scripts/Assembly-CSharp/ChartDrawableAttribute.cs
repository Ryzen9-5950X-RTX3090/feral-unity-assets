using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class ChartDrawableAttribute : Attribute
{
	private bool _labelWasSet;

	private string _label;

	public PropertyEditor.DefEntry targetDefEntry;

	public List<PropertyEditor.DefEntry> targetDefEntries;

	public PropertyEditor.DefEntryComponent targetDefEntryComponent;

	public PropertyEditor.Project targetProject;

	public PropertyEditor.Chart targetChart;

	public object targetObject;

	public FieldInfo targetField;

	public FieldInfo targetListField;

	public IList targetList;

	public int targetIndex;

	public MethodInfo targetMethod;

	public float targetMaxWidth;

	private bool _focus;

	private string _visibleBoolName;

	private bool _visibleWhenBoolEquals;

	private float _width;

	private string _uniqueID;

	public string Label
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Type FieldType
	{
		get
		{
			return null;
		}
	}

	public bool Focus
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public string VisibleBoolName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool VisibleWhenBoolEquals
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public float Width
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public virtual bool CSVAllowExport
	{
		get
		{
			return default(bool);
		}
	}

	public string UniqueID
	{
		get
		{
			return null;
		}
	}

	public void InternalDrawInInspector()
	{
	}

	public virtual void DrawInInspector()
	{
	}

	public void InternalDrawInSelectorList()
	{
	}

	public virtual void DrawInSelectorList()
	{
	}

	public virtual void Repair()
	{
	}

	public virtual bool OnExportAsCSV()
	{
		return default(bool);
	}

	public virtual void OnListAdd()
	{
	}

	public virtual void QueueFocus()
	{
	}
}
