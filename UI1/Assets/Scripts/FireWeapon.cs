using UnityEngine;

public class FireWeapon : Weapon

{
    [SerializeField] private int fireDamage = 2;
    public override void ApplyEffect(Character character)
    {
        character.TakeDamage(fireDamage);
        Debug.Log(character.name + " took " + fireDamage + "fire damage");
    }
}
