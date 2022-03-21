using System.Collections.Generic;

namespace WW.iOS.Xcode.PBX
{
	internal class PBXProjectObjectData : PBXObjectData
	{
		private static PropertyCommentChecker checkerData;

		public List<ProjectReference> projectReferences;

		public List<string> targets;

		public List<string> knownAssetTags;

		public string buildConfigList;

		public string entitlementsFile;

		public List<PBXCapabilityType.TargetCapabilityPair> capabilities;

		public Dictionary<string, string> teamIDs;

		internal override PropertyCommentChecker checker
		{
			get
			{
				return null;
			}
		}

		public string mainGroup
		{
			get
			{
				return null;
			}
		}

		public void AddReference(string productGroup, string projectRef)
		{
		}

		public override void UpdateProps()
		{
		}

		public override void UpdateVars()
		{
		}
	}
}
