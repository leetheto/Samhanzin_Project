using System.Collections.Generic;

[System.Serializable]
public class SaveData
{
    public List<string> ownedUnitNames = new();
    public List<string> completedQuestTitles = new();
    public int gold = 0;
}
