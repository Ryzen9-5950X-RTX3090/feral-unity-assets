using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;

[Category("â\u009c« Blackboard")]
public class CheckEnumFlag : ConditionTask
{
	[BlackboardOnly]
	[RequiredField]
	public readonly BBObjectParameter Variable;

	public readonly BBObjectParameter Flag;

	protected override string info
	{
		get
		{
			return null;
		}
	}

	protected override bool OnCheck()
	{
		return default(bool);
	}
}
