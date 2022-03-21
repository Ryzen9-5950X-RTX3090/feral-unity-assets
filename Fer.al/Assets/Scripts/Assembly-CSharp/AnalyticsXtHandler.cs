using Server;

[MessageRouteHandler]
public static class AnalyticsXtHandler
{
	[MessageSender(XtCmd.AnalyticsFeedback, false)]
	public static void RequestAnalyticsFeedbackSend(string category, string feedback)
	{
	}

	[MessageSender(XtCmd.AnalyticsSelfie, false)]
	public static void RequestAnalyticsSelfieCreate(string volumeDef, string[] defIds)
	{
	}
}
