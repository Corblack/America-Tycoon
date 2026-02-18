using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Wallet wallet;
    [SerializeField] private Stone stone;
    [SerializeField] private Coal coal;

    [SerializeField] private Oil oil;

    [SerializeField] private Uranium uranium;

    private float timer = 0f;
    private float interval = 1f;

    private void Start()
    {
        stone.DisplayAll();
        coal.DisplayAll();
        oil.DisplayAll();
        uranium.DisplayAll();
        wallet.DisplayWallet();
        coal.ActivateCoalSprite();
        stone.ActivateStoneSprite();
        oil.ActivateOilSprite();
        uranium.ActivateUraniumSprite();
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
        totalIncome += oil.OverTimeOil();
        totalIncome += uranium.OverTimeUranium();

        // ICI ON DOIT RAJOUTER LES NOUVEAUX ELEMENTS SINON ILS FONT PAS D4ARGENT

        wallet.AddDollars(totalIncome);
    }

    private void RefreshUI()
    {
        stone.DisplayAll();
        coal.DisplayAll();
        oil.DisplayAll();
        uranium.DisplayAll();

        // ET ICI AUSSI SINON CA AFFICHE MAL 
    }
}
