using UnityEngine;
using TMPro;

public class Stone : MonoBehaviour
{
    private int level = 0;

    private float levelUpPrice = 3f;
    private float price = 1.5f;  
    private float scaling = 1.20f;     

    [SerializeField]
    private Wallet wallet;

    [SerializeField] 
    private TMP_Text _priceUpgrade;

    [SerializeField] 
    private TMP_Text _buttonText;

    [SerializeField] 
    private TMP_Text _levelText;

    [SerializeField] 
    private GameObject StoneSprite;



    public void LevelUp()
    {
        if (wallet.IsBuyable(levelUpPrice))
        {
            wallet.RemoveDollars(levelUpPrice);

            level++;
            ActivateStoneSprite();

            price *= scaling;
            levelUpPrice *= scaling;

            DisplayAll();
        }
    }

    public float OverTimeStone()
    {
        return level > 0 ? price : 0f;
    }

    public void DisplayPrice()
    {
        _priceUpgrade.SetText("Price upgrade : {0:0.00}$", levelUpPrice);
    }

    public void DisplayLevel()
    {
        _levelText.SetText("Level : {0}", level);
    }

    public void DisplayButton()
    {
        _buttonText.SetText(level < 1 ? "Buy Stone Mine" : "Upgrade Stone Mine");
    }

    public void DisplayAll()
    {
        DisplayButton();
        DisplayLevel();
        DisplayPrice();
    }

        public void ActivateStoneSprite()
    {
        StoneSprite.SetActive(false);
        if(level >= 1)
        {
            StoneSprite.SetActive(true);
        }
    }
}
