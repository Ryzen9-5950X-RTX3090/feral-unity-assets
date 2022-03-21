using LitJson;

public class DecreeItem
{
	public enum DecreeLayoutType
	{
		Billboard,
		ImageWithText,
		TextWithIcon,
		TextOnly,
		ImageOnly
	}

	public enum DecreeCategory
	{
		FrontPage,
		Events,
		CheckItOut
	}

	public readonly string headerLocalizationDefId;

	public readonly string messageLocalizationDefId;

	public readonly string imageDefId;

	public readonly DecreeCategory decreeCategory;

	public readonly DecreeLayoutType decreeLayoutType;

	public DecreeItem(DecreeDefComponent decreeDef)
	{
	}

	public DecreeItem(JsonData jsonData)
	{
	}
}
