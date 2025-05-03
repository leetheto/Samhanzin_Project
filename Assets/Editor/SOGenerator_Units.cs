#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;

public class SOGenerator_Units
{
    [MenuItem("Tools/Generate Unit SOs")]
    public static void GenerateUnits()
    {
        string path = "Assets/Resources/Units/";
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

        for (int i = 1; i <= 300; i++)
        {
            var unit = ScriptableObject.CreateInstance<UnitData_SO>();
            unit.unitID = $"HR_{i:000}";
            unit.unitName = $"장수 {i}";
            unit.nation = (Nation)(i % 3);
            unit.rarity = (Rarity)(Random.Range(0, 5));
            unit.baseHP = Random.Range(1000, 3000);
            unit.baseATK = Random.Range(100, 500);
            unit.baseDEF = Random.Range(50, 200);
            unit.formation = (FormationType)(i % 3);

            string assetPath = $"{path}HR_{i:000}.asset";
            AssetDatabase.CreateAsset(unit, assetPath);
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("✅ 300명의 장수 SO 생성 완료");
    }
}
#endif
