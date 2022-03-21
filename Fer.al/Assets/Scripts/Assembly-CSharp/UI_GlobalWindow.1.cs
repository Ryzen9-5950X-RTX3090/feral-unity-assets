public class UI_GlobalWindow<T> : UI_Window where T : UI_GlobalWindow<T>
{
	protected static T _instance;

	public static T instance
	{
		get
		{
			return null;
		}
	}

	public override void SetInstanceInternal()
	{
	}

	public override void UnsetInstanceInternal()
	{
	}

	public override void MStart()
	{
	}
}
