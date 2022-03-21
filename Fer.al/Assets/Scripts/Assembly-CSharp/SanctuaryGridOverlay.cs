using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryGridOverlay : ManagedBehaviour
{
	private Material _lineMaterial;

	private Transform _trackingObject;

	private Vector3 _trackingObjectEdgeL;

	private Vector3 _trackingObjectEdgeR;

	private Vector3 _trackingObjectEdgeF;

	private Vector3 _trackingObjectEdgeB;

	private void CreateLineMaterial()
	{
	}

	public void UpdateEdges(Vector3 inL, Vector3 inR, Vector3 inF, Vector3 inB)
	{
	}

	private void RenderObjectOverlay()
	{
	}
}
