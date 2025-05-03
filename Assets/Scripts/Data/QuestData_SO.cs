using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Data/Quest")]
public class QuestData_SO : ScriptableObject
{
    public string questID;

    // 🔧 기존 이름 → 에러난 코드에 맞춰 필드 추가만
    public string title;
    public string description;

    // ✅ DataConverter에서 요구하는 필드 보완
    public string questTitle => title;
    public string questDescription => description;

    public bool isRepeatable;
    public List<string> conditions;
    public List<ItemData_SO> rewards;
}
