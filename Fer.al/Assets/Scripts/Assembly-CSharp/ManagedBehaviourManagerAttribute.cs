using System;

[AttributeUsage(AttributeTargets.Class)]
public class ManagedBehaviourManagerAttribute : Attribute
{
	public readonly string managerName;

	public ManagedBehaviourManagerAttribute(string managerName)
	{
	}
}
