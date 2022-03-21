using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AttributeUsage(AttributeTargets.Method)]
public class CasualGameCommandAttribute : PropertyAttribute
{
	public string Command
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

	public CasualGameCommandAttribute(string cmd)
	{
	}
}
