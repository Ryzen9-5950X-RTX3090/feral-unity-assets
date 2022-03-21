using UnityEngine;

[ExecuteInEditMode]
public class Controls : MonoBehaviour
{
	public AmplifyOcclusionEffect occlusion;

	private const AmplifyOcclusionBase.ApplicationMethod POST = AmplifyOcclusionBase.ApplicationMethod.PostEffect;

	private const AmplifyOcclusionBase.ApplicationMethod DEFERRED = AmplifyOcclusionBase.ApplicationMethod.Deferred;

	private const AmplifyOcclusionBase.ApplicationMethod DEBUG = AmplifyOcclusionBase.ApplicationMethod.Debug;

	private void OnGUI()
	{
	}
}
