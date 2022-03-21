using System.Runtime.CompilerServices;

public class SpawnerReadyMessage : IngredientMessage
{
	public CodeColorSpawner Spawner
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public SpawnerReadyMessage(CodeColorSpawner inSpawner, CodeBreakerIngredient inIngredient)
	{
	}
}
