using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance;

    public BattleUnit playerUnit;
    public BattleUnit enemyUnit;

    public BattleState state = BattleState.Idle;

    private void Awake()
    {
        Instance = this;
    }

    public void StartBattle(UnitData_SO playerData, UnitData_SO enemyData)
    {
        playerUnit.Setup(playerData.unitName, playerData.baseHP, playerData.baseATK);
        enemyUnit.Setup(enemyData.unitName, enemyData.baseHP, enemyData.baseATK);

        state = BattleState.Start;
        StartCoroutine(AutoBattleHandler.RunBattle(playerUnit, enemyUnit));
    }
}
