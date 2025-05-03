using UnityEngine;

[CreateAssetMenu(fileName = "Skill", menuName = "Data/Skill")]
public class SkillData_SO : ScriptableObject
{
    public string skillID;
    public string skillName;
    public SkillType type;       // ✅ 여기에 'type' 추가
    public int level;
    public int power;
    public float cooldown;
    public string description;
}
