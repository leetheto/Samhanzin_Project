using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class QuestUI : MonoBehaviour
{
    public GameObject questItemPrefab;
    public Transform questListParent;

    public void RefreshQuests(List<QuestData_SO> questList)
    {
        foreach (Transform child in questListParent) Destroy(child.gameObject);

        foreach (var quest in questList)
        {
            var obj = Instantiate(questItemPrefab, questListParent);
            obj.GetComponentInChildren<Text>().text = quest.title;
            obj.GetComponent<Button>().onClick.AddListener(() =>
            {
                QuestManager.Instance.CompleteQuest(quest);
                RefreshQuests(QuestManager.Instance.activeQuests);
            });
        }
    }
}
