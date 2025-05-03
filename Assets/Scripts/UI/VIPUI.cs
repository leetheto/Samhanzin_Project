using UnityEngine;
using UnityEngine.UI;

public class VIPUI : MonoBehaviour
{
    public Text vipLevelText;
    public Text benefitsText;

    private void OnEnable()
    {
        int level = VIPManager.Instance.vipLevel;
        var benefits = VIPManager.Instance.GetCurrentBenefits();

        vipLevelText.text = $"VIP Lv.{level}";
        benefitsText.text = string.Join("\n", benefits);
    }
}
