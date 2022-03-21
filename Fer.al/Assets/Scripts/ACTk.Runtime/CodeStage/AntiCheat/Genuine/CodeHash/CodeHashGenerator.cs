using System.Collections;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	public class CodeHashGenerator : KeepAliveBehaviour<CodeHashGenerator>, ICodeHashGenerator
	{
		private readonly WaitForSeconds cachedWaitForSeconds;

		private BaseWorker currentWorker;

		public HashGeneratorResult LastResult
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public bool IsBusy
		{
			get
			{
				return default(bool);
			}
		}

		public static event HashGeneratorResultHandler HashGenerated
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static bool IsTargetPlatformCompatible()
		{
			return default(bool);
		}

		public static CodeHashGenerator AddToSceneOrGetExisting()
		{
			return null;
		}

		public static ICodeHashGenerator Generate()
		{
			return null;
		}

		internal static FileFilter[] GetFileFiltersAndroid(bool il2Cpp)
		{
			return null;
		}

		internal static FileFilter[] GetFileFiltersStandaloneWindows(bool il2Cpp)
		{
			return null;
		}

		ICodeHashGenerator ICodeHashGenerator.Generate()
		{
			return null;
		}

		protected override void OnDestroy()
		{
		}

		protected override string GetComponentName()
		{
			return null;
		}

		private ICodeHashGenerator GenerateInternal()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<CalculationAwaiter>d__20))]
		private IEnumerator CalculationAwaiter()
		{
			return null;
		}
	}
}
