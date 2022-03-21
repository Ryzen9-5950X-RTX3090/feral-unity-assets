using System;
using System.Collections.Generic;
using System.IO;
using WW.iOS.Xcode.PBX;

namespace WW.iOS.Xcode
{
	internal class PBXProjectData
	{
		private Dictionary<string, SectionBase> m_Section;

		private PBXElementDict m_RootElements;

		private PBXElementDict m_UnknownObjects;

		private string m_ObjectVersion;

		private List<string> m_SectionOrder;

		private Dictionary<string, KnownSectionBase<PBXObjectData>> m_UnknownSections;

		private KnownSectionBase<PBXBuildFileData> buildFiles;

		private KnownSectionBase<PBXFileReferenceData> fileRefs;

		private KnownSectionBase<PBXGroupData> groups;

		public KnownSectionBase<PBXContainerItemProxyData> containerItems;

		public KnownSectionBase<PBXReferenceProxyData> references;

		public KnownSectionBase<PBXSourcesBuildPhaseData> sources;

		public KnownSectionBase<PBXFrameworksBuildPhaseData> frameworks;

		public KnownSectionBase<PBXResourcesBuildPhaseData> resources;

		public KnownSectionBase<PBXCopyFilesBuildPhaseData> copyFiles;

		public KnownSectionBase<PBXShellScriptBuildPhaseData> shellScripts;

		public KnownSectionBase<PBXNativeTargetData> nativeTargets;

		public KnownSectionBase<PBXTargetDependencyData> targetDependencies;

		public KnownSectionBase<PBXVariantGroupData> variantGroups;

		public KnownSectionBase<XCBuildConfigurationData> buildConfigs;

		public KnownSectionBase<XCConfigurationListData> buildConfigLists;

		public PBXProjectSection project;

		private Dictionary<string, Dictionary<string, PBXBuildFileData>> m_FileGuidToBuildFileMap;

		private Dictionary<string, PBXFileReferenceData> m_ProjectPathToFileRefMap;

		private Dictionary<string, string> m_FileRefGuidToProjectPathMap;

		private Dictionary<PBXSourceTree, Dictionary<string, PBXFileReferenceData>> m_RealPathToFileRefMap;

		private Dictionary<string, PBXGroupData> m_ProjectPathToGroupMap;

		private Dictionary<string, string> m_GroupGuidToProjectPathMap;

		private Dictionary<string, PBXGroupData> m_GuidToParentGroupMap;

		public PBXBuildFileData BuildFilesGet(string guid)
		{
			return null;
		}

		public void BuildFilesAdd(string targetGuid, PBXBuildFileData buildFile)
		{
		}

		public void BuildFilesRemove(string targetGuid, string fileGuid)
		{
		}

		public PBXBuildFileData BuildFilesGetForSourceFile(string targetGuid, string fileGuid)
		{
			return null;
		}

		public IEnumerable<PBXBuildFileData> BuildFilesGetAll()
		{
			return null;
		}

		public void FileRefsAdd(string realPath, string projectPath, PBXGroupData parent, PBXFileReferenceData fileRef)
		{
		}

		public PBXFileReferenceData FileRefsGet(string guid)
		{
			return null;
		}

		public PBXFileReferenceData FileRefsGetByRealPath(string path, PBXSourceTree sourceTree)
		{
			return null;
		}

		public PBXFileReferenceData FileRefsGetByProjectPath(string path)
		{
			return null;
		}

		public void FileRefsRemove(string guid)
		{
		}

		public PBXGroupData GroupsGet(string guid)
		{
			return null;
		}

		public PBXGroupData GroupsGetByChild(string childGuid)
		{
			return null;
		}

		public PBXGroupData GroupsGetMainGroup()
		{
			return null;
		}

		public PBXGroupData GroupsGetByProjectPath(string sourceGroup)
		{
			return null;
		}

		public void GroupsAdd(string projectPath, PBXGroupData parent, PBXGroupData gr)
		{
		}

		public void GroupsAddDuplicate(PBXGroupData gr)
		{
		}

		public void GroupsRemove(string guid)
		{
		}

		public FileGUIDListBase BuildSectionAny(PBXNativeTargetData target, string path, bool isFolderRef)
		{
			return null;
		}

		public FileGUIDListBase BuildSectionAny(string sectionGuid)
		{
			return null;
		}

		private void RefreshBuildFilesMapForBuildFileGuidList(Dictionary<string, PBXBuildFileData> mapForTarget, FileGUIDListBase list)
		{
		}

		private void RefreshMapsForGroupChildren(string projectPath, string realPath, PBXSourceTree realPathTree, PBXGroupData parent)
		{
		}

		private void RefreshAuxMaps()
		{
		}

		public void Clear()
		{
		}

		private void BuildCommentMapForBuildFiles(GUIDToCommentMap comments, List<string> guids, string sectName)
		{
		}

		private GUIDToCommentMap BuildCommentMap()
		{
			return null;
		}

		private static PBXElementDict ParseContent(string content)
		{
			return null;
		}

		public void ReadFromStream(TextReader sr)
		{
		}

		public string WriteToString()
		{
			return null;
		}

		private void RepairStructure(List<string> allGuids)
		{
		}

		private static void RemoveMissingGuidsFromGuidList(GUIDList guidList, Dictionary<string, bool> allGuids)
		{
		}

		private static bool RemoveObjectsFromSection<T>(KnownSectionBase<T> section, Dictionary<string, bool> allGuids, Func<T, bool> checker) where T : PBXObjectData, new()
		{
			return default(bool);
		}

		private bool RepairStructureImpl(Dictionary<string, bool> allGuids)
		{
			return default(bool);
		}
	}
}
