using UnityEngine;
using System.Collections.Generic;

public class VIPManager : MonoBehaviour
{
    public static VIPManager Instance;

    public int vipLevel = 0;
    public int totalSpent = 0;
    public List<VIPData_SO> vipLevels;

    private void Awake()
    {
        if (Instance != null) { Destroy(gameObject); return; }
        Instance = this;
    }

    public void AddSpend(int amount)
    {
        totalSpent += amount;
        UpdateVIPLevel();
    }

    void UpdateVIPLevel()
    {
        foreach (var level in vipLevels)
        {
            if (totalSpent >= level.requiredSpend)
                vipLevel = level.vipLevel;
        }
    }

    public List<string> GetCurrentBenefits()
    {
        var vip = vipLevels.Find(v => v.vipLevel == vipLevel);
        return vip != null ? vip.benefits : new List<string>();
    }
}
