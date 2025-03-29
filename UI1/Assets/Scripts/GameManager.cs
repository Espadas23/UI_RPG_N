using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    [SerializeField] private TMP_Text playerName, playerHealth, enemyName, enemyHealth;
    [SerializeField] private List<Weapon> availableWeapons;
    void Start()
    {
        RefreshUI();
    }
    public void DoRound()
    {
        ChangePlayerWeapon();
        //int playerDamage = player.Attack();
        //enemy.TakeDamage(playerDamage);
        enemy.TakeDamage(player.ActiveWeapon);
        int enemyDamage = enemy.Attack();
        player.TakeDamage(enemyDamage);
        RefreshUI();
    }
    
    private void ChangePlayerWeapon()
    {
        if (availableWeapons.Count > 0)
        {
            int randomIndex = Random.Range(0, availableWeapons.Count);
            player.ActiveWeapon = availableWeapons[randomIndex];
            Debug.Log("Player change weapon: " + player.ActiveWeapon.name);
        }
    }
    private void RefreshUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.name;
        playerHealth.text ="health: "+ player.health.ToString();
        enemyHealth.text = "health: "+enemy.health.ToString();
    }
}

    
