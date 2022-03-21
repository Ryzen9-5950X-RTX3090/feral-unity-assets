using System;

[AttributeUsage(AttributeTargets.Field)]
public class ChartDrawableFieldAttribute : ChartDrawableAttribute
{
	private string _csvExportHeader;

	private string _csvImportHeader;

	public string CSVExportHeader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string CSVImportHeader
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public object Value
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual bool ValidForCommitting
	{
		get
		{
			return default(bool);
		}
	}
}
