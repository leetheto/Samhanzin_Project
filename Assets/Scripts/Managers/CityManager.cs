using UnityEngine;
using System.Collections.Generic;

public class CityManager : MonoBehaviour
{
    public static CityManager Instance;

    public List<CityData_SO> allCities;

    private void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
    }

    public void SetOwner(string cityName, Nation nation)
    {
        foreach (var city in allCities)
        {
            if (city.cityName == cityName)
            {
                city.ownerNation = nation;
                break;
            }
        }
    }

    public List<CityData_SO> GetCitiesByNation(Nation nation)
    {
        return allCities.FindAll(c => c.ownerNation == nation);
    }
}
