using System.Collections.Generic;

public class Quest
{
    public int ID { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public List<QuestCompletionItem> QuestCompletionItems { get; private set; }
    public int RewardGold { get; private set; }
    public int RewardExperience { get; private set; }

    public Quest(int id, string name, string description, List<QuestCompletionItem> questCompletionItems, int rewardGold, int rewardExperience)
    {
        ID = id;
        Name = name;
        Description = description;
        QuestCompletionItems = questCompletionItems;
        RewardGold = rewardGold;
        RewardExperience = rewardExperience;
    }
}

public class QuestCompletionItem
{
    public Monster RequiredMonster { get; private set; }
    public int Quantity { get; private set; }

    public QuestCompletionItem(Monster requiredMonster, int quantity)
    {
        RequiredMonster = requiredMonster;
        Quantity = quantity;
    }
}
