namespace WW.iOS.Xcode.PBX
{
	internal class PBXShellScriptBuildPhaseData : FileGUIDListBase
	{
		public string name;

		public string shellPath;

		public string shellScript;

		public static PBXShellScriptBuildPhaseData Create(string name, string shellPath, string shellScript)
		{
			return null;
		}

		public override void UpdateProps()
		{
		}

		public override void UpdateVars()
		{
		}
	}
}
