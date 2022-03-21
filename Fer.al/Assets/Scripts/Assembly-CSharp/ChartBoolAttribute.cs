public class ChartBoolAttribute : ChartDrawableFieldAttribute
{
	private bool? _csvSetOnExportValue;

	private bool _csvTrueRequiredToExport;

	public bool CSVSetOnExport
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool CSVTrueRequiredToExport
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override bool CSVAllowExport
	{
		get
		{
			return default(bool);
		}
	}

	public override bool OnExportAsCSV()
	{
		return default(bool);
	}
}
