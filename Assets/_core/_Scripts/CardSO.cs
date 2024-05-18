using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardSO_", menuName = "Cards/CardSO",order = 1)]
public class CardSO : ScriptableObject
{
    public string cardName;
    
    [TextArea]
    public string actionDescription;
    [TextArea]
    public string cardLore;

    public int currentHealth;
    public int attack;
    public int manaCost;

    public Sprite characterSprite, bgSprite;

}
