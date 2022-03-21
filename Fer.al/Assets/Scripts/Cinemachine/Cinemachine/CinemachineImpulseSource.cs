using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineImpulseSourceOverview.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineImpulseSource : MonoBehaviour
	{
		[CinemachineImpulseDefinitionProperty]
		public CinemachineImpulseDefinition m_ImpulseDefinition;

		private void OnValidate()
		{
		}

		public void GenerateImpulseAt(Vector3 position, Vector3 velocity)
		{
		}

		public void GenerateImpulse(Vector3 velocity)
		{
		}

		public void GenerateImpulse(float force)
		{
		}

		public void GenerateImpulse()
		{
		}
	}
}
