using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TextMeshProUGUI sprecherName, dialog, navButtonText;
    public Sprite sprecherSprite;

    private int currentIndex;
    private Unterhaltung currentConvo;
    private static DialogManager instance;
    //private Coroutine typing;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void StartUnterhaltung(Unterhaltung convo)
    {
        instance.currentConvo = convo;
        instance.sprecherName.text = "";
        instance.dialog.text = "";
        instance.navButtonText.text = ">";
        instance.currentIndex = 0;

        instance.ReadNext();
    }

    public void ReadNext()
    {
        if (currentIndex > currentConvo.GetLength())
        {
            return;
        }
        

    }

}
