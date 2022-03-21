using System;
using System.Collections.Generic;
using UnityEngine;

namespace WW.Debug
{
	public class DebugCommandPanel : DebugPanel
	{
		[Serializable]
		private class CommandHistorySerialized
		{
			public List<string> commandList;
		}

		[SerializeField]
		private bool clearCommandAfterExecution;

		[SerializeField]
		private DebugCommandOutput _output;

		private CommandHistorySerialized _commandHistory;

		private int _historyIndex;

		private bool _moveCaretToEnd;

		private const string COMMAND_HISTORY_KEY = "Debug_CommandHistory";

		protected override void OnEnable()
		{
		}

		public void OnOpen()
		{
		}

		public void OnClose()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void LateUpdate()
		{
		}

		private void Update()
		{
		}

		private void GetPreviousCommand()
		{
		}

		private void GetNextCommand()
		{
		}

		public override void BtnClicked_Clear()
		{
		}

		public char OnValidateCommand(string text, int charIndex, char addedChar)
		{
			return default(char);
		}
	}
}
