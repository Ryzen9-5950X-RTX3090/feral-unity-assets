using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu]
public class ServerEnvironment : ScriptableObject
{
	public ServerTier tier;

	public string webAPIHost;

	public string ingressHost;

	public string gameServerHost;

	public int gameServerPort;

	public string blueboxHost;

	public int blueboxPort;

	public bool isDebug;

	public bool useSecure;

	public bool IsIngress
	{
		get
		{
			return default(bool);
		}
	}

	public bool OverrideGameServerHost
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void OnEnable()
	{
	}

	public override string ToString()
	{
		return null;
	}
}
