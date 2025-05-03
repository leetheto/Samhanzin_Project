using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "Data/VIP Level")]
public class VIPData_SO : ScriptableObject
{
    public int vipLevel;
    public int requiredSpend;
    public List<string> benefits;
}
