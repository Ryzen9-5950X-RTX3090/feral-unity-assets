using System.Collections.Generic;
using DG.Tweening;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.DOTween.Tweens.GameObjects
{
	[Category("DOTween/Tweens/GameObjects")]
	[Name("Create Path Tween", 0)]
	[Description("Creates a path tween for configuration or use")]
	[Icon("DOTweenPath", false, "")]
	public class CreatePathTween : ActionTask
	{
		[RequiredField]
		public BBParameter<List<Vector3>> VectorPath;

		[RequiredField]
		public BBParameter<float> Duration;

		public PathType PathType;

		public PathMode PathMode;

		public BBParameter<int> Resolution;

		[BlackboardOnly]
		public BBParameter<Tween> CreatedTween;

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
