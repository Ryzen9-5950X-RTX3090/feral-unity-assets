using System;
using System.Collections.Generic;
using Rewired;
using UnityEngine;

internal static class QGjnOCnHKfrjIqlAonYthHKMREQ
{
	[CustomObfuscation]
	public delegate void EventFunction<T, TArgs>(T handler, TArgs value) where T : class;

	[CustomClassObfuscation]
	[CustomObfuscation]
	public class HierarchyEventHelper<THandler, TValue> where THandler : class
	{
		[Flags]
		public enum mNUzMnNqQkhDwviritXNCuEbBBq
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			reutqBoSDFHzdRdatgCOBTMjhdTc = 1,
			LigEtlOuYTjsfZpmMXVZLQEijfx = 4,
			mGkdKoxcxeNOsPnVWJQusKcKhEH = 8,
			vzMMxueJoLYorCLLdhgKRypSGMx = -1
		}

		private readonly EventFunction<THandler, TValue> FmqYEzWbIgTCCwgwZlMrEZtvHDl;

		private readonly List<THandler> tTpxikyFxoYOndRtafIKiJduzRC;

		private readonly mNUzMnNqQkhDwviritXNCuEbBBq nTTqWZpCcVRhACCitBSNVDOCEsKf;

		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate)
		{
		}

		public HierarchyEventHelper(EventFunction<THandler, TValue> executeDelegate, mNUzMnNqQkhDwviritXNCuEbBBq executeOn)
		{
		}

		public void ExecuteOnAll(TValue value)
		{
		}

		public void GetHandlers(Transform transform)
		{
		}
	}

	public static void POEBBFcbJyccjYiYZGbZHzwhEbT<T, TArgs>(T P_0, TArgs P_1, EventFunction<T, TArgs> P_2) where T : class
	{
	}

	public static void POEBBFcbJyccjYiYZGbZHzwhEbT<T, TArgs>(IList<T> P_0, TArgs P_1, EventFunction<T, TArgs> P_2) where T : class
	{
	}

	public static void wJzrdYArvEbReVrBiirmhwJTecP<T, TArgs>(IList<T> P_0, TArgs P_1, EventFunction<T, TArgs> P_2, bool P_3) where T : class
	{
	}
}
