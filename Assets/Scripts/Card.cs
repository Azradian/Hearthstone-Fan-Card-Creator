using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Let's create a scriptable object that can be used to easily create more cards!

[CreateAssetMenu]
public class Card : ScriptableObject
{
    public string cardName;
    public string cardDescription;

    public Sprite cardArt;

    public int manaCost;
    public int attack;
    public int health;

    public void PrintCardInfo()
    {
        Debug.Log(cardName + ": " + cardDescription + " The card costs: " + manaCost);
    }
}
