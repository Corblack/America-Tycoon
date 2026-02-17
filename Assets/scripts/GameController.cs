using UnityEngine;

public class GameController : MonoBehaviour
{

    int wallet = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        wallet += 1;
        Debug.Log(wallet);   
    }

}
