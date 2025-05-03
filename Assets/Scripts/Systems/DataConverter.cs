using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class DataConverter
{
    public static SaveData ConvertToSaveData()
    {
        var save = new SaveData();

        save.ownedUnitNames = UnitManager.Instance.ownedUnits
            .Select(u => u.unitName).ToList();

        save.completedQuestTitles = QuestManager.Instance.completedQuests
            .Select(q => q.questTitle).ToList();

        save.gold = InventoryManager.Instance.items
            .Where(i => i.itemName == "Gold")
            .Sum(i => i.value);

        return save;
    }

    public static void ApplySaveData(SaveData save, List<UnitData_SO> allUnits, List<QuestData_SO> allQuests)
    {
        foreach (var unit in allUnits)
        {
            if (save.ownedUnitNames.Contains(unit.unitName))
                UnitManager.Instance.AddUnit(unit);
        }

        foreach (var quest in allQuests)
        {
            if (save.completedQuestTitles.Contains(quest.questTitle))
                QuestManager.Instance.CompleteQuest(quest);
        }

        // 골드 복원은 간단 예시일 뿐
    }
}
