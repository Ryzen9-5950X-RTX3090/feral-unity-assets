using System;
using System.Collections.Generic;

public class ChartDataObject : MonoBehaviour
{
	public virtual string ChartName
	{
		get
		{
			return null;
		}
	}

	public virtual bool RequireEncryption
	{
		get
		{
			return default(bool);
		}
	}

	public string DatabaseFilenameNoExtension
	{
		get
		{
			return null;
		}
	}

	public string DatabaseFilename
	{
		get
		{
			return null;
		}
	}

	public string DatabaseHashFilename
	{
		get
		{
			return null;
		}
	}

	public virtual string DatabaseName
	{
		get
		{
			return null;
		}
	}

	public virtual bool Localized
	{
		get
		{
			return default(bool);
		}
	}

	public virtual bool PlatformSpecific
	{
		get
		{
			return default(bool);
		}
	}

	public virtual bool SortInEditor
	{
		get
		{
			return default(bool);
		}
	}

	public virtual BaseDef GetDef(string inDefID, bool inShowErrors = false)
	{
		return null;
	}

	public virtual List<ValueTuple<string, string>> GetAllDefIDs()
	{
		return null;
	}
}
