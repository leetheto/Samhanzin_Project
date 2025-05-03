using UnityEngine;
using UnityEngine.EventSystems;

public class CityClickHandler : MonoBehaviour, IPointerClickHandler
{
    public CityInfo cityInfo;

    public void OnPointerClick(PointerEventData eventData)
    {
        CityUI.Instance.ShowCityInfo(cityInfo);
    }
}
