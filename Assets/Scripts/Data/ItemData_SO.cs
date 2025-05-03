using UnityEngine;

[CreateAssetMenu(menuName = "Data/Item")]
public class ItemData_SO : ScriptableObject
{
    public string itemID;
    public string itemName;
    public ItemType itemType;
    public Rarity rarity;
    public Sprite icon;
    public int value;
    public string setName;
    public EquipmentType equipType;
}
