using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public static ShopManager Instance;

    public List<ShopItemData_SO> allShopItems;
    public List<string> purchasedItemIDs = new();

    private void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
    }

    public List<ShopItemData_SO> GetAvailableItems()
    {
        int day = GameManager.Instance.serverDay;

        List<ShopItemData_SO> available = new();
        foreach (var item in allShopItems)
        {
            if (item.openDay <= day && (!item.isOneTimePurchase || !purchasedItemIDs.Contains(item.itemID)))
                available.Add(item);
        }
        return available;
    }

    public void PurchaseItem(ShopItemData_SO item)
    {
        if (!GetAvailableItems().Contains(item)) return;

        InventoryManager.Instance.AddItem(item.item.itemID, 1);

        if (item.isOneTimePurchase)
            purchasedItemIDs.Add(item.itemID);
    }
}
