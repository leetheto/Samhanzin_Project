using UnityEngine;

public class AILogicHandler : MonoBehaviour
{
    public void RunAI(AIPlayer ai)
    {
        if (ShouldAttack(ai))
            ai.TryAttackEnemyCity();
        else if (ShouldDefend(ai))
            ai.TryDefendCapital();
    }

    bool ShouldAttack(AIPlayer ai)
    {
        return ai.power > 1000;
    }

    bool ShouldDefend(AIPlayer ai)
    {
        return ai.power <= 1000;
    }
}
