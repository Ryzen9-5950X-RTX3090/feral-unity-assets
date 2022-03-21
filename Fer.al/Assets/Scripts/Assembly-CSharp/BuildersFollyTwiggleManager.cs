using System.Collections.Generic;

public class BuildersFollyTwiggleManager : MonoBehaviour
{
	public int cachedTwiggleCount;

	public BuildersFollyTwiggle twigglePrefab;

	internal List<BuildersFollyData.BuildersFollyPath> paths;

	internal bool levelEnded;

	internal List<BuildersFollyTwiggle> activeTwiggles;

	private List<BuildersFollyTwiggle> _cachedTwiggles;

	private BuildersFollyGame _game;

	private void Start()
	{
	}

	private void SpawnTwiggle()
	{
	}

	internal void SetupTwiggleManager(List<BuildersFollyData.BuildersFollyPath> inPaths)
	{
	}

	internal void ActivateTwiggles()
	{
	}

	internal void ClearTwiggles()
	{
	}

	private BuildersFollyTwiggle NeedsExitTwiggle(BuildersFollyData.Station inStation, int inIgnorePathIndex)
	{
		return null;
	}

	internal void StationPortChq(BuildersFollyData.Station inStation)
	{
	}

	internal void Celebrate(BuildersFollyTwiggle inTwiggle, BuildersFollyTwiggle.ECelebrateType inCelebrateType)
	{
	}

	internal void StationBuildComplete(BuildersFollyData.Station inputStation)
	{
	}

	internal bool EndLevelChq()
	{
		return default(bool);
	}

	internal void UpdateTwigglesMove()
	{
	}

	internal void UpdateTwiggleUnitMove()
	{
	}
}
