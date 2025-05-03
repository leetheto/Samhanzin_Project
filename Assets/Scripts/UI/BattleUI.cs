using UnityEngine;
using UnityEngine.UI;

public class BattleUI : MonoBehaviour
{
    public Slider playerHPBar;
    public Slider enemyHPBar;
    public Text battleLog;
    public BattleUnit player;
    public BattleUnit enemy;

    private void Update()
    {
        playerHPBar.value = (float)player.currentHP / player.maxHP;
        enemyHPBar.value = (float)enemy.currentHP / enemy.maxHP;
    }

    public void Log(string message)
    {
        battleLog.text += message + "\n";
    }
}
