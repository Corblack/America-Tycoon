using UnityEngine;
using TMPro;

public class Oil : MonoBehaviour
{
    private int level = 0;

    private float levelUpPrice = 15f;    
    private float price = 7.5f;          
    private float scaling = 1.35f;      

    [SerializeField]
    private Wallet wallet;

    [SerializeField]
    private TMP_Text _priceUpgrade;

    [SerializeField]
    private TMP_Text _buttonText;

    [SerializeField]
    private TMP_Text _levelText;

    [SerializeField]
    private GameObject OilSprite;

    public void LevelUp()
    {
        if (wallet.IsBuyable(levelUpPrice))
        {
            wallet.RemoveDollars(levelUpPrice);

            level++;
            ActivateOilSprite();

            price *= scaling;
            levelUpPrice *= scaling;

            DisplayAll();
        }
    }

    public float OverTimeOil()
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
        _buttonText.SetText(level < 1 ? "Buy Oil Rig" : "Upgrade Oil Rig");
    }

    public void DisplayAll()
    {
        DisplayButton();
        DisplayLevel();
        DisplayPrice();
    }

    public void ActivateOilSprite()
    {
        OilSprite.SetActive(false);
        if (level >= 1)
        {
            OilSprite.SetActive(true);
        }
    }
}
