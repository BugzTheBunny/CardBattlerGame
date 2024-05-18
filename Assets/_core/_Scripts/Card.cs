using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Card : MonoBehaviour
{

    [Header(" Card Data ")]
    public CardSO cardData;

    public int currentHealth;
    public int attack;
    public int manaCost;

    [Header(" Card UI - Text")]
    public TextMeshProUGUI currentHealthText;
    public TextMeshProUGUI attackText;
    public TextMeshProUGUI manaCostText;
    public TextMeshProUGUI nameText, actionDescriptionText, loreText;

    [Header(" Card UI - Visuals")]
    public Image characterArt;
    public Image backgroundArt;

    void Start()
    {
        SetupCard();   
    }

    public void SetupCard()
    {

        currentHealth = cardData.currentHealth;
        attack = cardData.attack;
        manaCost = cardData.manaCost;

        currentHealthText.text = currentHealth.ToString();
        attackText.text = currentHealth.ToString();
        manaCostText.text = currentHealth.ToString();

        nameText.text = cardData.cardName;
        actionDescriptionText.text = cardData.actionDescription;
        loreText.text = cardData.cardLore;

        characterArt.sprite = cardData.characterSprite;
        backgroundArt.sprite = cardData.bgSprite;
    }
    
    void Update()
    {
        
    }
}
