using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public Dictionary<string, int> itemInventory = new(); // itemID → 수량

    // ✅ DataConverter 호환용 필드 (더미 리스트)
    public List<ItemData_SO> items = new(); // 에러만 잡기 위한 래핑. 사용 시 주의.

    private void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
    }

    public void AddItem(string itemID, int amount)
    {
        if (itemInventory.ContainsKey(itemID))
            itemInventory[itemID] += amount;
        else
            itemInventory[itemID] = amount;
    }

    public bool HasItem(string itemID, int amount)
    {
        return itemInventory.ContainsKey(itemID) && itemInventory[itemID] >= amount;
    }

    public void UseItem(string itemID, int amount)
    {
        if (!HasItem(itemID, amount)) return;
        itemInventory[itemID] -= amount;
    }
}
