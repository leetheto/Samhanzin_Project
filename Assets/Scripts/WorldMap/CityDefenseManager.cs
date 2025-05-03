using UnityEngine;
using System.Collections.Generic;

public class CityDefenseManager : MonoBehaviour
{
    public Dictionary<string, int> cityDefenses = new();

    public void Init(List<CityData_SO> allCities)
    {
        foreach (var city in allCities)
            cityDefenses[city.cityName] = city.defenseLevel;
    }

    public void UpgradeDefense(string cityName, int amount)
    {
        if (!cityDefenses.ContainsKey(cityName)) return;
        cityDefenses[cityName] += amount;
    }

    public int GetDefense(string cityName)
    {
        return cityDefenses.ContainsKey(cityName) ? cityDefenses[cityName] : 0;
    }
}
