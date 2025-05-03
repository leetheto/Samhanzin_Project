using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIController : MonoBehaviour
{
    public GameObject panel;
    public Button openButton;
    public Button closeButton;

    private void Start()
    {
        openButton?.onClick.AddListener(ShowPanel);
        closeButton?.onClick.AddListener(HidePanel);
        panel.SetActive(false);
    }

    public void ShowPanel()
    {
        panel.SetActive(true);
        panel.transform.localScale = Vector3.zero;
        panel.transform.DOScale(1f, 0.3f).SetEase(Ease.OutBack);
    }

    public void HidePanel()
    {
        panel.transform.DOScale(0f, 0.2f).SetEase(Ease.InBack)
            .OnComplete(() => panel.SetActive(false));
    }
}
