using UnityEngine;

namespace StrayTech.CustomAttributes
{
	public class PathAttribute : PropertyAttribute
	{
		public enum SelectionType
		{
			Folder,
			File
		}

		public readonly SelectionType PathType;

		public readonly string FileExtension;

		public readonly bool RelativeToAssetsFolder;

		public PathAttribute(string fileExtension, bool relativeToAssetsFolder = false)
		{
		}

		public PathAttribute(SelectionType pathType, bool relativeToAssetsFolder = false)
		{
		}

		public PathAttribute(bool relativeToAssetsFolder = false)
		{
		}
	}
}
