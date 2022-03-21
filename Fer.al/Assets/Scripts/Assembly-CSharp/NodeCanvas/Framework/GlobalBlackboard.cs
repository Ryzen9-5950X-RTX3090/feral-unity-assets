using System.Collections.Generic;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	public class GlobalBlackboard : Blackboard, IGlobalBlackboard, IBlackboard
	{
		[SerializeField]
		private string _UID;

		[SerializeField]
		private string _identifier;

		[SerializeField]
		private bool _dontDestroyOnLoad;

		private static List<GlobalBlackboard> _allGlobals;

		public string identifier
		{
			get
			{
				return null;
			}
		}

		public string UID
		{
			get
			{
				return null;
			}
		}

		public new string name
		{
			get
			{
				return null;
			}
		}

		public static IEnumerable<GlobalBlackboard> GetAll()
		{
			return null;
		}

		public static GlobalBlackboard Create()
		{
			return null;
		}

		public static GlobalBlackboard Find(string name)
		{
			return null;
		}

		public override void MOnEnable()
		{
		}

		public override void MOnDestroy()
		{
		}

		protected override void OnValidate()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private bool IsPrefabAsset()
		{
			return default(bool);
		}
	}
}
