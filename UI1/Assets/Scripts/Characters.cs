using UnityEngine;

public class Characters : MonoBehaviour
{
    public int health = 5;

    public void ReportHealth()
    {
        Debug.Log(name +" health:"+ health);
    }
}
