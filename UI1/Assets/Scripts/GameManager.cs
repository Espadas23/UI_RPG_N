using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    public Character character;
    // Start is called before the first frame update
    void Start()
    {
        int playerDamage = player.Attack();
        enemy.TakeDamage(playerDamage);
        //Debug.Log("player name: " + player.CharName);
        int enemyDamage = enemy.Attack();
        player.TakeDamage(enemyDamage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
