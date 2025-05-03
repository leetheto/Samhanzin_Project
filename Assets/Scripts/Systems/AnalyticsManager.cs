using UnityEngine;

public class AnalyticsManager : MonoBehaviour
{
    public static AnalyticsManager Instance;

    private void Awake()
    {
        if (Instance != null) Destroy(gameObject);
        Instance = this;
    }

    public void LogEvent(string eventName, string value)
    {
        Debug.Log($"[통계] {eventName}: {value}");
    }

    public void TrackCurrency(string type, int amount)
    {
        Debug.Log($"[통계] 자원변동 - {type}: {amount}");
    }
}
