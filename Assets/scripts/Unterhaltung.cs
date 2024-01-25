using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Neue Unterhaltung", menuName = "Dialog/Neue Unterhaltung")]

public class Unterhaltung : ScriptableObject
{
    [SerializeField] private DialogLines[] alllines;

    public DialogLines GetDialogLines(int index)
    {  
        return alllines[index];
    }

    public int GetLength() 
    
    { 
        return alllines.Length - 1; 
    }

}
