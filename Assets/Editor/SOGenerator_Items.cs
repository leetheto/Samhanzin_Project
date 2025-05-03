#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.IO;

public static class SOGenerator_Items
{
    [MenuItem("Tools/Generate Item SOs")]
    public static void GenerateItems()
    {
        string path = "Assets/Resources/Items/";
        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

        for (int i = 1; i <= 2500; i++)
        {
            var item = ScriptableObject.CreateInstance<ItemData_SO>();
            item.itemID = $"IT_{i:0000}";
            item.itemName = $"아이템 {i}";
            item.itemType = (ItemType)(i % 3);
            item.rarity = (Rarity)(Random.Range(0, 5));
            item.value = Random.Range(1, 100);
            item.equipType = (EquipmentType)(i % 2);

            string assetPath = $"{path}IT_{i:0000}.asset";
            AssetDatabase.CreateAsset(item, assetPath);
        }

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log("✅ 2500개의 아이템 SO 생성 완료");
    }
}
#endif
