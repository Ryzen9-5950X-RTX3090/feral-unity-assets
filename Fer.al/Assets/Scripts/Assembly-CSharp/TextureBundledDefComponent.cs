using UnityEngine;

[ChartComponent("Texture Bundle")]
public class TextureBundledDefComponent : BundleIDDefComponent
{
	[ChartTexture]
	public Texture2D texture;
}
