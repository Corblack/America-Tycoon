using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Wallet wallet;
    [SerializeField] private Stone stone;
    [SerializeField] private Coal coal;

    private float timer = 0f;
    private float interval = 1f;

    private void Start()
    {
        stone.DisplayAll();
        coal.DisplayAll();
        wallet.DisplayWallet();
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            ProduceIncome();
            RefreshUI();
            timer = 0f;
        }
    }

    private void ProduceIncome()
    {
        float totalIncome = 0f;

        totalIncome += stone.OverTimeStone();
        totalIncome += coal.OverTimeCoal();

        wallet.AddDollars(totalIncome);
    }

    private void RefreshUI()
    {
        stone.DisplayAll();
        coal.DisplayAll();
    }
}
