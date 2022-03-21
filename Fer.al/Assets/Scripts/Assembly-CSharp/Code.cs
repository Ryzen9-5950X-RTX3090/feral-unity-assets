using System;
using System.Collections.Generic;

[Serializable]
public class Code
{
	public int codeLength;

	public List<CodeColor> sequence;

	public void SetCodeLength(int inLength)
	{
	}

	public void SetCode(CodeColor[] inColors)
	{
	}

	public void SetCode(List<CodeColor> inColors)
	{
	}

	public void SetCodeAtIndex(int inIndex, CodeColor inColor)
	{
	}

	public bool IsCodeValid()
	{
		return default(bool);
	}

	public static Code GenerateRandomCode(int inLength)
	{
		return null;
	}

	public static Code GenerateRandomCode(int inLength, int inColorMask, bool allowRepeat)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
