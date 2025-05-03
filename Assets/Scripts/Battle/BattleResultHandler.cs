using UnityEngine;

public static class BattleResultHandler
{
    public static void ShowWin()
    {
        Debug.Log("🏆 승리!");
        // 보상 지급 처리
    }

    public static void ShowLose()
    {
        Debug.Log("💀 패배...");
        // 패널티 또는 재시도 처리
    }
}
