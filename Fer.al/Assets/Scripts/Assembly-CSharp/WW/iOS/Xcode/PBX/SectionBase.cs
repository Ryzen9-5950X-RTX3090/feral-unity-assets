using System.Text;

namespace WW.iOS.Xcode.PBX
{
	internal abstract class SectionBase
	{
		public abstract void AddObject(string key, PBXElementDict value);

		public abstract void WriteSection(StringBuilder sb, GUIDToCommentMap comments);
	}
}
