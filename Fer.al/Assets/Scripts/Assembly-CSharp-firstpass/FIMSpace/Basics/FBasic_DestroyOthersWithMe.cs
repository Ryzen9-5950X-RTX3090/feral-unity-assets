using System.Collections.Generic;
using UnityEngine;

namespace FIMSpace.Basics
{
	public class FBasic_DestroyOthersWithMe : MonoBehaviour
	{
		private List<Object> ToDestroyAfterDestroy;

		public void AddToDestroy(Object obj)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
