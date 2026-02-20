using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    private float wallet = 0f;

    [SerializeField] 
    private TMP_Text _walletText;

    public void AddDollars(float amount)
    {
        wallet += amount;
        DisplayWallet();
    }

    public bool IsBuyable(float amount)
    {
        return wallet >= amount;
    }

    public void RemoveDollars(float amount)
    {
        wallet -= amount;
        DisplayWallet();
    }

    public string formatedWallet(float value){
        if(value >= 1000000000f){
            return (value / 1000000000f).ToString("F2") + "B"   ;
        }

        if( value >= 1000000f ){
            return (value / 1000000f).ToString("F2") + "M" ;
        }

        if(value >= 1000f){
            return (value / 1000f).ToString("F2") + "K";
        }

        return value.ToString("F2") ;
    }

    public void DisplayWallet()
    {
        string formatedAmmount = formatedWallet(wallet);
        _walletText.SetText($"${formatedAmmount}");
    }
}