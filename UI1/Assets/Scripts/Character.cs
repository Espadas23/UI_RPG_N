using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] private Weapon activeWeapon;
    public int Attack()
    {
        return activeWeapon.GetDamage();
    }

    public void TakeDamage(int damage)
    {
        Debug.Log(name+ "health before hit: "+ health);
        health -= damage;
        Debug.Log(name+ "health after hit: "+ health);
    }
}
