using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "CardGame/Cartas", order = 1)]
public class Card : ScriptableObject
{
    public string cardName;
    public string description;
    public int cardAtack;
    public int cardDefend;

    public void ShowInfo()
    {
        Debug.Log(cardName + " " + description +
            " " + cardAtack + " " + cardDefend);
    }
}
