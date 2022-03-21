using UnityEngine;

[ChartComponent("Sanctuary Greenhouse")]
public class SanctuaryGreenhouseDefComponent : DefComponent
{
	[ChartBundle]
	public ChartBundle exteriorBundle;

	[ChartBundle]
	public ChartBundle interiorBundle;

	[ChartBundle]
	public ChartBundle doorBundle;

	[ChartDef("Interactable", new string[] { })]
	public string interactablePlanterBoxDefId;

	[ChartDef("Interactable", new string[] { })]
	public string interactableCameraDefId;

	[ChartString]
	public string namingPlanterBox;

	[ChartString]
	public string namingCommunityBox;

	[ChartString]
	public string namingPlot;

	[ChartString]
	public string namingCameraMount;

	[ChartString]
	public string namingCameraTarget;

	[ChartString]
	public string namingInteriorSpawn;

	[ChartString]
	public string namingExteriorSpawn;

	[ChartString]
	public string namingInteriorExitVolume;

	[ChartString]
	public string namingExteriorEnterVolume;

	[ChartString]
	public string namingCameraInteract;

	[ChartString]
	public string bridgeNode;

	[ChartString]
	public string blockerNode;

	[ChartString]
	public string placementNode;

	[ChartVector3]
	public Vector3 entryPosition;

	[ChartVector3]
	public Vector3 entryRotation;

	[ChartInt]
	public int planterPlotLevels;

	[ChartInt]
	public int communityPlotLevels;
}
