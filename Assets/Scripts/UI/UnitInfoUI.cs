using UnityEngine;
using UnityEngine.UI;

public class UnitInfoUI : MonoBehaviour
{
    public Text nameText;
    public Image portrait;
    public Text statsText;

    public void ShowUnit(UnitData_SO unit)
    {
        nameText.text = unit.unitName;
        portrait.sprite = unit.portrait;
        statsText.text = $"HP: {unit.baseHP}\nATK: {unit.baseATK}\nDEF: {unit.baseDEF}";
    }
}
