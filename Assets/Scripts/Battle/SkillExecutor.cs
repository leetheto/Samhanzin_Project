using UnityEngine;

public class SkillExecutor : MonoBehaviour
{
    public void ExecuteSkill(SkillData_SO skill, BattleUnit caster, BattleUnit target)
    {
        if (skill == null || caster == null || target == null) return;

        switch (skill.type)
        {
            case SkillType.Active:
                ApplyActiveSkill(skill, caster, target);
                break;
            case SkillType.Passive:
                ApplyPassiveSkill(skill, caster);
                break;
            case SkillType.Ultimate:
                ApplyUltimateSkill(skill, caster, target);
                break;
        }
    }

    void ApplyActiveSkill(SkillData_SO skill, BattleUnit caster, BattleUnit target)
    {
        int damage = caster.atk + skill.power;
        target.TakeDamage(damage);
        Debug.Log($"{caster.unitName} used {skill.skillName} on {target.unitName} for {damage} damage.");
    }

    void ApplyPassiveSkill(SkillData_SO skill, BattleUnit caster)
    {
        caster.atk += skill.power;
        Debug.Log($"{caster.unitName} gained passive skill: {skill.skillName} (ATK +{skill.power})");
    }

    void ApplyUltimateSkill(SkillData_SO skill, BattleUnit caster, BattleUnit target)
    {
        int damage = (caster.atk + skill.power) * 2;
        target.TakeDamage(damage);
        Debug.Log($"{caster.unitName} used ULTIMATE {skill.skillName} on {target.unitName} for {damage} damage!");
    }
}
