using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Neuer Sprecher", menuName = "Dialog/Neuer Sprecher")]
public class Sprecher : ScriptableObject
{
    [SerializeField] private string sprecherName;
    [SerializeField] private Sprite sprecherSprite;

    public string GetSprecherName () 
    { 
        return sprecherName; 
    }
    public Sprite GetSprecherSprite () 
    {
        return sprecherSprite;
    }
}
