using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using WW.Debug;

public static class CoreSharedUtils
{
	public enum EImageQuality
	{
		HQ,
		LQ
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SetIconUsingURL>d__68 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<Sprite> <>t__builder;

		public string inURL;

		public bool inSetTexture;

		public Image inTexture;

		private UnityWebRequest <request>5__2;

		private UnityWebRequestAsyncOperation <operation>5__3;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private static bool _slowInternetPopupShown;

	public static Vector3 Zero;

	public static Vector3 One;

	public static Quaternion Identity;

	private static Coroutine _globalInternetConnectionTester;

	public static bool _clearAssets;

	public static bool _garbageCollect;

	private static Coroutine _clearAssetsCoroutine;

	private static Dictionary<string, string> _toLowerDict;

	private static Dictionary<string, Type> _allUserTypes;

	private static Dictionary<string, Type> _allPublicTypes;

	private static Dictionary<string, Type> _allPublicExecutingTypes;

	private static int _rootResolution;

	private static string[] _sizeSuffixes;

	public static string CurrentUnitySceneName
	{
		get
		{
			return null;
		}
	}

	public static Dictionary<string, Type> AllUserTypes
	{
		get
		{
			return null;
		}
	}

	public static Dictionary<string, Type> AllPublicTypes
	{
		get
		{
			return null;
		}
	}

	public static Dictionary<string, Type> AllPublicExecutingTypes
	{
		get
		{
			return null;
		}
	}

	public static int rootResolution
	{
		get
		{
			return default(int);
		}
	}

	public static string GetAppUpdateURL()
	{
		return null;
	}

	public static string GetSharedImagesURL()
	{
		return null;
	}

	public static void OnAndroidQuit(Message inMessage)
	{
	}

	public static void SetResolution(int inWidth, int inHeight, bool inFullscreen)
	{
	}

	public static List<Transform> SortAlphabetically(List<Transform> inTransforms)
	{
		return null;
	}

	public static bool WithinDistance(Transform inTransform, Transform inOtherTransform, float inDistance)
	{
		return default(bool);
	}

	public static bool WithinDistance(Vector3 inPosition, Vector3 inOtherPosition, float inDistance)
	{
		return default(bool);
	}

	public static float GetDistance(Transform inTransform, Transform inOtherTransform)
	{
		return default(float);
	}

	public static float GetDistance(Vector3 inPosition, Vector3 inOtherPosition)
	{
		return default(float);
	}

	[DebugButton("Core Reset Default Error", "Core", true, false)]
	private static void DebugCoreResetDefaultError()
	{
	}

	public static void CoreReset(SplashError inSplashError, ErrorCode inErrorCode)
	{
	}

	[DebugButton("Core Reset", "Core", true, false)]
	public static void CoreReset()
	{
	}

	public static Vector2 WorldToCanvasPosition(RectTransform inCanvas, Camera inCamera, Vector3 inPosition, bool inCenteredY = false)
	{
		return default(Vector2);
	}

	public static void PopupErrorAndResetCoreWithLocDefIDs(string inMessageDefID, string inTitleDefID)
	{
	}

	public static void PopupErrorAndResetCoreWithStrings(string inMessageString, string inTitleString)
	{
	}

	private static void OnDisconnectPopupClosed(string inButton)
	{
	}

	public static T[] GetObjectsOfTypeInScene<T>() where T : UnityEngine.Object
	{
		return null;
	}

	public static bool HasFlag(UnityEngine.Object inObject, HideFlags inFlag)
	{
		return default(bool);
	}

	public static void SetActive(List<Transform> inTransforms, bool InActive)
	{
	}

	public static void SetActive(Transform InTransform, bool InActive)
	{
	}

	public static void SetActive(GameObject InGameObject, bool InActive)
	{
	}

	public static void SetActiveUIGroup(GameObject[] objects, bool inBool)
	{
	}

	public static void StopGlobalInternetConnectionTester()
	{
	}

	public static void StartGlobalInternetConnectionTester()
	{
	}

	[IteratorStateMachine(typeof(<InternetConnectionTesterRoutine>d__30))]
	public static IEnumerator InternetConnectionTesterRoutine()
	{
		return null;
	}

	public static void StopClearAssetsCoroutine()
	{
	}

	[IteratorStateMachine(typeof(<ClearAssetsCoroutine>d__35))]
	private static IEnumerator ClearAssetsCoroutine()
	{
		return null;
	}

	public static void ClearAssets(bool inGarbageCollect = false, bool inUseGCRCoroutine = true)
	{
	}

	private static void GC()
	{
	}

