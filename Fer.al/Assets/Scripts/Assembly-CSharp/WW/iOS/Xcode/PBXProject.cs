using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using WW.iOS.Xcode.PBX;

namespace WW.iOS.Xcode
{
	public class PBXProject
	{
		private PBXProjectData m_Data;

		internal KnownSectionBase<PBXContainerItemProxyData> containerItems
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXReferenceProxyData> references
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXSourcesBuildPhaseData> sources
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXFrameworksBuildPhaseData> frameworks
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXResourcesBuildPhaseData> resources
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXCopyFilesBuildPhaseData> copyFiles
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXShellScriptBuildPhaseData> shellScripts
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXNativeTargetData> nativeTargets
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXTargetDependencyData> targetDependencies
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<PBXVariantGroupData> variantGroups
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<XCBuildConfigurationData> buildConfigs
		{
			get
			{
				return null;
			}
		}

		internal KnownSectionBase<XCConfigurationListData> buildConfigLists
		{
			get
			{
				return null;
			}
		}

		internal PBXProjectSection project
		{
			get
			{
				return null;
			}
		}

		internal PBXBuildFileData BuildFilesGet(string guid)
		{
			return null;
		}

		internal void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile)
		{
		}

		internal void BuildFilesRemove(string targetGuid, string fileGuid)
		{
		}

