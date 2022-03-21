using System;
using UnityEngine;

[ChartComponent("Icon 2D")]
public class Icon2DDefComponent : DefComponent
{
	[ChartDef("Image", new string[] { })]
	public string imageDefID;

	public ImageDefComponent IconImageDef
	{
		get
		{
			return null;
		}
	}

	public virtual QRoutine Get2DIconTexture(GameObject inReferenceGameObject, Action<Texture2D> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}

	public virtual QRoutine Get2DIconSprite(GameObject inReferenceGameObject, Action<Sprite> inResult, AssetQualityLevel inQuality = AssetQualityLevel.None, BundlePriority inPriority = BundlePriority.Normal)
	{
		return null;
	}
}
