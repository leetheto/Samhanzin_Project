using UnityEngine;
using UnityEngine.UI;

public class CityUI : MonoBehaviour
{
    public static CityUI Instance;

    public GameObject panel;
    public Text cityNameText;
    public Text nationText;

    private void Awake()
    {
        Instance = this;
        panel.SetActive(false);
    }

    public void ShowCityInfo(CityInfo info)
    {
        panel.SetActive(true);
        cityNameText.text = info.cityName;
        nationText.text = info.ownerNation.ToString();
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
