using System;

[Serializable]
public class QuestDefTask
{
	[ChartDef("Image", new string[] { })]
	public string imageDefId;

	private ImageDefComponent _imageDef;

	[ChartDef("Localization", new string[] { })]
	public string localizedDescriptionDefID;

	private LocalizationDef _localizedDescriptionDef;

	[ChartInt]
	public int targetProgress;

	[ChartBool]
	public bool showProgressText;

	public ImageDefComponent Image
	{
		get
		{
			return null;
		}
	}

	public LocalizationDef LocalizedDescription
	{
		get
		{
			return null;
		}
	}
}
