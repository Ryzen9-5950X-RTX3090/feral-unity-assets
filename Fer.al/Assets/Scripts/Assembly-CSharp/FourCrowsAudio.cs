using UnityEngine;

public class FourCrowsAudio : MonoBehaviour
{
	private static FourCrowsAudio _instance;

	[Tooltip("pg_02_fourcrows_branch_move - triggered each time the branch wiggles. (i.e.crow landing on the branch )")]
	public FeralAudioInfo branchMove;

	[Tooltip("pg_02_fourcrows_card_placed - triggered when the card is placed down on the game board.")]
	public FeralAudioInfo cardPlaced;

	[Tooltip("pg_02_fourcrows_card_select -  triggered each time a card is selected out of hand.")]
	public FeralAudioInfo cardSelect;

	[Tooltip("pg_02_fourcrows_cards_retract - triggered when cards are reset or pulled back into the deck to start a new round/game.")]
	public FeralAudioInfo cardRetract;

	[Tooltip("pg_02_fourcrows_crow_banished - triggered when a crow is banished back into the void.")]
	public FeralAudioInfo crowBanished;

	[Tooltip("pg_02_fourcrows_crow_caw - triggered each time a crow spawns.This is also triggered each time the crows heads change/move positions which in this instance we will randomize how frequent they play on our end.")]
	public FeralAudioInfo crowCaw;

	[Tooltip("pg_02_fourcrows_crow_caw_death - triggered each time a crow is banished back into the void.")]
	public FeralAudioInfo crowCawDeath;

	[Tooltip("pg_02_fourcrows_crow_spawn -  triggered each time a crow is spawned onto the game board.")]
	public FeralAudioInfo crowSpawn;

	[Tooltip("pg_02_fourcrows_deal_card -  triggered for each card dealt to Kino and player at the start of the game.")]
	public FeralAudioInfo dealCard;

	[Tooltip("pg_02_fourcrows_tree_materialize - triggered for the tree smoke materializing.")]
	public FeralAudioInfo treeMaterialize;

	[Tooltip("pg_02_fourcrows_tree_materialized_lp - loop is played for the duration that the tree is present in Four Crows game.")]
	public FeralAudioInfo treeMaterializeLP;

	[Tooltip("pg_02_fourcrows_branch_reattach - triggered when tree branch begins to move on the ground reattaching itself at the start of a new game.")]
	public FeralAudioInfo branchReattach;

	[Tooltip("pg_02_fourcrows_branch_snap - triggered when tree branch snaps in two.")]
	public FeralAudioInfo branchSnap;

	[Tooltip("pg_02_fourcrows_branch_crackle - triggered when particle effect  on tree begins to flash for the branch beginning to break.")]
	public FeralAudioInfo branchCrackle;

	[Tooltip("pg_02_fourcrows_flap_vanish - triggered when crows begin to flap wings before branch breaks.")]
	public FeralAudioInfo crowFlap;

	[Tooltip("pg_02_fourcrows_tree_dematerialize. - triggered when tree begins to vanish when player exits to game menu.")]
	public FeralAudioInfo treeVanish;

	public static GameObject AudioGO
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public static void PlayBranchMove()
	{
	}

	public static void PlayCardPlaced()
	{
	}

	public static void PlayCardSelect()
	{
	}

	public static void PlayCardRetract()
	{
	}

	public static void PlayCrowBanished()
	{
	}

	public static void PlayCrowCaw()
	{
	}

	public static void PlayCrowCawDeath()
	{
	}

	public static void PlayCrowSpawn()
	{
	}

	public static void PlayDealCard()
	{
	}

	public static void PlayTreeMaterialize()
	{
	}

	public static void PlayMusic_TreeMaterialize(bool inPlay)
	{
	}

	public static void PlayBranchReattach()
	{
	}

	public static void PlayBranchSnap()
	{
	}

	public static void PlayBranchCrackle()
	{
	}

	public static void PlayCrowFlap()
	{
	}

	public static void PlayTreeVanish()
	{
	}
}
