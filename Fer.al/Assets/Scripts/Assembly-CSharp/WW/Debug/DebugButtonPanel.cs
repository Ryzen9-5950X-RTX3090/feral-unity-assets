using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace WW.Debug
{
	public class DebugButtonPanel : MonoBehaviour
	{
		private const string DEBUG_BUTTON_PANEL_FAVORITES_KEY = "DebugButtonPanel_Favorites";

		[SerializeField]
		private DebugConsoleWindow _console;

		[SerializeField]
		private LayoutGroup _contentParent;

		[SerializeField]
		private DebugButtonGroup _buttonGroupPrefab;

		[SerializeField]
		private Toggle _editFavoritesToggle;

		public Action<bool> OnEditFavoritesChanged;

		private bool _rebuildPanel;

		private List<DebugMethodGroup> _methodGroups;

		private List<DebugButtonGroup> _buttonGroups;

		private DebugMethodGroup _favoriteGroup;

		private List<string> _favorites;

		private string _currentPath;

		private Stack<string> _pathHistory;

		private bool _layoutRebuildNeeded;

		public bool EditFavorites
		{
			get
			{
				return default(bool);
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnShown()
		{
		}

		private void OnHidden()
		{
		}

		private void OnButtonMethodsChanged()
		{
		}

		private void DestroyButtonGroups()
		{
		}

		private void SetupButtonGroups()
		{
		}

		private void LoadFavorites()
		{
		}

		private void SaveFavorites()
		{
		}

		[ContextMenu("RebuildLayout")]
		public void ReportFieldUpdated()
		{
		}

		public void DrawButtonGroups(string inPath = "root")
		{
		}

		public void BtnClicked_Back()
		{
		}

		public void ValueChanged_EditFavorites()
		{
		}

		public bool IsFavorite(ConsoleMethodInfo methodInfo)
		{
			return default(bool);
		}

		public void AddFavorite(ConsoleMethodInfo methodInfo)
		{
		}

		public void RemoveFavorite(ConsoleMethodInfo methodInfo)
		{
		}

		public bool IsFavorite(ConsoleFieldInfo fieldInfo)
		{
			return default(bool);
		}

		public void AddFavorite(ConsoleFieldInfo fieldInfo)
		{
		}

		public void RemoveFavorite(ConsoleFieldInfo fieldInfo)
		{
		}
	}
}
