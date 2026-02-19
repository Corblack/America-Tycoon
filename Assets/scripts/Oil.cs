using UnityEngine;
using TMPro;

public class Oil : MonoBehaviour
{
    private int level = 0;

    private float levelUpPrice = 2500f;    
    private float price = 100f;           
    private float costMultiplyer = 1.20f;
    private float productionMultiplyer = 1.10f ;

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

            price *= productionMultiplyer ;
            levelUpPrice *= costMultiplyer ;

            DisplayAll();
        }
    }

    public float OverTimeOil()
    {
        return level > 0 ? price : 0f;
    }

    public void DisplayPrice()
    {
        _priceUpgrade.SetText("Price : {0:0.00}$", levelUpPrice);
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

    public int getLevel(){
        return level ;
    }

}
