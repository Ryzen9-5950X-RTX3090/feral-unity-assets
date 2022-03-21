using UnityEngine;

[AddComponentMenu("Effects/SetRenderQueue")]
[RequireComponent(typeof(Renderer))]
public class SetRenderQueue : MonoBehaviour
{
	public int queue;

	protected int queueCache;

	public int[] queues;

	public bool useSharedMaterial;

	protected void Apply()
	{
	}

	protected void Update()
	{
	}

	private void OnDestroy()
	{
	}
}
