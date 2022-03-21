using System.Runtime.CompilerServices;

public class LandmarkMessage : Message
{
	public bool LandmarkEnabled
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

	public Landmark Landmark
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

	public string LandmarkName
	{
		get
		{
			return null;
		}
	}

	public LandmarkMessage(Landmark inLandmark, bool inEnabled)
	{
	}
}
