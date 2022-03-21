[ChartComponent("Colorable")]
public class ColorableDefComponent : DefComponent, IItemDefComponent
{
	[ChartHSV]
	public HSVColor color1HSVDefault;

	[ChartHSV]
	public HSVColor color2HSVDefault;

	[ChartHSV]
	public HSVColor color3HSVDefault;

	[ChartHSV]
	public HSVColor color4HSVDefault;

	[ChartInt]
	public int channelCount;

	public void OnClientOnlyItemCreated(Item item)
	{
	}
}
