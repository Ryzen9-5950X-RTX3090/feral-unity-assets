public class ActorNPCTemplate : PropertyEditor.ChartTemplateBase
{
	public ActorNPCDefComponent actorNPCDefComponent;

	public LocalizedNameDefComponent localizedNameDefComponent;

	public Icon2DDefComponent icon2DDefComponent;

	public ActorInfoGetModelDefComponent actorInfoGetModelDefComponent;

	public ActorInfoDefComponent actorInfoDefComponent;

	public EditorScreenshotDefComponent editorScreenshotDefComponent;

	[TemplateButton("Open In NPC Editor")]
	public static void OpenInNPCEditor(PropertyEditor.DefEntry inDefEntry)
	{
	}

	public static bool OpenInNPCEditor_Visible(PropertyEditor.DefEntry inDefEntry)
	{
		return default(bool);
	}
}
