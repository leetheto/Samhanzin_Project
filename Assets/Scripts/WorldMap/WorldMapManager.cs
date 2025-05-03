using System.Collections.Generic;
using UnityEngine;

public class WorldMapManager : MonoBehaviour
{
    public List<CityInfo> allCities = new();

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
}
