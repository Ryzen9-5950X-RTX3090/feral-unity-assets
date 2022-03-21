using UnityEngine;

public class FX_CullingScript : MonoBehaviour
{
	public float cullingRadius;

	public ParticleSystem target;

	private CullingGroup m_CullingGroup;

	private Renderer[] m_ParticleRenderers;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnStateChanged(CullingGroupEvent sphere)
	{
	}

	private void Cull(bool visible)
	{
	}

	private void SetRenderers(bool enable)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
