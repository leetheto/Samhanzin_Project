#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;

public class SkillGenerator
{
    [MenuItem("Tools/Generate Skills (100 장수용)")]
    public static void GenerateSkills()
    {
        string skillPath = "Assets/Resources/Skills/";
        if (!Directory.Exists(skillPath))
            Directory.CreateDirectory(skillPath);

        string[] grade = { "N", "R", "SR", "SSR", "UR" };
        SkillType[] types = { SkillType.Passive, SkillType.Passive, SkillType.Active };

        for (int i = 1; i <= 100; i++)
        {
            string unitName = $"장수_{i:D3}";

            for (int j = 0; j < types.Length; j++)
            {
                var skill = ScriptableObject.CreateInstance<SkillData_SO>();

                skill.skillID = $"SKL_{i:D3}_{j}";
                skill.skillName = $"{unitName}_스킬{j + 1}";
                skill.skillType = types[j];
                skill.level = 1;

                // 등급 적용
                int gradeIndex = Mathf.Min(i / 20, 4);
                skill.power = 10 + (gradeIndex * 20) + j * 5;
                skill.cooldown = types[j] == SkillType.Active ? 10f - (gradeIndex * 1f) : 0f;
                skill.description = $"{unitName}의 {types[j]} 스킬 (등급: {grade[gradeIndex]})";

                // 저장
                string assetPath = $"{skillPath}{skill.skillID}.asset";
                AssetDatabase.CreateAsset(skill, assetPath);
            }
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log("✅ 100명의 장수 스킬 (300개) 자동 생성 완료!");
    }
}
#endif
