[ChartComponent("Actor Info")]
public class ActorInfoDefComponent : DefComponent
{
	[ChartClass]
	public ActorInfo serializedActorInfo;

	[ChartButton("Get Info From NPC Editor", "ButtonGetInfoFromNPCEditor")]
	private bool buttonGetInfoFromNPCEditor;

	public void ButtonGetInfoFromNPCEditor(PropertyEditor.DefEntry inDefEntry)
	{
	}
}
