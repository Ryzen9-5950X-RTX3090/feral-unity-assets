using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FaceMainCameraController
{
	private static List<FaceMainCamera> _faceMainCameraList;

	private static Coroutine _updateRoutine;

	private static Camera _cachedCamera;

	private static Camera cachedCamera
	{
		get
		{
			return null;
		}
	}

	public static void Add(FaceMainCamera inFaceMainCamera)
	{
	}

	public static void Remove(FaceMainCamera inFaceMainCamera)
	{
	}

	[IteratorStateMachine(typeof(<FaceCameraRoutine>d__7))]
	private static IEnumerator FaceCameraRoutine()
	{
		return null;
	}
}
