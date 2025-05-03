using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    public static QuestManager Instance;

    public List<QuestData_SO> activeQuests = new();
    public List<QuestData_SO> completedQuests = new();

    private void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
    }

    public void AcceptQuest(QuestData_SO quest)
    {
        if (!activeQuests.Contains(quest))
            activeQuests.Add(quest);
    }

    public void CompleteQuest(QuestData_SO quest)
    {
        if (activeQuests.Contains(quest))
        {
            activeQuests.Remove(quest);
            completedQuests.Add(quest);

            // 보상 지급
            foreach (var reward in quest.rewards)
            {
                InventoryManager.Instance.AddItem(reward.itemID, reward.value);
            }

            if (quest.isRepeatable)
                AcceptQuest(quest);
        }
    }
}
