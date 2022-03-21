using System.Collections.Generic;
using MimicJava;

public class Match3DebugUtils : MonoBehaviour
{
	public class SavedBoardState
	{
		public byte[,] grid;

		public int moveCount;

		public long javaRandomHashedSeed;

		public SavedBoardState(Match3GameBoard inBoard, JavaRandom inJavaRandom)
		{
		}
	}

	private const string _match3GroupName = "Minigame/Match3";

	public Match3GameBoard gameBoard;

	private List<SavedBoardState> _states;

	private Match3GameBoard GameBoard
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void PushBoardState(JavaRandom inJavaRandom)
	{
	}

	public void PopBoardState()
	{
	}

	public static byte TileToByte(Match3GameBoard inGameBoard, Match3Tile inTile)
	{
		return default(byte);
	}

	public static Match3Tile ByteToTile(Match3GameBoard inGameBoard, byte inByte)
	{
		return null;
	}
}
