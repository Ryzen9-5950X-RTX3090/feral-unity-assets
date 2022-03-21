using System.Collections;
using System.Runtime.CompilerServices;

public class BundledParticleSystemTexture : ManagedBehaviour
{
	public string bundledTexturePath;

	public override void MAwake()
	{
	}

	[IteratorStateMachine(typeof(<LoadParticleTexture>d__2))]
	private IEnumerator LoadParticleTexture()
	{
		return null;
	}
}