		internal PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid)
		{
			return null;
		}

		internal IEnumerable<PBXBuildFileData> BuildFilesGetAll()
		{
			return null;
		}

		internal void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef)
		{
		}

		internal PBXFileReferenceData FileRefsGet(string guid)
		{
			return null;
		}

		internal PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree)
		{
			return null;
		}

		internal PBXFileReferenceData FileRefsGetByProjectPath(string path)
		{
			return null;
		}

		internal void FileRefsRemove(string guid)
		{
		}

		internal PBXGroupData GroupsGet(string guid)
		{
			return null;
		}

		internal PBXGroupData GroupsGetByChild(string childGuid)
		{
			return null;
		}

		internal PBXGroupData GroupsGetMainGroup()
		{
			return null;
		}

		internal PBXGroupData GroupsGetByProjectPath(string sourceGroup)
		{
			return null;
		}

		internal void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr)
		{
		}

		internal void GroupsAddDuplicate(PBXGroupData gr)
		{
		}

		internal void GroupsRemove(string guid)
		{
		}

		internal FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef)
		{
			return null;
		}

		internal FileGUIDListBase BuildSectionAny(string sectionGuid)
		{
			return null;
		}

		public static string GetPBXProjectPath(string buildPath)
		{
			return null;
		}

		public static string GetUnityTargetName()
		{
			return null;
		}

		public static string GetUnityTestTargetName()
		{
			return null;
		}

		public string ProjectGuid()
		{
			return null;
		}

		public string TargetGuidByName(string name)
		{
			return null;
		}

		public static bool IsKnownExtension(string ext)
		{
			return default(bool);
		}

		public static bool IsBuildable(string ext)
		{
			return default(bool);
		}

		private string AddFileImpl(string path, string projectPath, PBXSourceTree tree, bool isFolderReference)
		{
			return null;
		}

		public string AddFile(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source)
		{
			return null;
		}

		public string AddFolderReference(string path, string projectPath, PBXSourceTree sourceTree = PBXSourceTree.Source)
		{
			return null;
		}

		private void AddBuildFileImpl(string targetGuid, string fileGuid, bool weak, string compileFlags)
		{
		}

		public void AddFileToBuild(string targetGuid, string fileGuid)
		{
		}

		public void AddFileToBuildWithFlags(string targetGuid, string fileGuid, string compileFlags)
		{
		}

		public void AddFileToBuildSection(string targetGuid, string sectionGuid, string fileGuid)
		{
		}

		public List<string> GetCompileFlagsForFile(string targetGuid, string fileGuid)
		{
			return null;
		}

		public void SetCompileFlagsForFile(string targetGuid, string fileGuid, List<string> compileFlags)
		{
		}

		public void AddAssetTagForFile(string targetGuid, string fileGuid, string tag)
		{
		}

		public void RemoveAssetTagForFile(string targetGuid, string fileGuid, string tag)
		{
		}

		public void AddAssetTagToDefaultInstall(string targetGuid, string tag)
		{
		}

		public void RemoveAssetTagFromDefaultInstall(string targetGuid, string tag)
		{
		}

		public void RemoveAssetTag(string tag)
		{
		}

		public bool ContainsFileByRealPath(string path)
		{
			return default(bool);
		}

		public bool ContainsFileByRealPath(string path, PBXSourceTree sourceTree)
		{
			return default(bool);
		}

		public bool ContainsFileByProjectPath(string path)
		{
			return default(bool);
		}

		public bool ContainsFramework(string targetGuid, string framework)
		{
			return default(bool);
		}

		public void AddFrameworkToProject(string targetGuid, string framework, bool weak)
		{
		}

		public void RemoveFrameworkFromProject(string targetGuid, string framework)
		{
		}

		public bool AddCapability(string targetGuid, PBXCapabilityType capability, [Optional] string entitlementsFilePath, bool addOptionalFramework = false)
		{
			return default(bool);
		}

		public void SetTeamId(string targetGuid, string teamId)
		{
		}

		public string FindFileGuidByRealPath(string path, PBXSourceTree sourceTree)
		{
			return null;
		}

		public string FindFileGuidByRealPath(string path)
		{
			return null;
		}

		public string FindFileGuidByProjectPath(string path)
		{
			return null;
		}

		public void RemoveFileFromBuild(string targetGuid, string fileGuid)
		{
		}

		public void RemoveFile(string fileGuid)
		{
		}

		private void RemoveGroupIfEmpty(PBXGroupData gr)
		{
		}

		private void RemoveGroupChildrenRecursive(PBXGroupData parent)
		{
		}

		internal void RemoveFilesByProjectPathRecursive(string projectPath)
		{
		}

		internal List<string> GetGroupChildrenFiles(string projectPath)
		{
			return null;
		}

		internal HashSet<string> GetGroupChildrenFilesRefs(string projectPath)
		{
			return null;
		}

		internal HashSet<string> GetFileRefsByProjectPaths(IEnumerable<string> paths)
		{
			return null;
		}

		private PBXGroupData GetPBXGroupChildByName(PBXGroupData group, string name)
		{
			return null;
		}

		private PBXGroupData CreateSourceGroup(string sourceGroup)
		{
			return null;
		}

		internal void AddExternalProjectDependency(string path, string projectPath, PBXSourceTree sourceTree)
		{
		}

		internal void AddExternalLibraryDependency(string targetGuid, string filename, string remoteFileGuid, string projectPath, string remoteInfo)
		{
		}

		public string AddTarget(string name, string ext, string type)
		{
			return null;
		}

		private IEnumerable<string> GetAllTargetGuids()
		{
			return null;
		}

		public string GetTargetProductFileRef(string targetGuid)
		{
			return null;
		}

		internal void AddTargetDependency(string targetGuid, string targetDependencyGuid)
		{
		}

		private string AddBuildConfigForTarget(string targetGuid, string name)
		{
			return null;
		}

		private void RemoveBuildConfigForTarget(string targetGuid, string name)
		{
		}

		public string BuildConfigByName(string targetGuid, string name)
		{
			return null;
		}

		public IEnumerable<string> BuildConfigNames()
		{
			return null;
		}

		public void AddBuildConfig(string name)
		{
		}

		public void RemoveBuildConfig(string name)
		{
		}

		public string AddSourcesBuildPhase(string targetGuid)
		{
			return null;
		}

		public string AddResourcesBuildPhase(string targetGuid)
		{
			return null;
		}

		public string AddFrameworksBuildPhase(string targetGuid)
		{
			return null;
		}

		public string AddCopyFilesBuildPhase(string targetGuid, string name, string dstPath, string subfolderSpec)
		{
			return null;
		}

		internal string GetConfigListForTarget(string targetGuid)
		{
			return null;
		}

		internal void SetBaseReferenceForConfig(string configGuid, string baseReference)
		{
		}

		public void AddBuildProperty(string targetGuid, string name, string value)
		{
		}

		public void AddBuildProperty(IEnumerable<string> targetGuids, string name, string value)
		{
		}

		public void AddBuildPropertyForConfig(string configGuid, string name, string value)
		{
		}

		public void AddBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value)
		{
		}

		public void SetBuildProperty(string targetGuid, string name, string value)
		{
		}

		public void SetBuildProperty(IEnumerable<string> targetGuids, string name, string value)
		{
		}

		public void SetBuildPropertyForConfig(string configGuid, string name, string value)
		{
		}

		public void SetBuildPropertyForConfig(IEnumerable<string> configGuids, string name, string value)
		{
		}

		internal void RemoveBuildProperty(string targetGuid, string name)
		{
		}

		internal void RemoveBuildProperty(IEnumerable<string> targetGuids, string name)
		{
		}

		internal void RemoveBuildPropertyForConfig(string configGuid, string name)
		{
		}

		internal void RemoveBuildPropertyForConfig(IEnumerable<string> configGuids, string name)
		{
		}

		internal void RemoveBuildPropertyValueList(string targetGuid, string name, IEnumerable<string> valueList)
		{
		}

		internal void RemoveBuildPropertyValueList(IEnumerable<string> targetGuids, string name, IEnumerable<string> valueList)
		{
		}

		internal void RemoveBuildPropertyValueListForConfig(string configGuid, string name, IEnumerable<string> valueList)
		{
		}

		internal void RemoveBuildPropertyValueListForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> valueList)
		{
		}

		public void UpdateBuildProperty(string targetGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues)
		{
		}

		public void UpdateBuildProperty(IEnumerable<string> targetGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues)
		{
		}

		public void UpdateBuildPropertyForConfig(string configGuid, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues)
		{
		}

		public void UpdateBuildPropertyForConfig(IEnumerable<string> configGuids, string name, IEnumerable<string> addValues, IEnumerable<string> removeValues)
		{
		}

		internal string ShellScriptByName(string targetGuid, string name)
		{
			return null;
		}

		internal void AppendShellScriptBuildPhase(string targetGuid, string name, string shellPath, string shellScript)
		{
		}

		internal void AppendShellScriptBuildPhase(IEnumerable<string> targetGuids, string name, string shellPath, string shellScript)
		{
		}

		public void ReadFromFile(string path)
		{
		}

		public void ReadFromString(string src)
		{
		}

		public void ReadFromStream(TextReader sr)
		{
		}

		public void WriteToFile(string path)
		{
		}

		public void WriteToStream(TextWriter sw)
		{
		}

		public string WriteToString()
		{
			return null;
		}

		internal PBXProjectObjectData GetProjectInternal()
		{
			return null;
		}

		internal void SetTargetAttributes(string key, string value)
		{
		}
	}
}
