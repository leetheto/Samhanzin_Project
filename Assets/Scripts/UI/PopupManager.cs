using UnityEngine;
using System.Collections.Generic;

public class PopupManager : MonoBehaviour
{
    public static PopupManager Instance;

    private Stack<GameObject> popupStack = new();

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }

    public void ShowPopup(GameObject popup)
    {
        popup.SetActive(true);
        popupStack.Push(popup);
    }

    public void CloseTopPopup()
    {
        if (popupStack.Count == 0) return;

        var top = popupStack.Pop();
        top.SetActive(false);
    }

    public void CloseAll()
    {
        while (popupStack.Count > 0)
            popupStack.Pop().SetActive(false);
    }
}
