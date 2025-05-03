using UnityEngine;

[CreateAssetMenu(menuName = "Data/City")]
public class CityData_SO : ScriptableObject
{
    public string cityName;
    public Nation ownerNation;
    public int resourceOutput;
    public int defenseLevel;
    public bool isCapital;
}
