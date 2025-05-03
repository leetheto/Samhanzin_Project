using UnityEngine;
using System.Collections.Generic;

public class FormationManager : MonoBehaviour
{
    public List<BattleUnit> frontLine = new();
    public List<BattleUnit> middleLine = new();
    public List<BattleUnit> rearLine = new();

    public void AssignUnit(BattleUnit unit, FormationType type)
    {
        switch (type)
        {
            case FormationType.Front: frontLine.Add(unit); break;
            case FormationType.Middle: middleLine.Add(unit); break;
            case FormationType.Rear: rearLine.Add(unit); break;
        }
    }
}
