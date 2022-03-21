using System.Runtime.CompilerServices;

[ManagedBehaviourManager("NetworkManager")]
public class TimeController : ManagedBehaviour
{
	public static TimeController _instance;

	public static TimeController instance
	{
		get
		{
			return null;
		}
	}

	public float secondRotation
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float minuteRotation
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float hourRotation
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float dayRotation
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void MOnDestroy()
	{
	}

	public override void MUpdate()
	{
	}
}
