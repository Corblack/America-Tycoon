using UnityEngine;
using TMPro;
using NUnit.Framework;

public class Coal : MonoBehaviour
{
    private int level = 0;
    private float levelUpPrice = 5f;
    private float price = 2.5f;
    private float productionMultiplyer = 1.10f;
    private float costMultiplyer = 1.25f;


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
       if(wallet.canAfford(levelUpPrice)){
        
        wallet.removeMoney(levelUpPrice);

        level++ ;

        price *= productionMultiplyer;
        levelUpPrice *= costMultiplyer;

        DisplayAll();

       }
    }

    public float OverTimeCoal()
    {
        if (level >= 1)
            return price;

        return 0f;
    }
     
    public float getLevelUpPrice()
    {
        return levelUpPrice;
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
