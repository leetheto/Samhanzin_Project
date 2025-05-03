using UnityEngine;
using System;

public class TimerManager : MonoBehaviour
{
    public static TimerManager Instance;
    private DateTime lastLogin;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void CheckDailyReset()
    {
        string saved = PlayerPrefs.GetString("LastLogin", "");
        lastLogin = string.IsNullOrEmpty(saved) ? DateTime.Now : DateTime.Parse(saved);

        if ((DateTime.Now - lastLogin).TotalDays >= 1)
        {
            Debug.Log("일일 초기화 수행됨");
            PlayerPrefs.SetString("LastLogin", DateTime.Now.ToString());
            EventManager.Instance.TriggerDayChange();
        }
    }
}
