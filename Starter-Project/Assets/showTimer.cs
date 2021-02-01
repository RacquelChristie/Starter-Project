using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showTimer : MonoBehaviour
{

    public GameObject uiObject;


    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
            {
                uiObject.SetActive(true);
            }
        
    }
}
