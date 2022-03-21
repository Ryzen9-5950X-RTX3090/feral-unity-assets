using System.Runtime.InteropServices;
using UnityEngine;

public static class CoreGizmosExtensions
{
	public static void DrawWireCube(Vector3 center, Vector3 size, [Optional] Quaternion rotation)
	{
	}

	public static void DrawArrow(Vector3 from, Vector3 to, float arrowHeadLength = 0.25f, float arrowHeadAngle = 20f)
	{
	}

	public static void DrawWireSphere(Vector3 center, float radius, [Optional] Quaternion rotation)
	{
	}

	public static void DrawWireCircle(Vector3 center, float radius, int segments = 20, [Optional] Quaternion rotation)
	{
	}

	public static void DrawWireArc(Vector3 center, float radius, float angle, int segments = 20, [Optional] Quaternion rotation)
	{
	}

	public static void DrawWireArc(Vector3 center, float radius, float angle, int segments, Quaternion rotation, Vector3 centerOfRotation)
	{
	}

	public static void DrawWireArc(Matrix4x4 matrix, float radius, float angle, int segments)
	{
	}

	public static void DrawWireCylinder(Vector3 center, float radius, float height, [Optional] Quaternion rotation)
	{
	}

	public static void DrawWireCapsule(Vector3 center, float radius, float height, [Optional] Quaternion rotation)
	{
	}
}
