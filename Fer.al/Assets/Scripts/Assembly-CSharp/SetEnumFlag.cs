using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

[Category("â\u009c« Blackboard")]
public class SetEnumFlag : ActionTask
{
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable;

	public readonly BBObjectParameter Flag;

	public readonly BBParameter<bool> Clear;

	protected override string info
	{
		get
		{
			return null;
		}
	}

	protected override void OnExecute()
	{
	}
}
