using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public static UnitManager Instance;

    public List<UnitData_SO> ownedUnits = new();
    public List<UnitData_SO> deployedUnits = new();

    private void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
    }

    public void AddUnit(UnitData_SO unit)
    {
        if (!ownedUnits.Contains(unit))
            ownedUnits.Add(unit);
    }

    public void DeployUnit(UnitData_SO unit)
    {
        if (ownedUnits.Contains(unit) && !deployedUnits.Contains(unit))
        {
            deployedUnits.Add(unit);
            unit.isDeployed = true;
        }
    }

    public void RemoveDeployed(UnitData_SO unit)
    {
        if (deployedUnits.Contains(unit))
        {
            deployedUnits.Remove(unit);
            unit.isDeployed = false;
        }
    }
}
