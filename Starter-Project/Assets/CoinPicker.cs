using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI textCoins;

    public Text winText;



    
    void Start ()
    {
        winText.text = "";
    }

    
    

    private void OnTriggerEnter2D(Collider2D other)

    {
        if(other.transform.tag == "Coin")
        {
            coin ++;
            textCoins.text = coin.ToString();
            GetComponent<AudioSource>().Play();


                     
    if (coin >= 2)

    {
        winText.text = "You Win!";
    }
            


            Destroy(other.gameObject);


           
            
        }

        
    }

    
    
    
   
}
