using UnityEngine;
using System.Collections.Generic;

public class GachaManager : MonoBehaviour
{
    public List<UnitData_SO> allUnits;

    public UnitData_SO Roll(int currentDay)
    {
        List<UnitData_SO> available = new();

        foreach (var unit in allUnits)
        {
            if (unit.rarity == Rarity.UR && currentDay < 60) continue;
            if (unit.rarity == Rarity.SSR && currentDay < 30) continue;
            if (unit.rarity == Rarity.SR && currentDay < 10) continue;
            available.Add(unit);
        }

        int index = Random.Range(0, available.Count);
        UnitManager.Instance.AddUnit(available[index]);
        return available[index];
    }
}
