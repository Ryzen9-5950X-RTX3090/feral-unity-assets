using System;

[AttributeUsage(AttributeTargets.Class)]
public class BundleRootPathAttribute : Attribute
{
	public readonly string pathName;

	public BundleRootPathAttribute(string pathName)
	{
	}
}