	public static bool IsVisible(List<Renderer> InRenderers)
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InternetConnected>d__41))]
	public static IEnumerator InternetConnected(Action<bool> internetConnectedCallback)
	{
		return null;
	}

	public static void ClearToLower()
	{
	}

	public static string FastToLower(string inName)
	{
		return null;
	}

	public static bool CaseInsensitiveContains(this string source, string toCheck)
	{
		return default(bool);
	}

	public static Type GetTypeFromAllUserTypes(string inName)
	{
		return null;
	}

	public static Type GetTypeFromAllPublicTypes(string inName)
	{
		return null;
	}

	public static Type GetTypeFromAllPublicExecutingTypes(string inName)
	{
		return null;
	}

	public static Type GetType(string typeName)
	{
		return null;
	}

	public static int GetClientDeviceType()
	{
		return default(int);
	}

	private static bool IsTablet()
	{
		return default(bool);
	}

	public static T Instantiate<T>(T InObject) where T : MonoBehaviour
	{
		return null;
	}

	public static T Instantiate<T>(T InObject, Vector3 InPosition, Quaternion InRotation) where T : MonoBehaviour
	{
		return null;
	}

	public static UnityEngine.Object Instance(UnityEngine.Object InObject)
	{
		return null;
	}

	public static UnityEngine.Object Instance(UnityEngine.Object InObject, Vector3 InPosition, Quaternion InRotation)
	{
		return null;
	}

	public static void SetIconUsingImageComponentDefID(string inImageDefID, WWImage inTexture, [Optional] Action<Sprite> inOnComplete)
	{
	}

	public static void SetIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, EImageQuality inImageQuality, [Optional] Action<Sprite> inOnComplete, bool inSetTexture = true)
	{
	}

	public static void SetIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, [Optional] Action<Sprite> inOnComplete, bool inSetTexture = true)
	{
	}

	[AsyncStateMachine(typeof(<SetIconUsingURL>d__68))]
	public static Task<Sprite> SetIconUsingURL(string inURL, Image inTexture, bool inSetTexture = true)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DownloadIconUsingImageDefComponent>d__69))]
	public static IEnumerator DownloadIconUsingImageDefComponent(ImageDefComponent inImageDef, Image inTexture, EImageQuality inImageQuality, [Optional] Action<Sprite> inOnComplete, bool inSetTexture = true)
	{
		return null;
	}

	public static void SetSpriteUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Sprite> inOnComplete)
	{
	}

	public static void SetTextureUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Texture> inOnComplete)
	{
	}

	[IteratorStateMachine(typeof(<DownloadSpriteUsingImageDefComponent>d__72))]
	public static IEnumerator DownloadSpriteUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Sprite> inOnComplete)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DownloadTextureUsingImageDefComponent>d__73))]
	public static IEnumerator DownloadTextureUsingImageDefComponent(ImageDefComponent inImageDef, GameObject inCacheToGameObject, Action<Texture> inOnComplete)
	{
		return null;
	}

	public static string GetImageComponentPath(ImageDefComponent inImageDef, EImageQuality inImageQuality)
	{
		return null;
	}

	public static T AddComponentCopy<T>(this GameObject go, T toAdd) where T : Component
	{
		return null;
	}

	public static T CopyComponent<T>(this Component comp, T other) where T : Component
	{
		return null;
	}

	public static string FormatBytesToMegaBytes(int inBytes, int inDecimals = 1)
	{
		return null;
	}

	public static string FormatBytesToMegaBytes(float inBytes, int inDecimals = 1)
	{
		return null;
	}

	public static string FormatBytesToMegaBytes(long inBytes, int inDecimals = 1)
	{
		return null;
	}

	public static float Map(float inValue, float inOriginalStart, float inOriginalEnd, float inNewStart, float inNewEnd)
	{
		return default(float);
	}

	public static Vector2 Map(float inValue, Vector2 inOriginalStart, Vector2 inOriginalEnd, Vector2 inNewStart, Vector2 inNewEnd)
	{
		return default(Vector2);
	}

	public static Vector3 Map(float inValue, Vector3 inOriginalStart, Vector3 inOriginalEnd, Vector3 inNewStart, Vector3 inNewEnd)
	{
		return default(Vector3);
	}

	public static float GetPercentage(int inCurrentValue, int inMinValue, int inMaxValue)
	{
		return default(float);
	}

	public static float GetPercentage(float inCurrentValue, float inMinValue, float inMaxValue)
	{
		return default(float);
	}

	public static float GetValueFromPercentage(float inPercentage, float inMinValue, float inMaxValue)
	{
		return default(float);
	}

	public static bool IsEven(int InValue)
	{
		return default(bool);
	}

	public static bool IsEven(float InValue)
	{
		return default(bool);
	}

	public static bool IsOdd(int InValue)
	{
		return default(bool);
	}

	public static bool IsOdd(float InValue)
	{
		return default(bool);
	}

	public static string GetDefIDFromPackedName(string inDefName)
	{
		return null;
	}

	public static string GetDefNameFromPackedName(string inDefName)
	{
		return null;
	}

	public static bool ArePackedDefNamesEqual(string inDefName1, string inDefName2)
	{
		return default(bool);
	}

	public static void InsertionSort<T>(IList<T> inList, Comparison<T> inComparison)
	{
	}

	public static void DestroyChildren(Transform inTransform)
	{
	}

	public static void DestroyChildrenImmediate(Transform inTransform)
	{
	}

	public static bool CanFitBytesOnDisk(long inByteCount)
	{
		return default(bool);
	}

	public static void DrawLineOnTexture(Texture2D inTex, Vector2 inPoint1, Vector2 inPoint2, Color inColor)
	{
	}

	public static Sprite GenerateUVSpriteFromMesh(Mesh inMesh, int inResolution)
	{
		return null;
	}

	public static string RepairBundleIDString(string inString)
	{
		return null;
	}

	public static string CleanForJSON(string s)
	{
		return null;
	}

	public static List<ValueTuple<T, U>> MakeTupleList<T, U>(List<T> inList1, List<U> inList2)
	{
		return null;
	}

	public static bool IsInside(Vector3 inPosition, BoxCollider inBoxCollider)
	{
		return default(bool);
	}

	public static bool IsInside(Vector3 inPosition, SphereCollider inSphereCollider)
	{
		return default(bool);
	}
}
