using UnityEngine;

public class Berserker : Enemy
{
    [SerializeField] private int aggresionGain = 10;
    public override int Attack()
    {
        aggresion += aggresionGain;
        return ActiveWeapon.GetDamage() + aggresion / 10;
    }
}
