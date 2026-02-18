using UnityEngine;
using TMPro;

public class Uranium : MonoBehaviour
{
    private int level = 0;

    private float levelUpPrice = 50f;     // Plus cher que Oil
    private float price = 20f;            // Rapporte plus que Oil
    private float scaling = 1.5f;         // Scaling encore plus fort

    [SerializeField]
    private Wallet wallet;

    [SerializeField]
    private TMP_Text _priceUpgrade;

    [SerializeField]
    private TMP_Text _buttonText;

    [SerializeField]
    private TMP_Text _levelText;

    [SerializeField]
    private GameObject UraniumSprite;

    public void LevelUp()
    {
        if (wallet.IsBuyable(levelUpPrice))
        {
            wallet.RemoveDollars(levelUpPrice);

            level++;
            ActivateUraniumSprite();

            price *= scaling;
            levelUpPrice *= scaling;

            DisplayAll();
        }
    }

    public float OverTimeUranium()
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
        _buttonText.SetText(level < 1 ? "Buy Uranium Plant" : "Upgrade Uranium Plant");
    }

    public void DisplayAll()
    {
        DisplayButton();
        DisplayLevel();
        DisplayPrice();
    }

    public void ActivateUraniumSprite()
    {
        UraniumSprite.SetActive(false);
        if (level >= 1)
        {
            UraniumSprite.SetActive(true);
        }
    }
}
