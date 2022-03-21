using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Scene")]
	public class LoadBundledLevel : ActionTask
	{
		public enum ELevelType
		{
			Level,
			LevelOverride
		}

		public ELevelType levelType;

		public bool loadLevel;

		public bool waitToContinue;

		public string levelName;

		public string levelDefID;

		public string levelOverrideName;

		public string levelOverrideDefID;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[IteratorStateMachine(typeof(<DoIt>d__11))]
		private IEnumerator DoIt()
		{
			return null;
		}
	}
}
