using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Wallet wallet;
    [SerializeField] private Stone stone;
    [SerializeField] private Coal coal;

    [SerializeField] private Oil oil;

    [SerializeField] private X2Money money ;

    [SerializeField] private Uranium uranium;

    [SerializeField] private GameObject coalPanel;

    [SerializeField] private GameObject oilPanel;

    [SerializeField] private GameObject uraniumPanel;

    [SerializeField] private GameObject MoneyX2;



    


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
        money.DisplayAll();
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
        if(money.getLevel() == 5){
            totalIncome *= 2 ;
        }

        

        wallet.AddDollars(totalIncome);
    }

    private void RefreshUI()
    {
        stone.DisplayAll();
        coal.DisplayAll();
        oil.DisplayAll();
        uranium.DisplayAll(); 
    }

    public void showUpgrade(){
        if(stone.getLevel() >= 25 ){
        coalPanel.SetActive(true);
        }
        if(coal.getLevel() >= 25 ){
            oilPanel.SetActive(true);
        }
         if(oil.getLevel() >= 25 ){
            uraniumPanel.SetActive(true);
        }
    }
}
