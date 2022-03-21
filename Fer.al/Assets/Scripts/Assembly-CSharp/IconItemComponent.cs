using System;
using System.Runtime.CompilerServices;

[Serializable]
public class IconItemComponent : ItemComponent
{
	public string defId;

	public ImageDefComponent ImageDef
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void OnLoaded()
	{
	}
}
