using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace NodeCanvas.Framework
{
	public static class IGraphAssignableExtensions
	{
		public static Graph CheckInstance(this IGraphAssignable assignable)
		{
			return null;
		}

		public static bool TryStartSubGraph(this IGraphAssignable assignable, Component agent, [Optional] Action<bool> callback)
		{
			return default(bool);
		}

		public static bool TryStopSubGraph(this IGraphAssignable assignable)
		{
			return default(bool);
		}

		public static bool TryPauseSubGraph(this IGraphAssignable assignable)
		{
			return default(bool);
		}

		public static bool TryResumeSubGraph(this IGraphAssignable assignable)
		{
			return default(bool);
		}

		public static bool TryUpdateSubGraph(this IGraphAssignable assignable)
		{
			return default(bool);
		}

		public static void TryWriteMappedVariables(this IGraphAssignable assignable)
		{
		}

		public static void TryReadMappedVariables(this IGraphAssignable assignable)
		{
		}

		public static void ValidateSubGraphAndParameters(this IGraphAssignable assignable)
		{
		}

		public static void AutoLinkByName(this IGraphAssignable assignable)
		{
		}
	}
}
