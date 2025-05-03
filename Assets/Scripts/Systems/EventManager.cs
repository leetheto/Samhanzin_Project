using UnityEngine;
using System;

public class EventManager : MonoBehaviour
{
    public static EventManager Instance;

    public event Action OnLogin;
    public event Action OnServerDayPassed;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }

    public void TriggerLogin()
    {
        OnLogin?.Invoke();
    }

    public void TriggerDayChange()
    {
        GameManager.Instance.serverDay += 1;
        OnServerDayPassed?.Invoke();
    }
}
