using UnityEngine;

public class BattleUnit : MonoBehaviour
{
    public string unitName;
    public int maxHP;
    public int currentHP;
    public int atk;

    // 🔧 Buff 적용을 위한 추가 필드
    public int def;           // 방어력
    public int baseDEF = 10;  // 기본 방어력 (BuffManager에서 사용)

    public bool IsDead => currentHP <= 0;

    public void Setup(string name, int hp, int attack)
    {
        unitName = name;
        maxHP = hp;
        currentHP = hp;
        atk = attack;
        def = 0; // 초기화
    }

    public void TakeDamage(int damage)
    {
        int finalDamage = Mathf.Max(damage - def, 0); // 방어력 반영
        currentHP -= finalDamage;
        if (currentHP < 0) currentHP = 0;
    }

    public int Attack()
    {
        return atk;
    }
}
