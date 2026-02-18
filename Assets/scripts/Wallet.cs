using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    private float timing = 1.0f;
    private float timer = 0.0f;
    private float wallet = 0.0f;

    private bool buyable = true;

    [SerializeField] 
    private TMP_Text _walletText;

    [SerializeField]
    private Coal coal;

    public void AddDollars()
    {
        wallet += 1f;
        DisplayWallet();
    }

    public void DisplayWallet()
    {
        _walletText.SetText("${0:0.00}", wallet);
    }

    public void OverTime()
    {
        timer += Time.deltaTime;

        if (timer >= timing)
        {
            wallet += coal.OverTimeCoal();
            timer = 0f;

            DisplayWallet();
            coal.DisplayAll();
        }
    }

    public bool canAfford(float ammount)
    {
       return wallet >= ammount;
    }

    public  float removeMoney(float ammount)
    {
        return wallet -= ammount;
        DisplayWallet();
    }

    private void Update()
    {
        OverTime();
    }
}
