using System.Runtime.CompilerServices;

public class CodeAttempt
{
	public Code Code
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

	public CodeHint Hint
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

	public CodeAttempt(Code inCode)
	{
	}

	public CodeAttempt(Code inCode, CodeHint inHint)
	{
	}

	public bool TutorialCompareToCode(Code inCode)
	{
		return default(bool);
	}

	public bool AllHintsCorrect()
	{
		return default(bool);
	}

	public bool AllHintsWrong()
	{
		return default(bool);
	}

	public bool HasWrongPlaceHint()
	{
		return default(bool);
	}

	public bool HasCorrectPlaceHint()
	{
		return default(bool);
	}

	public bool HasDuplicates()
	{
		return default(bool);
	}
}
