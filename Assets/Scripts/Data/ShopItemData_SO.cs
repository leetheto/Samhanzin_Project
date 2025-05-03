using UnityEngine;

[CreateAssetMenu(menuName = "Data/ShopItem")]
public class ShopItemData_SO : ScriptableObject
{
    public string itemID;
    public ItemData_SO item;
    public PurchaseType purchaseType;
    public int price;
    public int openDay;
    public bool isOneTimePurchase;
}
