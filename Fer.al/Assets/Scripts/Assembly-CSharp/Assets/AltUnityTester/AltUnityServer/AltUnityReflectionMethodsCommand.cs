using System;
using System.Reflection;
using UnityEngine;

namespace Assets.AltUnityTester.AltUnityServer
{
	internal class AltUnityReflectionMethodsCommand : AltUnityCommand
	{
		public static Type GetType(string typeName, string assemblyName)
		{
			return null;
		}

		protected MemberInfo GetMemberForObjectComponent(AltUnityObject altUnityObject, AltUnityObjectProperty altUnityObjectProperty)
		{
			return null;
		}

		private MethodInfo GetMethodForObjectComponent(AltUnityObject altUnityObject, AltUnityObjectAction altUnityObjectAction)
		{
			return null;
		}

		protected MethodInfo[] GetMethodInfoWithSpecificName(Type componentType, string altActionMethod)
		{
			return null;
		}

		protected MethodInfo GetMethodToBeInvoked(MethodInfo[] methodInfos, AltUnityObjectAction altUnityObjectAction)
		{
			return null;
		}

		protected static string InvokeMethod(MethodInfo methodInfo, AltUnityObjectAction altAction, object component, string response)
		{
			return null;
		}

		protected string GetValueForMember(MemberInfo memberInfo, GameObject testableObject, AltUnityObjectProperty altProperty)
		{
			return null;
		}

		protected string SetValueForMember(MemberInfo memberInfo, string valueString, GameObject testableObject, AltUnityObjectProperty altProperty)
		{
			return null;
		}

		private string SerializeMemberValue(object value, Type type)
		{
			return null;
		}

		private object DeserializeMemberValue(string valueString, Type type)
		{
			return null;
		}

		public override string Execute()
		{
			return null;
		}
	}
}
