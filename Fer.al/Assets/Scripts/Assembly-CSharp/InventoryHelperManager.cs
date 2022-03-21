using System.Collections.Generic;

public class InventoryHelperManager : SingletonManagerBase<InventoryHelperManager>
{
	private List<Item> _unreadItems;

	private bool? _hasUnlockedWings;

	private bool _wingUnlockIsUnread;

	public List<Item> UnreadItems
	{
		get
		{
			return null;
		}
	}

	public bool HasUnlockedWings
	{
		get
		{
			return default(bool);
		}
	}

	public bool WingUnlockIsUnread
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public void MarkItemAsRead(Item inItem)
	{
	}

	public void MarkItemAsUnread(Item inItem)
	{
	}

	public bool ItemIsUnread(Item inItem)
	{
		return default(bool);
	}

	private void OnInventoryItemAdded(InventoryItemAddedEvent inMessage)
	{
	}

	private void OnInventoryItemRemoved(InventoryItemRemovedEvent inMessage)
	{
	}

	private void OnQuestCompleted(QuestCompletedMessage inMessage)
	{
	}

	private void OnQuestOpened(RequestQuestOpenSuccessMessage inMessage)
	{
	}
}
