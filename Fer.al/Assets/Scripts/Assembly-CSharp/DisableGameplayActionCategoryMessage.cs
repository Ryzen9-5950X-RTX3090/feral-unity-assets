public class DisableGameplayActionCategoryMessage : Message
{
	public readonly bool RequestDisable;

	public readonly bool ExcludePlayerControl;

	public DisableGameplayActionCategoryMessage(bool inRequestDisable, bool inExcludePlayerControl = false)
	{
	}
}
