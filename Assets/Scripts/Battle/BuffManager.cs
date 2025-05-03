using System.Collections.Generic;
using UnityEngine;

public class BuffManager : MonoBehaviour
{
    private Dictionary<BattleUnit, List<Buff>> activeBuffs = new();

    public void ApplyBuff(BattleUnit unit, Buff buff)
    {
        if (!activeBuffs.ContainsKey(unit))
            activeBuffs[unit] = new List<Buff>();

        activeBuffs[unit].Add(buff);
    }

    public void Tick()
    {
        foreach (var unit in activeBuffs.Keys)
        {
            foreach (var buff in activeBuffs[unit])
            {
                buff.duration--;
                buff.Apply(unit);
            }

            activeBuffs[unit].RemoveAll(b => b.duration <= 0);
        }
    }
}

[System.Serializable]
public class Buff
{
    public string name;
    public int duration;
    public int atkModifier;
    public int defModifier;

    public void Apply(BattleUnit unit)
    {
        unit.atk += atkModifier;
        unit.baseDEF += defModifier;
    }
}
