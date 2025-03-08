using UnityEngine;

public class Player : Characters
{
    [SerializeField] private string charName;

    public string CharName
    {
        get { return charName; }
    }
}
