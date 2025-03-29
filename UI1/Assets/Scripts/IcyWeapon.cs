using UnityEngine;

public class IcyWeapon : Weapon

{
    [SerializeField] private int icyDamage = 2;
    public override void ApplyEffect(Character character)
    {
        character.TakeDamage(icyDamage);
        Debug.Log(character.name + " took " + icyDamage + "icy damage");
    }
}
