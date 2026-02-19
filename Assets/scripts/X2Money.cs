using UnityEngine;
using TMPro;

public class X2Money : MonoBehaviour
{
    private int level = 0 ;
    private float price = 500f ;

    [SerializeField] private TMP_Text LevelTxt ;

    [SerializeField] private TMP_Text PriceTxt ;

    public void LevelUp(){
        level ++ ;
        price *= 2 ;
    }

    public int getLevel(){
        return level ;
    }

     public void DisplayAll()
    {   
        LevelTxt.SetText("Level : {0}", level);
        PriceTxt.SetText("Price : {0:0.00}$", price);
    }

}
