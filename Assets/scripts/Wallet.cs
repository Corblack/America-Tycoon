using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    private float wallet = 0.0f;

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

    public void DisplayWallet()
    {
        _walletText.SetText("${0:0.00}", wallet);
    }
}
