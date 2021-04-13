using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardInterface : MonoBehaviour
{
    public Card card;

    public TMP_Text nameText;
    public TMP_Text descriptionText;

    public Image artImage;

    public TMP_Text manaCostText;
    public TMP_Text attackText;
    public TMP_Text healthText;


    void Start()
    {
        // Let's create our card!

        /*
        nameText.text = card.cardName;
        descriptionText.text = card.cardDescription;

        artImage.sprite = card.cardArt;

        manaCostText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
        healthText.text = card.health.ToString();
        */

        nameText.SetText(card.cardName);
        descriptionText.SetText(card.cardDescription);

        artImage.sprite = card.cardArt;

        manaCostText.SetText(card.manaCost.ToString());
        attackText.SetText(card.attack.ToString());
        healthText.SetText(card.health.ToString());
    }


}
