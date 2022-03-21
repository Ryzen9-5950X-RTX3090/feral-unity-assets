using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Backtrace.Unity.Json;
using UnityEngine;

namespace Backtrace.Unity.Model.JsonData
{
	public class Annotations
	{
		[CompilerGenerated]
		private static Dictionary<string, string> <EnvironmentVariablesCache>k__BackingField;

		[CompilerGenerated]
		private Dictionary<string, string> <EnvironmentVariables>k__BackingField;

		private readonly int _gameObjectDepth;

		public static Dictionary<string, string> EnvironmentVariablesCache
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Dictionary<string, string> EnvironmentVariables
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Annotations(Exception exception, int gameObjectDepth)
		{
		}

		private static Dictionary<string, string> SetEnvironmentVariables()
		{
			return null;
		}

		public BacktraceJObject ToJson()
		{
			return null;
		}

		private BacktraceJObject ConvertGameObject(GameObject gameObject, int depth = 0)
		{
			return null;
		}

		private BacktraceJObject ConvertGameObject(Component gameObject, string parentName, int depth)
		{
			return null;
		}

		private BacktraceJObject GetJObject(GameObject gameObject, string parentName = "")
		{
			return null;
		}

		private BacktraceJObject GetJObject(Component gameObject, string parentName = "")
		{
			return null;
		}
	}
}
