using System.Collections;
using UnityEngine;

public static class AutoBattleHandler
{
    public static IEnumerator RunBattle(BattleUnit player, BattleUnit enemy)
    {
        BattleManager.Instance.state = BattleState.PlayerTurn;

        while (true)
        {
            // Player attacks
            int dmg = player.Attack();
            enemy.TakeDamage(dmg);
            Debug.Log($"{player.unitName} attacks {enemy.unitName} for {dmg}");

            if (enemy.IsDead)
            {
                BattleManager.Instance.state = BattleState.Win;
                BattleResultHandler.ShowWin();
                yield break;
            }

            yield return new WaitForSeconds(1f);

            // Enemy attacks
            dmg = enemy.Attack();
            player.TakeDamage(dmg);
            Debug.Log($"{enemy.unitName} attacks {player.unitName} for {dmg}");

            if (player.IsDead)
            {
                BattleManager.Instance.state = BattleState.Lose;
                BattleResultHandler.ShowLose();
                yield break;
            }

            yield return new WaitForSeconds(1f);
        }
    }
}
