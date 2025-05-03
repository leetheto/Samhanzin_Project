using UnityEngine;

public enum BattleState { Idle, Start, PlayerTurn, EnemyTurn, Win, Lose }

public class BattleFSM : MonoBehaviour
{
    public BattleState state;

    public void SetState(BattleState newState)
    {
        state = newState;
        Debug.Log("전투 상태 전환: " + newState);
    }

    public bool IsBattleOver() => state == BattleState.Win || state == BattleState.Lose;
}
