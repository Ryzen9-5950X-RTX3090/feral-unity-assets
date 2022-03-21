using UnityEngine;

public class BuildersFollyStationTile : BuildersFollyTile
{
	public GameObject fxStation;

	public BuildersFollyData.EStationType stationType;

	internal BuildersFollyResource.EResourceOption resourceOption;

	internal BuildersFollyTile[] inputTile;

	internal BuildersFollyTile outputTile;

	internal BuildersFollyResource.EResourceColor resourceDyeColor_output;

	internal BuildersFollyResource outPutResource;
}
