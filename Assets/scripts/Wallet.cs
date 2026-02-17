using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int wallet = 0;
    private float timing = 1.0f;
    private float timer = 0.0f;

    public void AddDollars()
    {
        wallet += 1;
        Debug.Log("----------" + wallet + "----------------");
    }


    public void OverTime()
    {

        timer += Time.deltaTime;
        if (timer >= timing)
        {
            wallet += 1;
            Debug.Log(wallet);
            timer = 0;
        }

    }

    public void Update()
    {
        OverTime();
    }



}
