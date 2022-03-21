using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GestureRecognizer
{
	public class Recognizer : MonoBehaviour
	{
		private const int Detail = 100;

		[Range(1f, 4f)]
		public int numberOfThreads;

		public List<GesturePattern> patterns;

		public RecognitionResult Recognize(GestureData data, bool normalizeScale = true)
		{
			return null;
		}

		public void RecognizeAsync(GestureData data, Action<RecognitionResult> callback, bool normalizeScale = true)
		{
		}

		[IteratorStateMachine(typeof(<RecognizeCoroutine>d__5))]
		private IEnumerator RecognizeCoroutine(GestureData data, Action<RecognitionResult> callback, bool normalizeScale)
		{
			return null;
		}

		private GestureData NormalizeData(GestureData data, bool normalizeScale)
		{
			return null;
		}

		private static List<List<int>> GenPermutations(List<int> list, int low = 0)
		{
			return null;
		}

		private GestureData makePermutation(List<int> indexes, GestureData data)
		{
			return null;
		}

		private RecognitionResult findPattern(GestureData queryData, bool normalizeScale)
		{
			return null;
		}

		private RecognitionResult SearchThroughPatterns(int beginIndex, int endIndex, GestureData queryData, bool normalizeScale, List<GestureData> permutations, List<GestureData> singlePermutation)
		{
			return null;
		}

		private Score CalcScore(GestureData data1, GestureData data2, bool useLinesDirections)
		{
			return default(Score);
		}

		private List<float> CalcAngles(List<Vector2> points)
		{
			return null;
		}

		private List<float> CalcCurvature(List<Vector2> points)
		{
			return null;
		}

		private Score CalcListScore(List<Vector2> points1, List<Vector2> points2, bool points2IsClosed)
		{
			return default(Score);
		}

		private Score CalcCircularListScore(List<Vector2> points1, List<Vector2> points2)
		{
			return default(Score);
		}

		private Score CalcLinearListScore(List<Vector2> points1, List<Vector2> points2)
		{
			return default(Score);
		}

		private float CalcPositionDistance(List<Vector2> points1, List<Vector2> points2)
		{
			return default(float);
		}

		private float CalcCurvatureDistance(List<Vector2> points1, List<Vector2> points2)
		{
			return default(float);
		}

		private float CalcAngleDistance(List<Vector2> points1, List<Vector2> points2)
		{
			return default(float);
		}

		private Rect CalcRect(GestureData data)
		{
			return default(Rect);
		}

		private GestureData NormalizeClosedLines(GestureData data)
		{
			return null;
		}

		private GestureData NormalizeScale(GestureData data)
		{
			return null;
		}

		private Vector2 FindByNormalized(List<Vector2> vs, List<float> ts, float t)
		{
			return default(Vector2);
		}

		private GestureData NormalizeDistribution(GestureData data, int n)
		{
			return null;
		}

		private List<Vector2> NormalizeDistribution(List<Vector2> path, int n)
		{
			return null;
		}
	}
}
