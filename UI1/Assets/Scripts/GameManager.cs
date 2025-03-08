using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Enemy enemy;
    [SerializeField] private Characters character;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player.ReportHealth();
        Debug.Log(player.CharName);
        enemy.ReportHealth();
        character.ReportHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
