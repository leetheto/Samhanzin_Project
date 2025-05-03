using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class SaveManager : MonoBehaviour
{
    private const string SaveKey = "GameSaveData";

    public static void SaveGame()
    {
        SaveData data = DataConverter.ConvertToSaveData();
        string json = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(SaveKey, json);
        PlayerPrefs.Save();
        Debug.Log("💾 저장 완료");
    }

    public static void LoadGame(List<UnitData_SO> allUnits, List<QuestData_SO> allQuests)
    {
        if (!PlayerPrefs.HasKey(SaveKey))
        {
            Debug.Log("세이브 데이터 없음");
            return;
        }

        string json = PlayerPrefs.GetString(SaveKey);
        SaveData data = JsonUtility.FromJson<SaveData>(json);
        DataConverter.ApplySaveData(data, allUnits, allQuests);
        Debug.Log("📂 불러오기 완료");
    }

    public static void ResetData()
    {
        PlayerPrefs.DeleteKey(SaveKey);
        Debug.Log("⚠️ 데이터 초기화됨");
    }
}
