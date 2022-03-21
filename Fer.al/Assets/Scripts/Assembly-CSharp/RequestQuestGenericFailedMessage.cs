using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class RequestQuestGenericFailedMessage : Message
{
	public string ErrorMessage
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

	public string ErrorDefId
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

	public string NewNodeIpOnNodeHop
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

	public LanguageId LanguageOnLanguageChange
	{
		[CompilerGenerated]
		get
		{
			return default(LanguageId);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public RequestQuestGenericFailedMessage(string inErrorMessage, string inErrorDefId, [Optional] string inNewNodeIpOnNodeHop, LanguageId inLanguageOnLanguageChange = LanguageId.English)
	{
	}
}
