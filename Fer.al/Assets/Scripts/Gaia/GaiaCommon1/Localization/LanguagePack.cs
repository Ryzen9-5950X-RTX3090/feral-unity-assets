using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace GaiaCommon1.Localization
{
	public class LanguagePack
	{
		private static IDictionary<string, LanguagePack> ms_loadedPacks;

		public const string VERSION = "1";

		public string Version;

		public double LastUpdated;

		public List<LocalizationCategory> Categories;

		public IDictionary<string, LocalizationItem> Items;

		private string m_path;

		private event Action OnChange
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

		public LanguagePack()
		{
		}

		public LanguagePack(LocalizationItem[] items)
		{
		}

		public LanguagePack(LocalizationCategory[] categories)
		{
		}

		public static LanguagePack Load(string path)
		{
			return null;
		}

		public void ReLoad()
		{
		}

		private void LoadV1(BinaryFormatter formatter, Stream stream)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public void Validate()
		{
		}

		[Conditional("UNITY_EDITOR")]
		public void AddOnChangeAction(Action action)
		{
		}

		[Conditional("UNITY_EDITOR")]
		public void RemoveOnChangeAction(Action action)
		{
		}
	}
}
