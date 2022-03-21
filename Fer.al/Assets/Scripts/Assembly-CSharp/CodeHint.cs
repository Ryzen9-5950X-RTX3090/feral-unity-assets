using System;
using System.Collections.Generic;

[Serializable]
public class CodeHint
{
	public List<CodeHintType> hints;

	public void AddHint(CodeHintType inHint)
	{
	}

	public void ClearHints()
	{
	}

	public bool IsMatch(int codeLength)
	{
		return default(bool);
	}
}
