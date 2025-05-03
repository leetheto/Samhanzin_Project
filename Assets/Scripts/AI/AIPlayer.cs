using UnityEngine;

public class AIPlayer : MonoBehaviour
{
    public string aiID;
    public Nation nation;
    public int power;

    public void Act()
    {
        TryAttackEnemyCity();
        TryDefendCapital();
    }

    // ✅ 외부 호출을 위해 public으로 수정
    public void TryAttackEnemyCity()
    {
        Debug.Log($"{aiID} is attacking an enemy city.");
        // TODO: 실제 공격 로직 구현
    }

    public void TryDefendCapital()
    {
        Debug.Log($"{aiID} is defending capital.");
        // TODO: 실제 방어 로직 구현
    }
}
