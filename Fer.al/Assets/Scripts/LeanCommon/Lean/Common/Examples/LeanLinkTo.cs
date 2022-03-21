using UnityEngine;
using UnityEngine.EventSystems;

namespace Lean.Common.Examples
{
	[ExecuteInEditMode]
	[AddComponentMenu("Lean/Common/Lean Link To")]
	public class LeanLinkTo : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		public enum LinkType
		{
			Publisher,
			PreviousScene,
			NextScene
		}

		[SerializeField]
		private LinkType link;

		public LinkType Link
		{
			get
			{
				return default(LinkType);
			}
			set
			{
			}
		}

		protected virtual void Update()
		{
		}

		public void OnPointerClick(PointerEventData eventData)
		{
		}

		private static int GetCurrentLevel()
		{
			return default(int);
		}

		private static int GetLevelCount()
		{
			return default(int);
		}

		private static void LoadLevel(int index)
		{
		}
	}
}
