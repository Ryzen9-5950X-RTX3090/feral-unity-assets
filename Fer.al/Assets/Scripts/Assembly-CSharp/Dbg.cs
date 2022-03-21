using System;
using System.Diagnostics;
using UnityEngine;

public class Dbg
{
	public static string debugPerson;

	private static int? _debugPersonIdx;

	public static bool isDebugBuild
	{
		get
		{
			return default(bool);
		}
	}

	public static bool ValidDebugPerson(EDebugPerson inDebugPerson)
	{
		return default(bool);
	}

	public static void ReleaseLog(object message)
	{
	}

	public static void ReleaseLog(object message, UnityEngine.Object context)
	{
	}

	[Conditional("UNITY_EDITOR")]
	public static void EditorLog(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("UNITY_EDITOR")]
	public static void EditorLog(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("UNITY_EDITOR")]
	public static void EditorLogWarning(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("UNITY_EDITOR")]
	public static void EditorLogWarning(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("UNITY_EDITOR")]
	public static void EditorLogError(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("UNITY_EDITOR")]
	public static void EditorLogError(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DBG_OVERRIDE")]
	public static void Log(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DBG_OVERRIDE")]
	public static void LogWithTime(object message)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DBG_OVERRIDE")]
	public static void Log(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DBG_OVERRIDE")]
	public static void LogWarning(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DBG_OVERRIDE")]
	public static void LogWarning(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	public static void LogError(object message, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	public static void LogError(object message, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	public static void LogException(Exception exception, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	public static void LogException(Exception exception, UnityEngine.Object context, EDebugPerson inDebugPerson = EDebugPerson.ALL)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public static void Break()
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public static void DebugBreak()
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public static void DrawLine(Vector3 start, Vector3 end, Color color)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration, bool depthTest)
	{
	}

	public static Type MParentType<T>()
	{
		return null;
	}

	public static Type MParentType(Type inType)
	{
		return null;
	}

	public static bool MIsVerbose<T>()
	{
		return default(bool);
	}

	public static bool MIsVerbose(Type inType)
	{
		return default(bool);
	}

	public static void MSetVerbose<T>(bool inVerbose)
	{
	}

	public static void MSetVerbose(Type inType, bool inVerbose)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DBG_OVERRIDE")]
	public static void MLog<T>(string inLog)
	{
	}

	public static void MLogError<T>(string inLog)
	{
	}

	public static void Report(object message)
	{
	}

	public static void ReportBundleError(string inBundleID)
	{
	}

	public static void ReportToBlinky(string reportType, string uuid)
	{
	}
}
