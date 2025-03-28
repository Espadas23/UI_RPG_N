using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int health;
    [SerializeField] private Weapon activeWeapon;
    public Weapon ActiveWeapon
    {
        get { return activeWeapon; }
        set 
        { 
            if (value != null)
            {
                activeWeapon = value;
                Debug.Log("New weapon equiped: " + activeWeapon.name);
            }
            else
            {
                Debug.LogWarning("Weapon slot is empty");
            }
        }
    }

    public virtual int Attack()
    {
        return activeWeapon.GetDamage();
    }
    

    public void TakeDamage(int damage)
    {
        Debug.Log(name+ " health before hit: "+ health);
        health -= damage;
        Debug.Log(name+ " health after hit: "+ health);
    }

    public void TakeDamage(Weapon weapon)
    {
        Debug.Log(name+ " health before hit: "+ health);
        health -= weapon.GetDamage();
        weapon.ApplyEffect(this);
        Debug.Log(name+ " health after hit: "+ health);
    }
}