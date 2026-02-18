using UnityEngine;
using TMPro;

public class Coal : MonoBehaviour
{
    private int level = 0;

    private float levelUpPrice = 5f;
    private float price = 2.5f;
    private float scaling = 1.25f;

    [SerializeField]
    private Wallet wallet;

    [SerializeField]
    private TMP_Text _priceUpgrade;

    [SerializeField]
    private TMP_Text _buttonText;

    [SerializeField]
    private TMP_Text _levelText;

    [SerializeField]
    private GameObject CoalSprite;

    public void LevelUp()
    {
        if (wallet.IsBuyable(levelUpPrice))
        {
            wallet.RemoveDollars(levelUpPrice);

            level++;
            ActivateCoalSprite();

            price *= scaling;
            levelUpPrice *= scaling;

            DisplayAll();
        }
    }

    public float OverTimeCoal()
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
        _buttonText.SetText(level < 1 ? "Buy Coal Mine" : "Upgrade Coal Mine");
    }

    public void DisplayAll()
    {
        DisplayButton();
        DisplayLevel();
        DisplayPrice();
    }

    public void ActivateCoalSprite()
    {
        CoalSprite.SetActive(false);
        if(level >= 1)
        {
            CoalSprite.SetActive(true);
        }
    }


}
