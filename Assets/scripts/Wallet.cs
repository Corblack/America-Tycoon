using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    private float wallet = 0.0f;
    private float timing = 1.0f;
    private float timer = 0.0f;
    [SerializeField] 
    private TMP_Text _walletText;

    public void AddDollars()
    {
        wallet += 1;
        DisplayWallet();
        Debug.Log("----------" + wallet + "----------------");
    }


    public void OverTime()
    {

        timer += Time.deltaTime;
        if (timer >= timing)
        {
            wallet += 1;
            DisplayWallet();
            Debug.Log(wallet);
            timer = 0;
        }

    }

    public void DisplayWallet()
    {
        _walletText.SetText("${0}", wallet);
        
    }

    public void Update()
    {
        OverTime();
    }



}
