using System;

namespace Gaia.FullSerializer
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public sealed class fsObjectAttribute : Attribute
	{
		public Type[] PreviousModels;

		public string VersionString;

		public fsMemberSerialization MemberSerialization;

		public Type Converter;

		public Type Processor;

		public fsObjectAttribute()
		{
		}

		public fsObjectAttribute(string versionString, Type[] previousModels)
		{
		}
	}
}
