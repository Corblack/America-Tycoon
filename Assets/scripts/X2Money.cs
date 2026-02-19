using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class X2Money : MonoBehaviour
{
    private int level = 0;
    private const int MAX_LEVEL = 5;

    private float price = 500f;

    [SerializeField] private TMP_Text LevelTxt;
    [SerializeField] private TMP_Text PriceTxt;

    [SerializeField] private Button upgradeButton;

    [SerializeField] private GameObject imageUpgrade;

    public void LevelUp()
    {
        if (level >= MAX_LEVEL)
            return;

        level++;
        price *= 2;

        DisplayAll();
    }

    public int getLevel()
    {
        return level;
    }

    public void DisplayAll()
    {
        LevelTxt.SetText("Level : {0}/{1}", level, MAX_LEVEL);

        if (level >= MAX_LEVEL)
        {
            PriceTxt.SetText("MAX");

            upgradeButton.interactable = false;
            imageUpgrade.SetActive(true);
        }
        else
        {
            PriceTxt.SetText("Price : {0:0.00}$", price);
            upgradeButton.interactable = true;
        }
    }
}