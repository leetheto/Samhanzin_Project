using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Unit")]
public class UnitData_SO : ScriptableObject
{
    public string unitID;
    public string unitName;
    public Sprite portrait;
    public Nation nation;
    public Rarity rarity;

    public int baseHP;
    public int baseATK;
    public int baseDEF;

    public EquipmentType weapon;
    public EquipmentType armor;

    public List<SkillData_SO> activeSkills;
    public List<SkillData_SO> passiveSkills;

    public bool isDeployed;
    public FormationType formation;
}
