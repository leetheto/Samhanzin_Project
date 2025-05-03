using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DeployUI : MonoBehaviour
{
    public GameObject unitButtonPrefab;
    public Transform unitListParent;

    public void RefreshUnits()
    {
        foreach (Transform child in unitListParent) Destroy(child.gameObject);

        foreach (var unit in UnitManager.Instance.ownedUnits)
        {
            var obj = Instantiate(unitButtonPrefab, unitListParent);
            obj.GetComponentInChildren<Text>().text = unit.unitName;
            obj.GetComponent<Button>().onClick.AddListener(() =>
            {
                UnitManager.Instance.DeployUnit(unit);
            });
        }
    }
}
