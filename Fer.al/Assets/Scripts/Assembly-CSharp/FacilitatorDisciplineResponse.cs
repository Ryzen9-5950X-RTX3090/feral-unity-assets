using System.Runtime.CompilerServices;
using Server;

public class FacilitatorDisciplineResponse : ServerMessage
{
	public string DisciplineType
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

	public bool IsOn
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

	public int ExpiresInSeconds
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FacilitatorXtHandler.DisciplineReason Reason
	{
		[CompilerGenerated]
		get
		{
			return default(FacilitatorXtHandler.DisciplineReason);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FacilitatorDisciplineResponse(XtReader data)
	{
	}
}
