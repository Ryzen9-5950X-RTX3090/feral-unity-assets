using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FeralLODController : ManagedBehaviour
{
	[Serializable]
	public class FeralLODGroup
	{
		public LODGroup lodGroup;

		public MeshRenderer[] meshRenderers;
	}

	[SerializeField]
	private float _screenRelativeTransitionHeight;

	[SerializeField]
	private float _fadeTransitionWidth;

	[SerializeField]
	private bool _includeInactiveRenderers;

	[SerializeField]
	private bool _createLodForEveryMeshRenderer;

	public static FeralLODController instance
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

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	public void AddLODGroup(FeralLODGroup inFeralLODGroup)
	{
	}

	public void DestroyFeralLODGroups()
	{
	}

	public void CreateLODGroups(MeshRenderer[] inMeshRenderers)
	{
	}

	private FeralLODGroup CreateLODGroupForMeshRendererParent(MeshRenderer inMeshRenderer)
	{
		return null;
	}

	private FeralLODGroup CreateLODGroupForEachMeshRenderer(MeshRenderer inMeshRenderer)
	{
		return null;
	}

	public static LODGroup CreateLODGroupForEachMeshRendererOnGameObject(GameObject inGameObject)
	{
		return null;
	}

	public static LODGroup CreateLODGroupForEachSkinnedMeshRendererOnGameObject(GameObject inGameObject)
	{
		return null;
	}
}
