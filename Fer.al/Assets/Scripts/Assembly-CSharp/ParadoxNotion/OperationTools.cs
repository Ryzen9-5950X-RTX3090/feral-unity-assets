using UnityEngine;

namespace ParadoxNotion
{
	public static class OperationTools
	{
		public static string GetOperationString(OperationMethod om)
		{
			return null;
		}

		public static float Operate(float a, float b, OperationMethod om, float delta = 1f)
		{
			return default(float);
		}

		public static int Operate(int a, int b, OperationMethod om)
		{
			return default(int);
		}

		public static Vector3 Operate(Vector3 a, Vector3 b, OperationMethod om, float delta = 1f)
		{
			return default(Vector3);
		}

		public static string GetCompareString(CompareMethod cm)
		{
			return null;
		}

		public static bool Compare(float a, float b, CompareMethod cm, float floatingPoint)
		{
			return default(bool);
		}

		public static bool Compare(int a, int b, CompareMethod cm)
		{
			return default(bool);
		}
	}
}
