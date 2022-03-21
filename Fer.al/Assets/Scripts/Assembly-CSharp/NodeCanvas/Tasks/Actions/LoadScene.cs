using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.SceneManagement;

namespace NodeCanvas.Tasks.Actions
{
	[Category("Application")]
	public class LoadScene : ActionTask
	{
		public bool loadScene;

		[RequiredField]
		public BBParameter<string> sceneName;

		public BBParameter<LoadSceneMode> mode;

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
	}
}
