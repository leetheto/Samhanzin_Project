using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class ShopUI : MonoBehaviour
{
    public GameObject itemPrefab;
    public Transform itemListParent;

    public void RefreshShop()
    {
        foreach (Transform child in itemListParent) Destroy(child.gameObject);

        var items = ShopManager.Instance.GetAvailableItems();

        foreach (var item in items)
        {
            var obj = Instantiate(itemPrefab, itemListParent);
            obj.GetComponentInChildren<Text>().text = item.item.itemName;
            obj.GetComponent<Button>().onClick.AddListener(() =>
            {
                ShopManager.Instance.PurchaseItem(item);
                RefreshShop();
            });
        }
    }
}
