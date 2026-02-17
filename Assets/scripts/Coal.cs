using UnityEngine;
using TMPro;

public class Coal : MonoBehaviour
{
    private int level = 0;
    private float levelUpPrice = 5f;
    private float price = 2.5f;

    [SerializeField]
    private Wallet wallet;

    [SerializeField] 
    private TMP_Text _priceUpgrade;

    [SerializeField] 
    private TMP_Text _coalButton;

    [SerializeField] 
    private TMP_Text _coalLevel;

    public void levelUp()
    {
        level += 1;

        // Augmente les gains de 5% (moins agressif)
        price *= 1.25f;

        // Augmente le prix d'upgrade de 25% (moins agressif)
        levelUpPrice *= 1.25f;

        DisplayAll();
    }

    public float OverTimeCoal()
    {
        if (level >= 1)
            return price;

        return 0f;
    }

    public void DisplayCoalPriceUpgrade()
    {
        _priceUpgrade.SetText("Price upgrade : {0:0.00}$", levelUpPrice);
    }

    public void DisplayCoalLevel()
    {
        _coalLevel.SetText("Level : {0}", level);
    }

    public void DisplayCoalBuyOrUpgrade()
    {
        if (level < 1)
            _coalButton.SetText("Buy Coal Mine");
        else
            _coalButton.SetText("Upgrade Coal Mine");
    }

    public void DisplayAll()
    {
        DisplayCoalBuyOrUpgrade();
        DisplayCoalLevel();
        DisplayCoalPriceUpgrade();
    }
}
