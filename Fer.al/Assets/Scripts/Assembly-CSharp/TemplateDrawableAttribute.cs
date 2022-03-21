using System;
using System.Collections.Generic;
using System.Reflection;

public class TemplateDrawableAttribute : Attribute
{
	private bool _labelWasSet;

	private string _label;

	public List<PropertyEditor.DefEntry> targetDefEntries;

	public PropertyEditor.Project targetProject;

	public PropertyEditor.Chart targetChart;

	public MethodInfo targetMethod;

	private string _visibleBoolName;

	private bool _visibleWhenBoolEquals;

	private float _width;

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
}
